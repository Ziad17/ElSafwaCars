using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.UserControls
{
    public partial class AccUI : UserControl
    {
        public AccUI()
        {
            InitializeComponent();
        }
        public void populate_stats()
        {
            MySqlConnection con = null;


            order1.Text = "";
            order2.Text = "";
            order3.Text = "";
            order4.Text = "";
            order5.Text = "";
            //order8.Text = "";
            order6.Text = "";
            order7.Text = "";
            //order8.Text = "";
            order9.Text = "";
            //order10.Text = "";



            try
            {
                con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(cars.Car_Number)FROM cars WHERE cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                order1.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(bills.id) FROM bills WHERE bills.To_pay_price>(SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id AND bills.going=true);";
                order2.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(bills.id) FROM bills WHERE bills.To_pay_price=(SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=bills.id AND bills.going=true);";
                order3.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(bills.id) FROM bills WHERE bills.going=false;";
                order4.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(installs.id) FROM installs JOIN bills ON installs.bill_id=bills.id WHERE installs.Paying_date=CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false AND bills.going=true;";
                order5.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(contr.id) FROM contr WHERE contr.stat=false;";
                order6.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(contr.id) FROM contr WHERE contr.stat=true;";
                order7.Text = cmd.ExecuteScalar().ToString();

            }

            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(contr.id) FROM contr;";
                total_contr.Text = cmd.ExecuteScalar().ToString();

            }

            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT SUM(contr.total_cash) FROM contr;";
                total_contr_sum.Text = cmd.ExecuteScalar().ToString();

            }

            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT SUM(bills.Total_price-bills.Paid_price) FROM bills WHERE bills.going=true;";
                int total = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT SUM(sub_installs.price) FROM sub_installs JOIN bills ON sub_installs.bill_id=bills.id WHERE bills.going=true;";
                int min = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT SUM(bills.Paid_price) FROM bills WHERE bills.going=true;";
                int min1 = int.Parse(cmd.ExecuteScalar().ToString());


                order9.Text = (total - min).ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }





            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AccUI_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void contr_name_TextChanged(object sender, EventArgs e)
        {

        }

        //private void first_pay_bill_ValueChanged(object sender, EventArgs e)
        //{
        //    to.MinDate = from.Value;
        //    to.Value = from.Value;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
        //        MySqlCommand cmd = con.CreateCommand();
        //        con.Open();
        //        cmd.CommandText = "SELECT SUM(price) FROM cars WHERE cars.registered=1 AND created_date>=@from AND created_date<=@to;";
        //       // MessageBox.Show(from.Value);
        //        cmd.Parameters.AddWithValue("@from", from.Value.Date);
        //        cmd.Parameters.AddWithValue("@to", to.Value.Date);
        //      //  MessageBox.Show( cmd.ExecuteScalar().ToString());
        //        car1.Text = cmd.ExecuteScalar().ToString();

        //        MySqlCommand cmd1 = con.CreateCommand();
        //        cmd1.CommandText = "SELECT SUM(Paid_price) FROM bills WHERE  created_date>=@from AND created_date<=@to";
        //        cmd1.Parameters.AddWithValue("@from", from.Value.Date);
        //        cmd1.Parameters.AddWithValue("@to", to.Value.Date);
        //        bill2.Text = cmd1.ExecuteScalar().ToString();

        //        MySqlCommand cmd2 = con.CreateCommand();
        //        cmd2.CommandText = "SELECT SUM(Paid_price) FROM installs WHERE  Paying_date>=@from AND Paying_date<=@to;";
        //        cmd2.Parameters.AddWithValue("@from", from.Value.Date);
        //        cmd2.Parameters.AddWithValue("@to", to.Value.Date);
        //        bill1.Text = cmd2.ExecuteScalar().ToString();


        //        MySqlCommand cmd3 = con.CreateCommand();
        //        cmd3.CommandText = "SELECT SUM(pay_value) FROM profit WHERE  Paying_date>=@from AND Paying_date<=@to;";
        //        cmd3.Parameters.AddWithValue("@from", from.Value.Date);
        //        cmd3.Parameters.AddWithValue("@to", to.Value.Date);
        //        contr1.Text = cmd3.ExecuteScalar().ToString();


        //        MySqlCommand cmd4 = con.CreateCommand();
        //        cmd4.CommandText = "SELECT SUM(total_cash) FROM contr WHERE  create_date>=@from AND create_date<=@to;";
        //        cmd4.Parameters.AddWithValue("@from", from.Value.Date);
        //        cmd4.Parameters.AddWithValue("@to", to.Value.Date);
        //        contr2.Text = cmd4.ExecuteScalar().ToString();


        //        MySqlCommand cmd5 = con.CreateCommand();
        //        cmd5.CommandText = "SELECT SUM(price) FROM finish_bills WHERE  date>=@from AND date<=@to;";
        //        cmd5.Parameters.AddWithValue("@from", from.Value.Date);
        //        cmd5.Parameters.AddWithValue("@to", to.Value.Date);
        //        textBox4.Text = cmd5.ExecuteScalar().ToString();







        //        con.Close();

        //    }
        //    catch (MySqlException ee) {

        //        MessageBox.Show("خطأ في السيرفر"); }
        //    catch (Exception eee) {
        //        MessageBox.Show("خطأ"); 
        //    }
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void to_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
