using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Forms
{
    public partial class PayInstallDialog : Form
    {
        int id1;
        int selected_install_id;
        int id_bill;
        private bool paid;
        public PayInstallDialog()
        {
            InitializeComponent();
            //install_search_data.MultiSelect = false;

        }



        public void View_install_by_id(int id, DateTime date)
        {
            try
            {
                id_bill = id;
                string command = "SELECT  bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.Total_price,installs.bill_id,installs.Stat,installs.Paying_date,installs.Notes,installs.Total_price,installs.To_pay_price,installs.bill_id FROM installs JOIN bills ON installs.bill_id=bills.id WHERE installs.bill_id=@id AND installs.Paying_date=@date;";
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = command;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);

                MySqlDataReader data = cmd.ExecuteReader();
                data.Read();
                pay_buyer_name.Text = data[0].ToString();
                pay_buyer_num.Text = data[1].ToString();
                pay_insurence_num.Text = data[2].ToString();
                pay_total_bill_price.Text = data[3].ToString();

                id1 = int.Parse(data[10].ToString());
                DateTime date1 = (DateTime)data[6];
                pay_date.Value = date1;
                pay_install_id.Text = data[4].ToString();
                pay_install_to_pay_price.Text = data[9].ToString();


                if (int.Parse(data[9].ToString()) == 0)
                {
                    pay_install_stat.Text = "مدفوع";
                    paid = true;
                }
                else
                {
                    pay_install_stat.Text = "غير مدفوع";
                    paid = false;
                }

                pay_install_notes.Text = data[7].ToString();

                numericUpDown2.Maximum = (int)data[9];

                pay_install_total_price.Text = data[8].ToString();
                data.Close();

                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "SELECT COUNT(installs.bill_id) FROM installs WHERE installs.bill_id=@id AND installs.To_pay_price>0 AND installs.Stat=0;";
                cmd2.Parameters.AddWithValue("@id", id1);
                string total_to_paid = cmd2.ExecuteScalar().ToString();
                pay_total_installs_remain.Text = int.Parse(total_to_paid).ToString();
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandText = "SELECT COUNT(installs.bill_id) FROM installs WHERE installs.bill_id=@id AND installs.To_pay_price=0 AND installs.Stat=1;";
                cmd3.Parameters.AddWithValue("@id", id1);

                string total_paid = cmd3.ExecuteScalar().ToString();
                bill_total_installs_paid.Text = int.Parse(total_paid).ToString();

                con.Close();

            }
            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            catch (Exception eee) { MessageBox.Show("خطأ"); }
        }







        private void Pay_Click_1(object sender, EventArgs e)
        {
            string error = "";
            if (numericUpDown2.Value >= 1 && numericUpDown2.Value <= int.Parse(pay_install_to_pay_price.Text) && paid == false)
            {
                try
                {
                    bool sub_install = false;
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    string command;
                    if (numericUpDown2.Value == int.Parse(pay_install_to_pay_price.Text))
                    {
                        command = "UPDATE installs SET installs.Stat=true , installs.Paid_price=installs.Total_price ,installs.To_pay_price=0,installs.Notes=@notes,installs.Paying_date=@date WHERE installs.id=@id;";
                        cmd.CommandText = command;
                        cmd.Parameters.AddWithValue("@notes", pay_install_notes.Text);
                        cmd.Parameters.AddWithValue("@id", selected_install_id);
                        cmd.Parameters.AddWithValue("@date", pay_date.Value);

                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandText = "UPDATE bills SET bills.paid_installs_number=bills.paid_installs_number+1,bills.notpaid_installs_number=bills.notpaid_installs_number-1 WHERE bills.id=@id;";
                        cmd2.Parameters.AddWithValue("@id", int.Parse(pay_install_id.Text));
                        cmd2.ExecuteNonQuery();
                        sub_install = true;
                    }
                    else
                    {
                        //////generate sub-installs data
                        command = "UPDATE installs SET installs.Stat=false , installs.Paid_price=installs.Paid_price+ @price ,installs.To_pay_price=installs.To_pay_price- @price,installs.Notes=@notes,installs.Paying_date=@date WHERE installs.id=@id;";
                        cmd.CommandText = command;
                        cmd.Parameters.AddWithValue("@id", selected_install_id);
                        cmd.Parameters.AddWithValue("@notes", pay_install_notes.Text);
                        cmd.Parameters.AddWithValue("@price", int.Parse(numericUpDown2.Value.ToString()));
                        cmd.Parameters.AddWithValue("@date", pay_date.Value);

                        sub_install = true;
                    }



                    int check = cmd.ExecuteNonQuery();
                    if (sub_install)
                    {
                        MySqlCommand sub_install_cmd = con.CreateCommand();
                        sub_install_cmd.CommandText = "INSERT INTO sub_installs(bill_id,install_id,price,date_paid) VALUES(@bill_id,@install_id,@price,@paydate1);";
                        sub_install_cmd.Parameters.AddWithValue("@bill_id", int.Parse(pay_install_id.Text));
                        sub_install_cmd.Parameters.AddWithValue("@install_id", selected_install_id);
                        sub_install_cmd.Parameters.AddWithValue("@paydate1", dateTimePicker1.Value);

                        sub_install_cmd.Parameters.AddWithValue("@price", int.Parse(numericUpDown2.Value.ToString()));
                        sub_install_cmd.ExecuteNonQuery();
                    }

                    con.Close();
                    if (check == 1)
                    {
                        this.clear_all_Click_1(sender, e);
                        MessageBox.Show("تم بنجاح");
                        //   ValidatingFunctions.id_from_payinstall_to_alerts = ;
                        clear_all_Click_1(sender, e);
                        this.Close();
                    }
                    else
                    {
                        error = "فشلت العملية برجاء المحاولة لاحقا";
                        MessageBox.Show(error);
                    }
                }
                catch (MySqlException ee)
                {
                    MessageBox.Show("خطأ في السيرفر");
                }
                catch (Exception eee) { MessageBox.Show("خطأ"); }
            }
            else
            {
                error = "خطـأ في المبلغ";
                MessageBox.Show(error);
            }

        }

        private void clear_all_Click_1(object sender, EventArgs e)
        {
            // ValidatingFunctions.id_from_payinstall_to_alerts = 0;


            // ValidatingFunctions.ResetAllControls(new List<Control>() { 
            // pay_buyer_name,
            //  pay_buyer_num,
            // pay_insurence_num,
            // pay_total_bill_price,
            // bill_total_installs_paid,
            // pay_total_installs_remain,
            // pay_install_date,
            // pay_install_id,
            // pay_install_stat,
            // pay_install_notes,
            // pay_install_to_pay_price,
            // pay_install_total_price
            //});

        }



        private void view_bills_Load(object sender, EventArgs e)
        {

            if (ValidatingFunctions.id_from_payinstall_to_alerts > 0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    MySqlCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "SELECT installs.id FROM installs WHERE installs.bill_id=@id AND installs.Paying_date=@date;";
                    cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_from_payinstall_to_alerts);
                    cmd.Parameters.AddWithValue("@date", ValidatingFunctions.date_from_payinstall_to_alerts);
                    object ii = cmd.ExecuteScalar();
                    selected_install_id = int.Parse(ii.ToString());
                    con.Close();
                    if (selected_install_id <= 0)
                    {
                        MessageBox.Show("خطأ");
                        this.Close();
                    }
                    else
                    {
                        View_install_by_id(ValidatingFunctions.id_from_payinstall_to_alerts, ValidatingFunctions.date_from_payinstall_to_alerts);
                        ValidatingFunctions.id_from_payinstall_to_alerts = 0;
                    }

                }
                catch (Exception ee)
                {

                    MessageBox.Show("خطأ");
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show(ValidatingFunctions.id_from_payinstall_to_alerts.ToString());

                //  MessageBox.Show("خطأ");
                this.Close();
            }
        }

        private void view_bill_Click(object sender, EventArgs e)
        {
            if (id1 > 0)
            {

                Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                ValidatingFunctions.id_from_payinstall_to_alerts = id_bill;
                form1.payinstall2.SELECTION_MODE = form1.payinstall2.MODE_SINGLE;
                form1.payinstall2.single_id = id_bill;
                form1.payinstall2.search_by_id(id_bill);
                form1.button6_Click(sender, e);

                //  form1.payinstall2.PayInstall_Load(sender, e);
                // form1.payinstall2.fill_information(id_bill);
                this.Close();

            }
            else
            {
                MessageBox.Show("خطأ");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_MouseClick(object sender, MouseEventArgs e)
        {
            numericUpDown2.Select(0, numericUpDown2.Text.Length);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool sub_install = false;
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                string command;


                command = "UPDATE installs SET installs.Notes=@notes,installs.Paying_date=@date WHERE installs.id=@id;";
                cmd.CommandText = command;
                cmd.Parameters.AddWithValue("@notes", pay_install_notes.Text);
                cmd.Parameters.AddWithValue("@id", selected_install_id);
                cmd.Parameters.AddWithValue("@date", pay_date.Value);



                int check = cmd.ExecuteNonQuery();


                con.Close();
                if (check == 1)
                {
                    this.clear_all_Click_1(sender, e);
                    MessageBox.Show("تم بنجاح");
                    ValidatingFunctions.id_from_payinstall_to_alerts = 0;
                    clear_all_Click_1(sender, e);
                    this.Close();
                }

            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee) { MessageBox.Show("خطأ"); }
        }
    }
}




