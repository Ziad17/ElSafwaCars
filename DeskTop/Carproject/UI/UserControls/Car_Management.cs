using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Carproject.UI.Froms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.UserControls
{
    public partial class Car_Management : UserControl
    {
        public Car_Management()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!number.Text.StartsWith(" "))
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO cars(Car_model,Car_Number,Motor_number,Car_mark,Shaseh_number,registered,price,created_date,location) VALUES(@Car_model,@Car_Number,@Motor_number,@Car_mark,@Shaseh_number,@registered,@price,@created_date,@location);";
                    cmd.Parameters.AddWithValue("@created_date", from.Value);

                    cmd.Parameters.AddWithValue("@Car_model", model.Text);
                    cmd.Parameters.AddWithValue("@Car_Number", number.Text);
                    cmd.Parameters.AddWithValue("@Motor_number", motor.Text);
                    cmd.Parameters.AddWithValue("@Car_mark", mark.Text);
                    cmd.Parameters.AddWithValue("@Shaseh_number", shaseh.Text);
                    cmd.Parameters.AddWithValue("@registered", true);
                    cmd.Parameters.AddWithValue("@location", car_location.Text);
                    cmd.Parameters.AddWithValue("@price", int.Parse(price.Value.ToString()));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم بنجاح");
                    ValidatingFunctions.ResetAllControls(new List<Control>() { number, model, motor, mark, shaseh, price, car_location, notes });







                }

                catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
                catch (Exception eee) { MessageBox.Show("خطأ"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCars showcars = new ShowCars();
            //  showcars.Icon = Application.OpenForms["Form1"].Icon;
            showcars.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Car_Management_Load(object sender, EventArgs e)
        {

        }

        private void price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void model_TextChanged(object sender, EventArgs e)
        {

        }

        private void mark_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_MouseClick(object sender, MouseEventArgs e)
        {
            price.Select(0, price.Text.Length);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { model.Focus(); }
        }

        private void model_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { shaseh.Focus(); }
        }

        private void shaseh_TextChanged(object sender, EventArgs e)
        {

        }

        private void shaseh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { motor.Focus(); }
        }

        private void motor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { mark.Focus(); }
        }

        private void mark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { car_location.Focus(); }
        }

        private void car_location_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { price.Focus(); }

        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { notes.Focus(); }
        }

        private void notes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { from.Focus(); }
        }

        private void from_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button2.PerformClick(); }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
