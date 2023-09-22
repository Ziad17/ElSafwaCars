using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Carproject.Entities;
using Carproject.UI.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.UserControls
{
    public partial class ViewLawSuitsControl : UserControl
    {
        public int SELECTION_MODE;
        public int MODE_MULTI = 1;
        public int MODE_SINGLE = 2;
        public int multi_index;
        public int single_id;

        public ViewLawSuitsControl()
        {
            InitializeComponent();
            populate_names();

        }



        public void fill_information(int id)
        {
            //try
            //{
            //    installs_info.DataSource = null;
            //    installs_info.Rows.Clear();
            //    installs_info.Refresh();
            //    car_info.DataSource = null;
            //    car_info.Rows.Clear();
            //    car_info.Refresh();
            //    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            //    MySqlCommand cmd1 = con.CreateCommand();
            //    cmd1.CommandText = "SELECT installs.bill_id,installs.Total_price,installs.To_pay_price,installs.Stat,installs.Paying_date,installs.Notes FROM installs WHERE installs.bill_id=@id;";
            //    cmd1.Parameters.AddWithValue("@id", id);
            //    MySqlDataAdapter ab1 = new MySqlDataAdapter(cmd1);
            //    DataTable dt1 = new DataTable();

            //    ab1.Fill(dt1);

            //    DataColumn col = dt1.Columns.Add("الترتيب", typeof(int));
            //    col.SetOrdinal(0);

            //    installs_info.DataSource = dt1;
            //    for (int i = 0; i < dt1.Rows.Count; i++)
            //    { installs_info.Rows[i].Cells[0].Value = i + 1; }
            //    installs_info.Columns[1].HeaderText = "رقم الفاتورة";
            //    installs_info.Columns[2].HeaderText = "المبلغ";
            //    installs_info.Columns[3].HeaderText = "المستحق";
            //    installs_info.Columns[4].HeaderText = "مدفوع";
            //    installs_info.Columns[5].HeaderText = "تاريخ الدفع";
            //    installs_info.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
            //    installs_info.Columns[6].HeaderText = "ملاحظات";
            //    if (ValidatingFunctions.do_not_edit == true)
            //    {
            //        MySqlCommand cmd2 = con.CreateCommand();
            //        cmd2.CommandText = "SELECT cars.Car_Number,cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number FROM cars JOIN bills ON bills.car_number=cars.Car_Number WHERE bills.id=@id;";
            //        cmd2.Parameters.AddWithValue("@id", id);
            //        MySqlDataAdapter ab2 = new MySqlDataAdapter(cmd2);
            //        DataTable dt2 = new DataTable();
            //        ab2.Fill(dt2);
            //        car_info.DataSource = dt2;
            //        car_info.Columns[0].HeaderText = "رقم السيارة";
            //        car_info.Columns[1].HeaderText = "موديل السيارة";
            //        car_info.Columns[2].HeaderText = "رقم الموتور";
            //        car_info.Columns[3].HeaderText = "ماركة السيارة";
            //        car_info.Columns[4].HeaderText = "رقم الشاسيه";
            //    }
            //    else
            //    {///////////////////////////////////////////////////
            //        MySqlCommand cmd2 = con.CreateCommand();
            //        cmd2.CommandText = "SELECT finish_bills.car_number,finish_bills.car_model,finish_bills.car_motor,finish_bills.car_mark,finish_bills.shaseh_number,finish_bills.price,finish_bills.date FROM finish_bills WHERE finish_bills.bill_id=@id;";
            //        cmd2.Parameters.AddWithValue("@id", id);
            //        MySqlDataAdapter ab2 = new MySqlDataAdapter(cmd2);
            //        DataTable dt2 = new DataTable();
            //        ab2.Fill(dt2);
            //        car_info.DataSource = dt2;
            //        car_info.Columns[0].HeaderText = "رقم السيارة";
            //        car_info.Columns[1].HeaderText = "موديل السيارة";
            //        car_info.Columns[2].HeaderText = "رقم الموتور";
            //        car_info.Columns[3].HeaderText = "ماركة السيارة";
            //        car_info.Columns[4].HeaderText = "رقم الشاسيه";
            //        car_info.Columns[6].HeaderText = "تاريخ الارجاع";
            //        car_info.Columns[6].DefaultCellStyle.Format = "yyyy/MM/dd";

            //        car_info.Columns[5].HeaderText = " حق الاستخدام";

            //    }
            //    con.Close();
            //    foreach (DataGridViewRow row in installs_info.Rows)
            //    {
            //        if ((bool)row.Cells[4].Value)
            //        {
            //            row.DefaultCellStyle.BackColor = Color.Gray;
            //        }

            //    }

            //}
            //catch (MySqlException ee)
            //{
            //    MessageBox.Show("خطأ في السيرفر");
            //}
            //catch (Exception eee)
            //{
            //    MessageBox.Show("خطأ");
            //}
        }


        public void PayInstall_Load(object sender, EventArgs e)
        {
            try
            {
                if (SELECTION_MODE == MODE_MULTI)
                {
                    //  MessageBox.Show("ddd");

                    SearchAll_Click(sender, e);
                    lawSuitsGrid.Rows[multi_index].Selected = true;
                }
                else if (SELECTION_MODE == MODE_SINGLE)
                {
                    // MessageBox.Show("ddd");

                    search_by_id(single_id);
                    lawSuitsGrid.Rows[0].Selected = true;

                }
            }
            catch (Exception eeee)
            {

            }

        }

        public void populate_names()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            string name = name_search.Text;
            string command = "SELECT bills.Buyer_name FROM bills;";


            cmd.CommandText = command;


            MySqlDataAdapter rd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            foreach (DataRow datarow in dt.Rows)
            {
                name_search.Items.Add(datarow["Buyer_name"].ToString());
            }


            con.Close();
            name_search.SelectionStart = name_search.Text.Length;
        }

        public void search_by_id(int id_to_go)
        {
            //string error = "";
            //try
            //{


            //    installs_info.DataSource = null;
            //    car_info.DataSource = null;
            //    sub_installs_info.DataSource = null;
            //    bill_search.DataSource = null;

            //    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            //    con.Open();
            //    MySqlCommand cmd = con.CreateCommand();
            //    string command;
            //    MySqlDataAdapter rd;


            //    command = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.created_date,bills.Total_price,bills.Paid_price,(SELECT SUM(installs.Total_price-installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date<=CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false ) AS 'topay',(SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id) as 'paid',(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date>CURRENT_DATE()),bills.going,(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id ),bills.Notes  FROM bills WHERE bills.id=@id;";

            //    cmd.CommandText = command;
            //    cmd.Parameters.AddWithValue("@id", id_to_go);



            //    rd = new MySqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    rd.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        bill_search.DataSource = dt;
            //        bill_search.Columns[0].HeaderText = "رقم الفاتورة";
            //        bill_search.Columns[1].HeaderText = "أسم المشتري";
            //        bill_search.Columns[2].HeaderText = "هاتف المشتري";
            //        bill_search.Columns[3].HeaderText = "هاتف الضامن";
            //        bill_search.Columns[4].HeaderText = "تاريخ الانشاء";
            //        bill_search.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
            //        bill_search.Columns[5].HeaderText = "الاجمالي";

            //        bill_search.Columns[6].HeaderText = "المقدم";

            //        bill_search.Columns[7].HeaderText = " مستحق";
            //        bill_search.Columns[8].HeaderText = " مدفوع";
            //        bill_search.Columns[9].HeaderText = " متبقي";
            //        bill_search.Columns[10].HeaderText = "جارية";
            //        bill_search.Columns[11].HeaderText = "إجمالي المتبقي";
            //        bill_search.Columns[11].Width += 10;

            //        bill_search.Columns[12].HeaderText = "ملاحظات";

            //        fill_information(id_to_go);




            //    }
            //    else
            //    { MessageBox.Show("لا يوجد نتائج"); }
            //    con.Close();

            //}
            //catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            //catch (Exception eee) { MessageBox.Show("خطأ"); }

        }

        private void SearchClick(object sender, EventArgs e)
        {
            //if (id_radio.Checked || name_radio.Checked || date_radio.Checked)
            //{
            //    string error = "";
            //    try
            //    {
            //        installs_info.DataSource = null;
            //        car_info.DataSource = null;
            //        sub_installs_info.DataSource = null;
            //        bill_search.DataSource = null;
            //        ComboBox search_name;
            //        NumericUpDown search_id;
            //        DateTimePicker search_date;
            //        List<RadioButton> arr_radio = new List<RadioButton>() { id_radio, name_radio, date_radio };
            //        List<Control> arr_options = new List<Control>() { id_search, name_search, date_search };
            //        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            //        con.Open();
            //        MySqlCommand cmd = con.CreateCommand();
            //        string command;
            //        MySqlDataAdapter rd;
            //        foreach (RadioButton i in arr_radio)
            //        {
            //            if (i.Checked == true)
            //            {
            //                int index = arr_radio.IndexOf(i);
            //                if (index == 1)
            //                {
            //                    search_name = (ComboBox)arr_options.ElementAt<Control>(index);
            //                    string name = name_search.Text;
            //                    command = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.created_date,bills.Total_price,bills.Paid_price,(SELECT SUM(installs.Total_price-installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date<=CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false ) AS 'topay',(SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id) as 'paid',(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date>CURRENT_DATE()),bills.going,(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id ),bills.Notes  FROM bills WHERE bills.Buyer_name Like @name;";


            //                    cmd.CommandText = command;
            //                    cmd.Parameters.AddWithValue("@name", name + "%");
            //                }
            //                else if (index == 0)
            //                {
            //                    search_id = (NumericUpDown)arr_options.ElementAt<Control>(index);
            //                    string id = search_id.Value.ToString();
            //                    command = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.created_date,bills.Total_price,bills.Paid_price,(SELECT SUM(installs.Total_price-installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date<=CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false ) AS 'topay',(SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id) as 'paid',(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date>CURRENT_DATE()),bills.going,(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id ),bills.Notes  FROM bills WHERE bills.id=@id;";

            //                    cmd.CommandText = command;
            //                    cmd.Parameters.AddWithValue("@id", id);
            //                }
            //                else
            //                {
            //                    search_date = (DateTimePicker)arr_options.ElementAt<Control>(index);
            //                    DateTime date = search_date.Value.Date;
            //                    command = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.created_date,bills.Total_price,bills.Paid_price,(SELECT SUM(installs.Total_price-installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date<=CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false ) AS 'topay',(SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id) as 'paid',(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id AND installs.Paying_date>CURRENT_DATE()),bills.going,(SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.bill_id=bills.id ),bills.Notes  FROM bills WHERE bills.created_date=@date;";

            //                    cmd.CommandText = command;
            //                    cmd.Parameters.AddWithValue("@date", date);
            //                }

            //                break;
            //            }
            //        }
            //        rd = new MySqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        rd.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            bill_search.DataSource = dt;
            //            bill_search.Columns[0].HeaderText = "رقم الفاتورة";
            //            bill_search.Columns[1].HeaderText = "أسم المشتري";
            //            bill_search.Columns[2].HeaderText = "هاتف المشتري";
            //            bill_search.Columns[3].HeaderText = "هاتف الضامن";
            //            bill_search.Columns[4].HeaderText = "تاريخ الانشاء";
            //            bill_search.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
            //            bill_search.Columns[5].HeaderText = "الاجمالي";

            //            bill_search.Columns[6].HeaderText = "المقدم";

            //            bill_search.Columns[7].HeaderText = " مستحق";
            //            bill_search.Columns[8].HeaderText = " مدفوع";
            //            bill_search.Columns[9].HeaderText = " متبقي";
            //            bill_search.Columns[10].HeaderText = "جارية";
            //            bill_search.Columns[11].HeaderText = "إجمالي المتبقي";

            //            bill_search.Columns[12].HeaderText = "ملاحظات";
            //            bill_search.Columns[11].Width += 10;




            //        }
            //        else
            //        { MessageBox.Show("لا يوجد نتائج"); }
            //        con.Close();

            //    }
            //    catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            //    catch (Exception eee) { MessageBox.Show("خطأ"); }
            //}

        }

        private void date_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            if (date_radio.Checked == true)
            {
                id_search.Visible = false;
                date_search.Visible = true;
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

        private void bill_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (lawSuitsGrid.Rows.Count > 0)
                {

                    int index = lawSuitsGrid.SelectedRows[0].Index;


                    ValidatingFunctions.do_not_edit = (bool)lawSuitsGrid.Rows[index].Cells[10].Value;

                    int id = int.Parse(lawSuitsGrid.Rows[index].Cells[0].Value.ToString());
                    fill_information(id);

                }
            }
        }

        public void get_ins_info()
        {
            //try
            //{
            //    sub_installs_info.DataSource = null;
            //    sub_installs_info.Refresh();
            //    int id = int.Parse(installs_info.SelectedRows[0].Cells[1].Value.ToString());
            //    DateTime date = (DateTime)installs_info.SelectedRows[0].Cells[5].Value;
            //    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            //    con.Open();
            //    MySqlCommand cmd = con.CreateCommand();
            //    cmd.CommandText = "SELECT installs.id FROM installs WHERE installs.bill_id=@id AND installs.Paying_date=@date;";
            //    cmd.Parameters.AddWithValue("@id", id);
            //    cmd.Parameters.AddWithValue("@date", date);
            //    object ii = cmd.ExecuteScalar();
            //    int selected_install_id = int.Parse(ii.ToString());

            //    MySqlCommand cmd1 = con.CreateCommand();
            //    cmd1.CommandText = "SELECT sub_installs.bill_id,sub_installs.price,sub_installs.date_paid FROM sub_installs WHERE sub_installs.bill_id=@id AND sub_installs.install_id=@install_id;";
            //    cmd1.Parameters.AddWithValue("@id", id);
            //    cmd1.Parameters.AddWithValue("@install_id", selected_install_id);

            //    MySqlDataAdapter ab1 = new MySqlDataAdapter(cmd1);
            //    DataTable dt1 = new DataTable();

            //    ab1.Fill(dt1);

            //    DataColumn col = dt1.Columns.Add("الترتيب", typeof(int));
            //    col.SetOrdinal(0);

            //    sub_installs_info.DataSource = dt1;
            //    for (int i = 0; i < dt1.Rows.Count; i++)
            //    { sub_installs_info.Rows[i].Cells[0].Value = i + 1; }
            //    sub_installs_info.Columns[1].HeaderText = "رقم الفاتورة";
            //    sub_installs_info.Columns[2].HeaderText = "المبلغ";
            //    sub_installs_info.Columns[3].HeaderText = "تاريخ الدفع";
            //    sub_installs_info.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";



            //    con.Close();

            //}
            //catch (MySqlException ee)
            //{
            //    MessageBox.Show("خطأ في السيرفر");
            //}
            //catch (Exception eee)
            //{
            //    MessageBox.Show("خطأ");
            //}
        }


        private void installs_info_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = bill_search.SelectedRows[0].Index;


            //ValidatingFunctions.do_not_edit = (bool)bill_search.Rows[index].Cells[10].Value;
            //if (ValidatingFunctions.do_not_edit == true)
            //{
            //    if (e.RowIndex > -1)
            //    {
            //        if (installs_info.Rows.Count > 0)
            //        {
            //            ValidatingFunctions.id_from_payinstall_to_alerts = int.Parse(installs_info.SelectedRows[0].Cells[1].Value.ToString());
            //            ValidatingFunctions.date_from_payinstall_to_alerts = (DateTime)installs_info.SelectedRows[0].Cells[5].Value;
            //            PayInstallmentForm dg = new PayInstallmentForm();
            //            dg.ShowDialog();
            //            ValidatingFunctions.id_from_payinstall_to_alerts = int.Parse(installs_info.SelectedRows[0].Cells[1].Value.ToString());
            //            fill_information(int.Parse(installs_info.SelectedRows[0].Cells[1].Value.ToString()));
            //            get_ins_info();

            //        }
            //    }
            //}
            //else { MessageBox.Show("لا يمكن تعديل فاتورة منتهية"); }





        }





        private void button3_Click(object sender, EventArgs e)
        {
            lawSuitsGrid.DataSource = null;
        }

        private void lawSuitsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index1 = lawSuitsGrid.SelectedRows[0].Index;


            ValidatingFunctions.do_not_edit = (bool)lawSuitsGrid.Rows[index1].Cells[10].Value;
            if (ValidatingFunctions.do_not_edit == true)
            {
                if (e.RowIndex > -1)
                {
                    if (lawSuitsGrid.Rows.Count == 1)
                    {
                        ValidatingFunctions.id_to_edit_bill_details = int.Parse(lawSuitsGrid.SelectedRows[0].Cells[0].Value.ToString());
                        ValidatingFunctions.id_from_payinstall_to_alerts = int.Parse(lawSuitsGrid.SelectedRows[0].Cells[0].Value.ToString());
                        EditBillInformationForm dg = new EditBillInformationForm();
                        SELECTION_MODE = MODE_SINGLE;
                        single_id = int.Parse(lawSuitsGrid.Rows[0].Cells[0].Value.ToString());

                        dg.ShowDialog();

                        PayInstall_Load(sender, e);

                    }
                    else if (lawSuitsGrid.Rows.Count > 1)

                    {
                        ValidatingFunctions.id_to_edit_bill_details = int.Parse(lawSuitsGrid.SelectedRows[0].Cells[0].Value.ToString());
                        ValidatingFunctions.id_from_payinstall_to_alerts = int.Parse(lawSuitsGrid.SelectedRows[0].Cells[0].Value.ToString());
                        EditBillInformationForm dg = new EditBillInformationForm();
                        SELECTION_MODE = MODE_MULTI;
                        multi_index = lawSuitsGrid.SelectedRows[0].Index;
                        dg.ShowDialog();

                        PayInstall_Load(sender, e);


                    }
                }
            }
            else { MessageBox.Show("لا يمكن تعديل فاتورة منتهية"); }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SearchAll_Click(object sender, EventArgs e)
        {
            using var context = new ElbashacarsContext();

            SELECTION_MODE = MODE_MULTI;
            try
            {

                var lawSuits = context.LawSuits.Include(c => c.Bill).OrderByDescending(c => c.CreationDate)
                    .Select(c => new
                    {
                        c.BillId,
                        c.Bill.BuyerName,
                        c.CaseNumber,
                        c.InventoryNumber,
                        c.Judgement,
                        c.LawyerName,
                        c.CaseCreator,
                    }).ToList();

                if (lawSuits.Count > 0)
                {
                    lawSuitsGrid.DataSource = lawSuits;
                    lawSuitsGrid.Columns[0].HeaderText = "رقم الفاتورة";
                    lawSuitsGrid.Columns[1].HeaderText = "الإسم";
                    lawSuitsGrid.Columns[2].HeaderText = "رقم القضية";
                    lawSuitsGrid.Columns[3].HeaderText = "رقم الحصر";
                    lawSuitsGrid.Columns[4].HeaderText = "الحكم";
                    lawSuitsGrid.Columns[5].HeaderText = "المحامي";
                    lawSuitsGrid.Columns[6].HeaderText = " الشاكي";
                }
                else
                {
                    MessageBox.Show("لا يوجد نتائج");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void bill_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
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

        private void id_search_MouseClick(object sender, MouseEventArgs e)
        {
            id_search.Select(0, id_search.Text.Length);

        }

        private void name_search_TextChanged(object sender, EventArgs e)
        {


        }

        private void name_search_SelectedIndexChanged(object sender, EventArgs e)
        {

            name_search.Text = (string)name_search.Items[name_search.SelectedIndex];

        }

    }

}