/////search

//private void search_Click(object sender, EventArgs e)
//{
//    if (id_radio.Checked == true || name_radio.Checked == true || date_radio.Checked == true)
//    {
//        string error = "";
//        try
//        {
//            install_search_data.DataSource = null;
//            TextBox search_name;
//            NumericUpDown search_id;
//            DateTimePicker search_date;
//            List<RadioButton> arr_radio = new List<RadioButton>() { id_radio, name_radio, date_radio };
//            List<Control> arr_options = new List<Control>() { id_search, name_search, date_search };
//            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
//            con.Open();
//            MySqlCommand cmd = con.CreateCommand();
//            string command;
//            MySqlDataAdapter rd;
//            foreach (RadioButton i in arr_radio)
//            {
//                if (i.Checked == true)
//                {
//                    int index = arr_radio.IndexOf(i);
//                    if (index == 1)
//                    {
//                        search_name = (TextBox)arr_options.ElementAt<Control>(index);
//                        string name = name_search.Text;
//                        command = "SELECT installs.id_install,bills.Buyer_name,installs.Total_price,installs.Paying_date,installs.Stat ,bills.Inserunce_phone ,installs.Notes FROM installs JOIN bills ON installs.bill_id=bills.id WHERE bills.Buyer_name LIKE @name;";
//                        cmd.CommandText = command;
//                        cmd.Parameters.AddWithValue("@name", name);
//                    }
//                    else if (index == 0)
//                    {
//                        search_id = (NumericUpDown)arr_options.ElementAt<Control>(index);
//                        string id = search_id.Value.ToString();
//                        command = "SELECT installs.id_install,bills.Buyer_name,installs.Total_price,installs.Paying_date,installs.Stat, bills.Inserunce_phone ,installs.Notes FROM installs JOIN bills ON installs.bill_id=bills.id WHERE installs.id_install=@id;";
//                        cmd.CommandText = command;
//                        cmd.Parameters.AddWithValue("@id", id);
//                    }
//                    else
//                    {
//                        search_date = (DateTimePicker)arr_options.ElementAt<Control>(index);
//                        DateTime date = search_date.Value.Date;
//                        command = "SELECT installs.id_install,bills.Buyer_name,installs.Total_price,installs.Paying_date,installs.Stat ,bills.Inserunce_phone ,installs.Notes FROM installs JOIN bills ON installs.bill_id=bills.id WHERE installs.Paying_date=@date;";
//                        cmd.CommandText = command;
//                        cmd.Parameters.AddWithValue("@date", date);
//                    }

