using System;
using System.Linq;
using System.Windows.Forms;
using Carproject.UI.UserControls;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Froms
{
    public partial class CarsEditDialog : Form
    {
        public CarsEditDialog()
        {

            InitializeComponent();
            try
            {
                paid_price1.Maximum = 1000000000;
                paid_price1.Minimum = 0;

                paid_price1.Maximum = 10000000;

                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT cars.Car_Number,cars.price,cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number,cars.created_date FROM cars WHERE cars.Car_Number=@number;";
                cmd.Parameters.AddWithValue("@number", ValidatingFunctions.car_num_to_start_car_edit);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                car_num1.Text = reader[0].ToString();

                try
                {
                    paid_price1.Value = int.Parse(reader[1].ToString());
                }
                catch (Exception ee)
                { }

                model_num1.Text = reader[2].ToString();
                motor_num1.Text = reader[3].ToString();
                mark_car1.Text = reader[4].ToString();
                shaseh_num1.Text = reader[5].ToString();
                from.Value = (DateTime)reader[6];

                con.Close();
                if (car_num1.Text.Equals("") || car_num1.Text.Equals(" "))
                { this.Close(); }

            }
            catch (MySqlException ee)
            {
                MessageBox.Show("لا يوجد سيارة بهذا الرقم");


            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");


            }
        }

        private void CarsEditDialog_Load(object sender, EventArgs e)
        {


        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE cars SET cars.Car_Number=@Car_Number,cars.location=@location,cars.Car_model=@Car_model,cars.Motor_number=@Motor_number,cars.Car_mark=@Car_mark,cars.Shaseh_number=@Shaseh_number,cars.price=@price,cars.created_date=@created_date WHERE cars.Car_Number=@old_number;";
                cmd.Parameters.AddWithValue("@Car_Number", car_num1.Text);
                cmd.Parameters.AddWithValue("@Car_model", model_num1.Text);
                cmd.Parameters.AddWithValue("@Motor_number", motor_num1.Text);
                cmd.Parameters.AddWithValue("@Car_mark", mark_car1.Text);
                cmd.Parameters.AddWithValue("@Shaseh_number", shaseh_num1.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(paid_price1.Value.ToString()));
                cmd.Parameters.AddWithValue("@old_number", ValidatingFunctions.car_num_to_start_car_edit);
                cmd.Parameters.AddWithValue("@created_date", from.Value);
                cmd.Parameters.AddWithValue("@location", textBox1.Text);




                int i = cmd.ExecuteNonQuery();

                con.Close();
                if (i == 1)
                {
                    MessageBox.Show("تم بنجاح");


                    ShowCars show = (ShowCars)System.Windows.Forms.Application.OpenForms["ShowCars"];

                    show.refresh_cars(show.sold, show.available);
                    this.Close();
                }
                else
                {

                    MessageBox.Show("خطأ");


                }
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
                ShowCars show = (ShowCars)System.Windows.Forms.Application.OpenForms["ShowCars"];

                show.refresh_cars(show.sold, show.available);
                this.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");

                ShowCars show = (ShowCars)System.Windows.Forms.Application.OpenForms["ShowCars"];

                show.refresh_cars(show.sold, show.available);
                this.Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM cars WHERE cars.Car_Number=@num;";
                cmd.Parameters.AddWithValue("@num", ValidatingFunctions.car_num_to_start_car_edit);
                cmd.ExecuteNonQuery();

                this.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ");

            }

            //ShowCars form1 = (ShowCars)System.Windows.Forms.Application.OpenForms["ShowCars"];
            //form1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
            BellUI main = (BellUI)form1.Controls.OfType<BellUI>().ToList().ElementAt(0);
            main.registr_radio.Checked = true;
            form1.button3_Click(sender, e);
            main.re_number.Text = car_num1.Text;
            ShowCars form11 = (ShowCars)System.Windows.Forms.Application.OpenForms["ShowCars"];
            form11.Close();
            this.Close();

        }

        private void paid_price1_MouseClick(object sender, MouseEventArgs e)
        {
            paid_price1.Select(0, paid_price1.Text.Length);

        }
    }
}
