using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Froms
{
    public partial class ShowCars : Form
    {
        public ShowCars()
        {
            InitializeComponent();

        }

        private void ShowCars_Load(object sender, EventArgs e)
        {
            refresh_cars(sold, available);
            refresh_cars_combo_avail(search_cb_available);
            refresh_cars_combo_sold(search_cb_sold);

        }

        public void refresh_cars_combo_avail(ComboBox combobox)
        {
            try
            {

                combobox.Items.Clear();
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT cars.Car_Number FROM cars WHERE cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                List<string> arr = new List<string>() { };

                MySqlDataReader rd = cmd1.ExecuteReader();

                while (rd.Read())
                {

                    combobox.Items.Add(rd.GetValue(0).ToString());

                }

                combobox.Refresh();
                con.Close();
            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");

            }

        }
        public void refresh_cars_combo_sold(ComboBox combobox)
        {
            try
            {

                combobox.Items.Clear();
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT cars.Car_Number FROM cars WHERE cars.registered=true AND cars.Sold=true AND LENGTH(cars.Car_Number) >=1;";
                List<string> arr = new List<string>() { };

                MySqlDataReader rd = cmd1.ExecuteReader();

                while (rd.Read())
                {

                    combobox.Items.Add(rd.GetValue(0).ToString());

                }

                combobox.Refresh();
                con.Close();
            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");

            }

        }

        public void refresh_cars(DataGridView sold_cars, DataGridView available_cars)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT cars.Car_Number,cars.price,cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number,cars.created_date,cars.location FROM cars WHERE cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                MySqlDataAdapter ad1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                available_cars.DataSource = dt1;
                available_cars.Columns[0].HeaderText = "رقم السيارة";
                available_cars.Columns[1].HeaderText = "سعر الشراء";
                available_cars.Columns[2].HeaderText = "موديل السيارة";
                available_cars.Columns[3].HeaderText = "رقم الموتور";
                available_cars.Columns[4].HeaderText = "ماركة السيارة";
                available_cars.Columns[5].HeaderText = "رقم الشاسيه";
                available_cars.Columns[6].HeaderText = "تاريخ الأضافة";
                available_cars.Columns[7].HeaderText = "مكان السيارة ";

                available_cars.Columns[6].DefaultCellStyle.Format = "yyyy/MM/dd";





                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "SELECT cars.Car_Number,cars.price,cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number FROM cars WHERE cars.registered=true AND cars.Sold=true AND LENGTH(cars.Car_Number) >=1;";
                MySqlDataAdapter ad2 = new MySqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                sold_cars.DataSource = dt2;
                sold_cars.Columns[0].HeaderText = "رقم السيارة";
                sold_cars.Columns[1].HeaderText = "سعر الشراء";
                sold_cars.Columns[2].HeaderText = "موديل السيارة";
                sold_cars.Columns[3].HeaderText = "رقم الموتور";
                sold_cars.Columns[4].HeaderText = "ماركة السيارة";
                sold_cars.Columns[5].HeaderText = "رقم الشاسيه";

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

        private void available_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (available.Rows.Count > 0)
                {
                    int index = available.SelectedRows[0].Index;

                    string Car_number = available.Rows[index].Cells[0].Value.ToString();
                    ValidatingFunctions.car_num_to_start_car_edit = Car_number;
                    CarsEditDialog c1 = new CarsEditDialog();
                    c1.ShowDialog();
                    refresh_cars(sold, available);



                }
            }
        }

        private void ggggg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ggg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void available_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sold_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = sold.SelectedRows[0].Index;
            String car_number = sold.Rows[index].Cells[0].Value.ToString();
            if (car_number != "" && car_number != null)
            {



                Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT bills.id FROM bills WHERE bills.car_number=@car_number;";
                cmd.Parameters.AddWithValue("@car_number", car_number);
                object ii = cmd.ExecuteScalar();
                int id = int.Parse(ii.ToString());
                con.Close();
                ValidatingFunctions.id_from_payinstall_to_alerts = id;
                form1.payinstall2.search_by_id(id);
                //  form1.payinstall2.fill_information(id);
                this.Close();
                form1.button6_Click(sender, e);

            }
            else
            {
                MessageBox.Show("خطأ");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Car_number = search_cb_available.Text.ToString();
            ValidatingFunctions.car_num_to_start_car_edit = Car_number;
            CarsEditDialog c1 = new CarsEditDialog();
            c1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string car_number = search_cb_sold.Text.ToString();

            if (car_number != "" && car_number != null)
            {



                Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT bills.id FROM bills WHERE bills.car_number=@car_number;";
                cmd.Parameters.AddWithValue("@car_number", car_number);
                object ii = cmd.ExecuteScalar();
                int id = int.Parse(ii.ToString());
                con.Close();
                ValidatingFunctions.id_from_payinstall_to_alerts = id;
                form1.payinstall2.search_by_id(id);
                this.Close();
                form1.button6_Click(sender, e);

            }
            else
            {
                MessageBox.Show("خطأ");
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            PrintForms.PrintCarsForm form = new PrintForms.PrintCarsForm();
            form.button3_Click(sender, e);
        }




    }
}
