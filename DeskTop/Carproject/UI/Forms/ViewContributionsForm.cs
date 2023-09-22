using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Forms
{
    public partial class ViewContributionsForm : Form
    {
        public ViewContributionsForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (ValidatingFunctions.id_contribute > 0)
            {

                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    string command;
                    command = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration,contr.proft_num,contr.withdraw_num FROM contr WHERE contr.id= @id;";
                    cmd.CommandText = command;

                    cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_contribute);
                    MySqlDataAdapter rd = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    rd.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        bill_search.DataSource = dt;
                        bill_search.Columns[0].HeaderText = "رقم المساهمة";
                        bill_search.Columns[1].HeaderText = "الأسم";
                        bill_search.Columns[2].HeaderText = "الهاتف ";
                        bill_search.Columns[3].HeaderText = "مبلغ المساهمة";
                        bill_search.Columns[4].HeaderText = "تاريخ الدفع القادم";
                        bill_search.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                        bill_search.Columns[5].HeaderText = "تاريخ الانشاء";
                        bill_search.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
                        bill_search.Columns[6].HeaderText = "ملاحظات";
                        bill_search.Columns[7].HeaderText = "فترة الدفع";
                        bill_search.Columns[8].HeaderText = "عدد قسائم الارباح";
                        bill_search.Columns[9].HeaderText = "عدد العمليات";
                        button2.Enabled = true;
                        button3.Enabled = true;


                    }
                    else
                    { MessageBox.Show("لا يوجد نتائج"); }
                    con.Close();
                }
                catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
                catch (Exception eee) { MessageBox.Show("خطأ"); }
            }
            else
            {

                ValidatingFunctions.id_contribute = 0;
            }

        }
        private void AlertsWF_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreenForm form1 = (HomeScreenForm)System.Windows.Forms.Application.OpenForms["Form1"];
            form1.button5_Click(sender, e);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            if (id_radio.Checked == true || name_radio.Checked == true || date_radio.Checked == true)
            {
                string error = "";
                try
                {
                    bill_search.DataSource = null;
                    TextBox search_name;
                    NumericUpDown search_id;
                    DateTimePicker search_date;
                    List<RadioButton> arr_radio = new List<RadioButton>() { id_radio, name_radio, date_radio };
                    List<Control> arr_options = new List<Control>() { id_search, name_search, date_search };
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    string command;
                    MySqlDataAdapter rd;
                    foreach (RadioButton i in arr_radio)
                    {
                        if (i.Checked == true)
                        {
                            int index = arr_radio.IndexOf(i);
                            if (index == 1)
                            {
                                search_name = (TextBox)arr_options.ElementAt<Control>(index);
                                string name = name_search.Text;
                                command = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration,contr.proft_num,contr.withdraw_num FROM contr WHERE contr.name Like @name;";
                                cmd.CommandText = command;
                                cmd.Parameters.AddWithValue("@name", name + "%");
                            }
                            else if (index == 0)
                            {
                                search_id = (NumericUpDown)arr_options.ElementAt<Control>(index);
                                string id = search_id.Value.ToString();
                                command = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration,contr.proft_num,contr.withdraw_num FROM contr WHERE contr.id= @id;";
                                cmd.CommandText = command;
                                cmd.Parameters.AddWithValue("@id", id);
                            }
                            else
                            {
                                search_date = (DateTimePicker)arr_options.ElementAt<Control>(index);
                                DateTime date = search_date.Value.Date;
                                command = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration,contr.proft_num,contr.withdraw_num FROM contr WHERE contr.create_date=@date;";
                                cmd.CommandText = command;
                                cmd.Parameters.AddWithValue("@date", date);
                            }

                            break;
                        }
                    }
                    rd = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    rd.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        bill_search.DataSource = dt;
                        bill_search.Columns[0].HeaderText = "رقم المساهمة";
                        bill_search.Columns[1].HeaderText = "الأسم";
                        bill_search.Columns[2].HeaderText = "الهاتف ";
                        bill_search.Columns[3].HeaderText = "مبلغ المساهمة";
                        bill_search.Columns[4].HeaderText = "تاريخ الدفع القادم";
                        bill_search.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                        bill_search.Columns[5].HeaderText = "تاريخ الانشاء";
                        bill_search.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
                        bill_search.Columns[6].HeaderText = "ملاحظات";
                        bill_search.Columns[7].HeaderText = "فترة الدفع";
                        bill_search.Columns[8].HeaderText = "عدد قسائم الارباح";
                        bill_search.Columns[9].HeaderText = "عدد المسحوبات";
                        button2.Enabled = true;
                        button3.Enabled = true;


                    }
                    else
                    {
                        installs_info.DataSource = null;
                        car_info.DataSource = null;
                        MessageBox.Show("لا يوجد نتائج");
                    }
                    con.Close();
                    installs_info.DataSource = null;
                    car_info.DataSource = null;

                }
                catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
                catch (Exception eee) { MessageBox.Show("خطأ"); }
            }
        }

        private void id_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (id_radio.Checked == true)
            {
                id_search.Value = 0;
                id_search.Visible = true;
                date_search.Visible = false;
                name_search.Visible = false;
            }
        }

        private void name_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (name_radio.Checked == true)
            {
                name_search.Text = "";
                id_search.Visible = false;
                date_search.Visible = false;
                name_search.Visible = true;
            }
        }

        private void date_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (date_radio.Checked == true)
            {
                id_search.Visible = false;
                date_search.Visible = true;
                name_search.Visible = false;
            }
        }
        private void fill_information(int id)
        {
            try
            {
                List<bool> type = new List<bool>() { };
                installs_info.DataSource = null;
                installs_info.Rows.Clear();
                installs_info.Refresh();
                car_info.DataSource = null;
                car_info.Rows.Clear();
                car_info.Refresh();
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd_type = con.CreateCommand();
                cmd_type.CommandText = "SELECT withdarws.withdraw FROM withdarws WHERE withdarws.contr_id=@id;";
                cmd_type.Parameters.AddWithValue("id", id);
                MySqlDataReader rd = cmd_type.ExecuteReader();
                while (rd.Read())
                {
                    type.Add((bool)rd[0]);
                }
                rd.Close();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT profit.contr_id,profit.pay_value,profit.paying_date,profit.notes FROM profit WHERE profit.contr_id=@id;";
                cmd1.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter ab1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                ab1.Fill(dt1);


                DataColumn col = dt1.Columns.Add("الترتيب", typeof(int));
                col.SetOrdinal(0);

                installs_info.DataSource = dt1;
                if (installs_info.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        installs_info.Rows[i].Cells[0].Value = i + 1;
                    }
                }
                installs_info.DataSource = dt1;
                installs_info.Columns[1].HeaderText = "رقم المساهمة";
                installs_info.Columns[2].HeaderText = "المبلغ";
                installs_info.Columns[3].HeaderText = "تاريخ الدفع";
                installs_info.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";
                installs_info.Columns[4].HeaderText = "ملاحظات";

                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "SELECT withdarws.contr_id,withdarws.withdraw_value,withdarws.withdraw_date,withdarws.notes FROM withdarws WHERE withdarws.contr_id=@id;";
                cmd2.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter ab2 = new MySqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                ab2.Fill(dt2);
                DataColumn col1 = dt2.Columns.Add("الترتيب", typeof(int));
                DataColumn col2 = dt2.Columns.Add("hghjg", typeof(string));


                col1.SetOrdinal(0);


                car_info.DataSource = dt2;
                if (car_info.Rows.Count > 0)
                {
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        car_info.Rows[i].Cells[0].Value = i + 1;
                        if (type[i] == true)
                        {
                            car_info.Rows[i].Cells[5].Value = "سحب";
                        }
                        else
                        {
                            car_info.Rows[i].Cells[5].Value = "اضافة";

                        }

                    }

                }
                car_info.Columns[1].HeaderText = "رقم المساهمة";
                car_info.Columns[2].HeaderText = "المبلغ";
                car_info.Columns[3].HeaderText = "تاريخ الدفع";
                car_info.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";
                car_info.Columns[4].HeaderText = "ملاحظات";
                car_info.Columns[5].HeaderText = "نوع العملية";


                con.Close();

            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
            }
        }
        private void bill_search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (bill_search.Rows.Count > 0)
                {
                    int index = bill_search.SelectedRows[0].Index;

                    int id = int.Parse(bill_search.Rows[index].Cells[0].Value.ToString());
                    ValidatingFunctions.contr_id_inside_profit = id;
                    ValidatingFunctions.id_contribute = id;
                    EditContributionForm ed = new EditContributionForm();
                    ed.ShowDialog();



                    Form3_Load(sender, e);


                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bill_search.Rows.Count > 0)
            {
                ValidatingFunctions.contr_id_to_add_profit = int.Parse(bill_search.SelectedRows[0].Cells[0].Value.ToString());
                AddProfitFrom ad = new AddProfitFrom();
                installs_info.DataSource = null;
                car_info.DataSource = null;
                ad.ShowDialog();

                Form3_Load(sender, e);
                car_info.DataSource = null;
                installs_info.DataSource = null;
                int index = bill_search.SelectedRows[0].Index;

                int id = int.Parse(bill_search.Rows[index].Cells[0].Value.ToString());
                ValidatingFunctions.contr_id_inside_profit = id;
                fill_information(id);
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    MySqlCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "SELECT SUM(pay_value) FROM profit WHERE  contr_id=@id;";
                    cmd.Parameters.AddWithValue("@id", id);

                    contr1.Text = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (MySqlException ee)
                {
                    MessageBox.Show("خطأ في السيرفر");
                }
                catch (Exception eee)
                {
                    MessageBox.Show("خطأ");
                }


                //bill_search.Enabled = false;
                //groupBox3.Visible = false;
                //groupBox3_3.Visible = true;
                //groupBox2.Enabled = false;
                //groupBox1.Enabled = false;
                //name1.Text = bill_search.Rows[ValidatingFunctions.contr_id_inside_profit].Cells[1].Value.ToString();
                //number1.Text = bill_search.Rows[ValidatingFunctions.contr_id_inside_profit].Cells[2].Value.ToString();
                //id1.Text = bill_search.Rows[ValidatingFunctions.contr_id_inside_profit].Cells[0].Value.ToString();
                //total_price1.Text = bill_search.Rows[ValidatingFunctions.contr_id_inside_profit].Cells[3].Value.ToString();
                //textBox4.Text = bill_search.Rows[ValidatingFunctions.contr_id_inside_profit].Cells[4].Value.ToString();
                //numericUpDown1.Maximum = int.Parse(bill_search.Rows[ValidatingFunctions.contr_id_inside_profit].Cells[3].Value.ToString());
            }
            else { MessageBox.Show("برجاء تحديد مساهمة"); }

        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            //if (numericUpDown1.Value > 0)
            //{
            //MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            //con.Open();
            //MySqlCommand cmd = con.CreateCommand();
            //string command = "UPDATE installs SET installs.Stat=true , installs.Paid_price=installs.Total_price ,installs.To_pay_price=0 WHERE installs.id_install=@id;";
            //cmd.CommandText = command;
            //cmd.Parameters.AddWithValue("@id", id);
            //MySqlCommand cmd2 = con.CreateCommand();
            //cmd2.CommandText = "UPDATE bills SET bills.paid_installs_number=bills.paid_installs_number+1,bills.notpaid_installs_number=bills.notpaid_installs_number-1 WHERE bills.id=@id;";
            //cmd2.Parameters.AddWithValue("@id", id1);
            //    //cmd2.ExecuteNonQuery();
            //}
            //groupBox3.Visible = true;
            //groupBox3_3.Visible = false;
            //groupBox2.Enabled = true;
            //groupBox1.Enabled = true;
            //button3.Enabled = true;
            //bill_search.Enabled = true;
            //groupBox3.Visible = true;
            //groupBox3_3.Visible = false;
            //groupBox2.Enabled = true;
            //groupBox1.Enabled = true;
        }

        private void bill_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (bill_search.Rows.Count > 0)
                {
                    int index = bill_search.SelectedRows[0].Index;

                    int id = int.Parse(bill_search.Rows[index].Cells[0].Value.ToString());
                    ValidatingFunctions.contr_id_inside_profit = id;
                    fill_information(id);
                    try
                    {
                        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                        MySqlCommand cmd = con.CreateCommand();
                        con.Open();
                        cmd.CommandText = "SELECT SUM(pay_value) FROM profit WHERE  contr_id=@id;";
                        cmd.Parameters.AddWithValue("@id", id);

                        contr1.Text = cmd.ExecuteScalar().ToString();
                        con.Close();
                    }
                    catch (MySqlException ee)
                    {
                        MessageBox.Show("خطأ في السيرفر");
                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show("خطأ");
                    }

                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bill_search.Rows.Count > 0)
            {
                ValidatingFunctions.id_contribute = int.Parse(bill_search.SelectedRows[0].Cells[0].Value.ToString());
                AddWithdrawForm ad = new AddWithdrawForm();
                installs_info.DataSource = null;
                car_info.DataSource = null;
                ad.ShowDialog();
                bill_search.DataSource = null;
                Form3_Load(sender, e);
                int index = bill_search.SelectedRows[0].Index;

                int id = int.Parse(bill_search.Rows[index].Cells[0].Value.ToString());
                ValidatingFunctions.contr_id_inside_profit = id;
                fill_information(id);
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    MySqlCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "SELECT SUM(pay_value) FROM profit WHERE  contr_id=@id;";
                    cmd.Parameters.AddWithValue("@id", id);

                    contr1.Text = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
                catch (Exception eee) { MessageBox.Show("خطأ"); }
            }
            else { MessageBox.Show("برجاء تحديد مساهمة"); }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                string command;
                command = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration,contr.proft_num,contr.withdraw_num FROM contr;";
                cmd.CommandText = command;

                cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_contribute);
                MySqlDataAdapter rd = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                rd.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    bill_search.DataSource = dt;
                    bill_search.Columns[0].HeaderText = "رقم المساهمة";
                    bill_search.Columns[1].HeaderText = "الأسم";
                    bill_search.Columns[2].HeaderText = "الهاتف ";
                    bill_search.Columns[3].HeaderText = "مبلغ المساهمة";
                    bill_search.Columns[4].HeaderText = "تاريخ الدفع القادم";
                    bill_search.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                    bill_search.Columns[5].HeaderText = "تاريخ الانشاء";
                    bill_search.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
                    bill_search.Columns[6].HeaderText = "ملاحظات";
                    bill_search.Columns[7].HeaderText = "فترة الدفع";
                    bill_search.Columns[8].HeaderText = "عدد قسائم الارباح";
                    bill_search.Columns[9].HeaderText = "عدد المسحوبات";
                    button2.Enabled = true;
                    button3.Enabled = true;


                }
                else
                {
                    installs_info.DataSource = null;
                    car_info.DataSource = null;
                    MessageBox.Show("لا يوجد نتائج");
                }
                con.Close();
                installs_info.DataSource = null;
                car_info.DataSource = null;

            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee) { MessageBox.Show("خطأ"); }

        }

        private void bill_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int index = -1;
            try
            {
                index = installs_info.SelectedRows[0].Index;
            }
            catch (Exception eee)
            { }
            if (index > -1)
            {
                var confirmResult = MessageBox.Show("متابعة؟",
                                     "مسح الربح",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        int id_delete = int.Parse(installs_info.SelectedRows[0].Cells[1].Value.ToString());
                        DateTime date = (DateTime)installs_info.SelectedRows[0].Cells[3].Value;
                        int price = int.Parse(installs_info.SelectedRows[0].Cells[2].Value.ToString());
                        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT profit.id FROM profit WHERE profit.contr_id=@id AND profit.paying_date=@date AND profit.pay_value=@pay_value ORDER BY paying_date DESC; ";
                        cmd.Parameters.AddWithValue("@id", id_delete);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@pay_value", price);

                        object ii = cmd.ExecuteScalar();
                        int selected_install_id = int.Parse(ii.ToString());
                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandText = "DELETE FROM profit WHERE profit.id=@id1;";
                        cmd1.Parameters.AddWithValue("@id1", selected_install_id);
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandText = "UPDATE contr SET contr.proft_num=proft_num-1 WHERE contr.id=@id2;";
                        cmd2.Parameters.AddWithValue("@id2", id_delete);
                        cmd2.ExecuteNonQuery();

                        Form3_Load(sender, e);
                        car_info.DataSource = null;
                        installs_info.DataSource = null;



                        int index1 = bill_search.SelectedRows[0].Index;

                        int id = int.Parse(bill_search.Rows[index1].Cells[0].Value.ToString());
                        ValidatingFunctions.contr_id_inside_profit = id;
                        fill_information(id);


                        MySqlCommand cmd_push = con.CreateCommand();

                        cmd_push.CommandText = "SELECT SUM(pay_value) FROM profit WHERE  contr_id=@id;";
                        cmd_push.Parameters.AddWithValue("@id", id);

                        contr1.Text = cmd_push.ExecuteScalar().ToString();
                        con.Close();
                        MessageBox.Show("تم بنجاح");



                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("خطأ");

                    }

                }
                else { }

            }
            else { MessageBox.Show("برجاء تحديد ربح"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = -1;
            try
            { index = car_info.SelectedRows[0].Index; }
            catch (Exception eee)
            { }
            if (index > -1)
            {
                var confirmResult = MessageBox.Show("متابعة؟",
                                     "مسح العملية؟",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    try
                    {
                        if (car_info.SelectedRows[0].Cells[5].Value.ToString().Contains("س"))
                        {
                            //    MessageBox.Show("ss");
                            int id_delete = int.Parse(car_info.SelectedRows[0].Cells[1].Value.ToString());
                            DateTime date = (DateTime)car_info.SelectedRows[0].Cells[3].Value;
                            int price = int.Parse(car_info.SelectedRows[0].Cells[2].Value.ToString());
                            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT withdarws.id FROM withdarws WHERE withdarws.contr_id=@id AND withdarws.withdraw_date=@date AND withdarws.withdraw_value=@pay_value ORDER BY withdraw_date DESC; ";
                            cmd.Parameters.AddWithValue("@id", id_delete);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@pay_value", price);

                            string ii = cmd.ExecuteScalar().ToString();
                            // MessageBox.Show(ii);
                            int selected_install_id = int.Parse(ii);


                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandText = "DELETE FROM withdarws WHERE withdarws.id=@id1;";
                            cmd1.Parameters.AddWithValue("@id1", selected_install_id);
                            cmd1.ExecuteNonQuery();

                            MySqlCommand cmd_add = con.CreateCommand();
                            cmd_add.CommandText = "UPDATE contr SET contr.total_cash=total_cash+@price_add WHERE contr.id=@id_aa;";
                            cmd_add.Parameters.AddWithValue("@id_aa", id_delete);
                            cmd_add.Parameters.AddWithValue("@price_add", price);
                            cmd_add.ExecuteNonQuery();

                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandText = "UPDATE contr SET contr.withdraw_num=contr.withdraw_num-1 WHERE contr.id=@id2;";
                            cmd2.Parameters.AddWithValue("@id2", id_delete);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            Form3_Load(sender, e);
                            car_info.DataSource = null;
                            installs_info.DataSource = null;

                            int index1 = bill_search.SelectedRows[0].Index;

                            int id = int.Parse(bill_search.Rows[index1].Cells[0].Value.ToString());
                            ValidatingFunctions.contr_id_inside_profit = id;
                            Form3_Load(sender, e);
                            fill_information(id);
                            MessageBox.Show("تم بنجاح");
                        }
                        else
                        {


                            int id_delete = int.Parse(car_info.SelectedRows[0].Cells[1].Value.ToString());
                            DateTime date = (DateTime)car_info.SelectedRows[0].Cells[3].Value;
                            int price = int.Parse(car_info.SelectedRows[0].Cells[2].Value.ToString());
                            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT withdarws.id FROM withdarws WHERE withdarws.contr_id=@id AND withdarws.withdraw_date=@date AND withdarws.withdraw_value=@pay_value ORDER BY withdraw_date DESC; ";
                            cmd.Parameters.AddWithValue("@id", id_delete);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@pay_value", price);

                            string ii = cmd.ExecuteScalar().ToString();
                            // MessageBox.Show(ii);
                            int selected_install_id = int.Parse(ii);


                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandText = "DELETE FROM withdarws WHERE withdarws.id=@id1;";
                            cmd1.Parameters.AddWithValue("@id1", selected_install_id);
                            cmd1.ExecuteNonQuery();

                            MySqlCommand cmd_add = con.CreateCommand();
                            cmd_add.CommandText = "UPDATE contr SET contr.total_cash=total_cash-@price_add WHERE contr.id=@id_aa;";
                            cmd_add.Parameters.AddWithValue("@id_aa", id_delete);
                            cmd_add.Parameters.AddWithValue("@price_add", price);
                            cmd_add.ExecuteNonQuery();

                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandText = "UPDATE contr SET contr.withdraw_num=contr.withdraw_num-1 WHERE contr.id=@id2;";
                            cmd2.Parameters.AddWithValue("@id2", id_delete);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            Form3_Load(sender, e);
                            car_info.DataSource = null;
                            installs_info.DataSource = null;

                            int index1 = bill_search.SelectedRows[0].Index;

                            int id = int.Parse(bill_search.Rows[index1].Cells[0].Value.ToString());
                            ValidatingFunctions.contr_id_inside_profit = id;
                            fill_information(id);
                            MessageBox.Show("تم بنجاح");

                        }
                        Form3_Load(sender, e);
                        int index12 = bill_search.SelectedRows[0].Index;

                        int id22 = int.Parse(bill_search.Rows[index12].Cells[0].Value.ToString());
                        ValidatingFunctions.contr_id_inside_profit = id22;
                        fill_information(id22);
                    }


                    catch (Exception ee)
                    {
                        MessageBox.Show("خطأ");

                    }



                }


                else
                {

                }


            }
            else { MessageBox.Show("برجاء تحديد عملية"); }


        }

        private void delete_bill_Click(object sender, EventArgs e)
        {

            int index = -1;
            try
            {
                index = bill_search.SelectedRows[0].Index;
            }
            catch (Exception eee)
            { }
            if (index > -1)
            {
                var confirmResult = MessageBox.Show("متابعة؟",
                                     "مسح المساهمة المحددة",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int id_delete = int.Parse(bill_search.SelectedRows[0].Cells[0].Value.ToString());
                        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                        con.Open();

                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandText = "DELETE FROM withdarws WHERE withdarws.contr_id=@id1;";
                        cmd1.Parameters.AddWithValue("@id1", id_delete);
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandText = "DELETE FROM profit WHERE profit.contr_id=@id2;";
                        cmd2.Parameters.AddWithValue("@id2", id_delete);
                        cmd2.ExecuteNonQuery();
                        MySqlCommand cmd3 = con.CreateCommand();
                        cmd3.CommandText = "DELETE FROM contr WHERE contr.id=@id3;";
                        cmd3.Parameters.AddWithValue("@id3", id_delete);
                        cmd3.ExecuteNonQuery();

                        bill_search.DataSource = null;
                        installs_info.DataSource = null;
                        car_info.DataSource = null;

                        con.Close();



                        MessageBox.Show("تم المسح");

                    }
                    catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
                    catch (Exception eee) { MessageBox.Show("خطأ"); }

                }
                else { }

            }


        }

        private void date_search_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void car_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bill_search.DataSource = null;
            installs_info.DataSource = null;

            car_info.DataSource = null;
        }

        private void date_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
        }

        private void id_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
        }

        private void name_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
        }

        private void id_search_MouseClick(object sender, MouseEventArgs e)
        {
            id_search.Select(0, id_search.Text.Length);

        }
    }
}