//                    break;
//                }
//            }
//            rd = new MySqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            rd.Fill(dt);
//            if (dt.Rows.Count > 0)
//            {

//                install_search_data.DataSource = dt;
//                install_search_data.Columns[0].HeaderText = "مسلسل القسط";
//                install_search_data.Columns[1].HeaderText = "أسم المشتري";
//                install_search_data.Columns[2].HeaderText = "المبلغ الكلي";
//                install_search_data.Columns[3].HeaderText = "تاريخ الدفع";
//                install_search_data.Columns[4].HeaderText = "مدفوع";
//                install_search_data.Columns[5].HeaderText = "هاتف الضامن";
//                install_search_data.Columns[6].HeaderText = "ملاحظات";
//                //for (int i = 0; i < install_search_data.Rows.Count; i++)
//                //{
//                //    if ((bool)install_search_data.Rows[i].Cells[4].Value == true)
//                //    { install_search_data.Rows[i].Cells[4].Value = "مدفوع"; }
//                //    else { install_search_data.Rows[i].Cells[4].Value = "غير مدفوع"; }
//                //}
//            }
//            else
//            { MessageBox.Show("لا يوجد نتائج"); }
//            con.Close();

//        }
//        catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
//        catch (Exception eee) { MessageBox.Show("خطأ"); }
//    }
//}

//private void id_radio_CheckedChanged(object sender, EventArgs e)
//{
//    if (id_radio.Checked == true)
//    {
//        id_search.Value = 0;
//        id_search.Visible = true;
//        date_search.Visible = false;
//        name_search.Visible = false;
//    }

//}

//private void name_radio_CheckedChanged(object sender, EventArgs e)
//{
//    if (name_radio.Checked == true)
//    {
//        name_search.Text = "";
//        id_search.Visible = false;
//        date_search.Visible = false;
//        name_search.Visible = true;
//    }

//}

//private void date_radio_CheckedChanged(object sender, EventArgs e)
//{
//    if (date_radio.Checked == true)
//    {
//        id_search.Visible = false;
//        date_search.Visible = true;
//        name_search.Visible = false;
//    }

//}

//  private void install_search_data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
//   {

//  }

//private void install_search_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
//{
//    if (e.RowIndex > -1)
//    {
//        if (install_search_data.Rows.Count > 0)
//        {
//            int index = install_search_data.SelectedRows[0].Index;

//                string id = install_search_data.Rows[index].Cells[0].Value.ToString();
//                View_install_by_id(id);

//        }
//    }
//}