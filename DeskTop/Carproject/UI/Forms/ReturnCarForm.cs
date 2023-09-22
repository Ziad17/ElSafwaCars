using System;
using System.Linq;
using System.Windows.Forms;
using Carproject.UI.UserControls;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Forms
{
    public partial class ReturnCarForm : Form
    {
        private int id;
        private bool registered;
        private string car_num;
        public ReturnCarForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bill1_TextChanged(object sender, EventArgs e)
        {

        }

        private void carreturn_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand check_cmd = con.CreateCommand();
                check_cmd.CommandText = "SELECT cars.registered,cars.Car_Number FROM cars JOIN bills ON bills.car_number=cars.Car_Number WHERE bills.id=@id;";
                check_cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rd11 = check_cmd.ExecuteReader();
                rd11.Read();
                registered = (bool)rd11[0];
                car_num = rd11[1].ToString();

                rd11.Close();
                int i;
                int ii;

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT bills.id,bills.Buyer_name,bills.created_date,bills.Total_price,bills.Paid_price,bills.To_pay_price,bills.car_number FROM bills WHERE bills.id=@id;";
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader ed = cmd.ExecuteReader();
                ed.Read();
                id1.Text = ed[0].ToString();
                buyername_bill.Text = ed[1].ToString();
                created_date1.Text = ((DateTime)ed[2]).ToString("dd MMMM yyyy");
                total_price1.Text = ed[3].ToString();
                i = int.Parse(ed[3].ToString());
                ii = int.Parse(ed[4].ToString());
                //total_paid1.Text=ed[5].ToString();
                first.Text = ed[4].ToString();
                buyer_num_bill.Text = ed[6].ToString();
                ed.Close();
                cmd.CommandText = "SELECT SUM(installs.Paid_price) FROM installs WHERE installs.bill_id=@id1;";
                cmd.Parameters.AddWithValue("@id1", id);
                int paid = int.Parse(cmd.ExecuteScalar().ToString());
                paid_installs.Text = paid.ToString();
                total_paid1.Text = (i - paid - ii).ToString();
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
                this.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
                this.Close();
            }

        }
        public void get_id(int id1)
        {
            this.id = id1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (confirm_price.Value >= 0)
            {
                //if (registered == true)
                //{
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand retreive_car_info = con.CreateCommand();
                    retreive_car_info.CommandText = "SELECT cars.Car_Number,Car_model,Motor_number,Car_mark,Shaseh_number FROM cars WHERE cars.Car_Number=@car;";
                    retreive_car_info.Parameters.AddWithValue("@car", buyer_num_bill.Text);
                    MySqlDataReader rd = retreive_car_info.ExecuteReader();
                    rd.Read();

                    String info_car = rd[0].ToString();
                    String info_model = rd[1].ToString();
                    String info_motor = rd[2].ToString();
                    String info_mark = rd[3].ToString();
                    String info_shaseh = rd[4].ToString();
                    rd.Close();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE cars SET cars.Sold=false,cars.registered=true,cars.created_date=CURDATE() WHERE cars.Car_Number=@car_number;" +
                                    "UPDATE bills SET bills.going=false,bills.Car_Number=null WHERE bills.id=@bill_id;" +
                                    "INSERT INTO finish_bills(finish_bills.bill_id,finish_bills.date,finish_bills.price,finish_bills.car_number,finish_bills.car_model,finish_bills.car_motor,finish_bills.car_mark,finish_bills.shaseh_number) VALUES(@bill_id1,@date,@price,@car_number1,@car_model,@car_motor,@car_mark,@shaseh_number);";
                    cmd.Parameters.AddWithValue("@car_number", buyer_num_bill.Text);
                    cmd.Parameters.AddWithValue("@bill_id", int.Parse(id1.Text));
                    cmd.Parameters.AddWithValue("@bill_id1", int.Parse(id1.Text));
                    cmd.Parameters.AddWithValue("@date", return_date.Value);
                    cmd.Parameters.AddWithValue("@price", int.Parse(confirm_price.Value.ToString()));
                    cmd.Parameters.AddWithValue("@car_number1", info_car);
                    cmd.Parameters.AddWithValue("@car_model", info_model);
                    cmd.Parameters.AddWithValue("@car_motor", info_motor);
                    cmd.Parameters.AddWithValue("@car_mark", info_mark);
                    cmd.Parameters.AddWithValue("@shaseh_number", info_shaseh);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم بنجاح");
                    this.Close();
                    HomeScreenForm form1 = (HomeScreenForm)System.Windows.Forms.Application.OpenForms["Form1"];
                    View_Bills main = (View_Bills)form1.Controls.OfType<View_Bills>().ToList().ElementAt(0);
                    main.installs_info.DataSource = null;
                    main.car_info.DataSource = null;
                    main.sub_installs_info.DataSource = null;
                    main.bill_search.DataSource = null;



                }
                catch (MySqlException ee)
                {
                    MessageBox.Show("خطأ في السيرفر");
                }
                catch (Exception eee)
                {

                    MessageBox.Show("خطأ");
                }
                //}
                //else
                //{
                //    try
                //    {
                //        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                //        con.Open();
                //        MySqlCommand cmd = con.CreateCommand();
                //        cmd.CommandText = "UPDATE cars SET cars.Sold=false,cars.registered=false WHERE cars.Car_Number=@car_number;" +
                //                        "UPDATE bills SET bills.going=false WHERE bills.id=@bill_id;" +
                //                        "INSERT INTO finish_bills(finish_bills.bill_id,finish_bills.date,finish_bills.price) VALUES(@bill_id1,@date,@price);";
                //        cmd.Parameters.AddWithValue("@car_number", buyer_num_bill.Text);
                //        cmd.Parameters.AddWithValue("@bill_id", int.Parse(id1.Text));
                //        cmd.Parameters.AddWithValue("@bill_id1", int.Parse(id1.Text));
                //        cmd.Parameters.AddWithValue("@date", return_date.Value);
                //        cmd.Parameters.AddWithValue("@price", int.Parse(confirm_price.Value.ToString()));
                //        cmd.ExecuteNonQuery();
                //        MessageBox.Show("تم بنجاح");
                //        this.Close();
                //        Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                //        View_Bills main = (View_Bills)form1.Controls.OfType<View_Bills>().ToList().ElementAt(0);
                //        main.installs_info.DataSource = null;
                //        main.car_info.DataSource = null;
                //        main.sub_installs_info.DataSource = null;
                //        main.bill_search.DataSource = null;



                //    }
                //    catch (MySqlException ee)
                //    {
                //        // MessageBox.Show(ee.ToString());
                //        MessageBox.Show("خطأ في السيرفر");
                //    }
                //    catch (Exception eee)
                //    {
                //        // MessageBox.Show(eee.ToString());

                //        MessageBox.Show("خطأ");
                //    }
                //  }

            }
        }

        private void confirm_price_MouseClick(object sender, MouseEventArgs e)
        {
            confirm_price.Select(0, confirm_price.Text.Length);

        }
    }
}
