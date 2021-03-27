using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carproject.PrintForms
{
    public partial class AllTrafficForm : Form
    {
        public AllTrafficForm()
        {
            InitializeComponent();
            refresh_cars(re_number);

        }

        public void refresh_cars(ComboBox combobox)
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


        private void populateInfo()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());

            con.Open();
            string CommandText1 = "SELECT * FROM selling_contract;";
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = CommandText1;



            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {


                checkIFExistsThenAdd(buyer_name_tx, rd.GetValue(1).ToString());
                checkIFExistsThenAdd(buyer_address_tx, rd.GetValue(3).ToString());
                checkIFExistsThenAdd(re_model, rd.GetValue(8).ToString());
                checkIFExistsThenAdd(re_mark, rd.GetValue(9).ToString());
                checkIFExistsThenAdd(re_shaseh, rd.GetValue(10).ToString());
                checkIFExistsThenAdd(re_motor, rd.GetValue(11).ToString());
                checkIFExistsThenAdd(re_color, rd.GetValue(13).ToString());



            }
            con.Close();

            buyer_name_tx.Refresh();
            buyer_address_tx.Refresh();
            buyer_name_tx.Refresh();
            re_model.Refresh();
            re_mark.Refresh();
            re_shaseh.Refresh();
            re_motor.Refresh();
            re_color.Refresh();






        }
        private void checkIFExistsThenAdd(ComboBox box, String item)
        {


            if (!box.Items.Contains(item))
            {
                box.Items.Add(item);
            }

        }

        private void re_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number FROM cars WHERE cars.Car_Number=@number AND cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                cmd1.Parameters.AddWithValue("@number", re_number.Items[re_number.SelectedIndex].ToString());
                //  MessageBox.Show(re_number.Items[re_number.SelectedIndex].ToString());
                MySqlDataReader rd = cmd1.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    re_model.Text = rd[0].ToString();
                    re_motor.Text = rd[1].ToString();
                    re_mark.Text = rd[2].ToString();
                    re_shaseh.Text = rd[3].ToString();
                    ;


                }
                else
                {
                    MessageBox.Show("خطأ");
                }
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

        private void restrict_button_Click(object sender, EventArgs e)
        {
            string buyer_name = buyer_name_tx.Text;
            string buyer_address = buyer_address_tx.Text;
            string car_number = re_number.Text;
            string car_motor = re_motor.Text;
            string car_mark = re_mark.Text;
            string car_model = re_model.Text;
            string car_shaseh = re_shaseh.Text;
            string car_color = re_color.Text;
            string date = String.Format("{0:yyyy/M/d}", date_tx.Value);
            if (!checkBox_date.Checked)
            { date = ""; }

            Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
            Font builtInFont = new Font("Times New Roman", 13, FontStyle.Bold);


            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            format.Trimming = StringTrimming.Word;


        }
    }
}
