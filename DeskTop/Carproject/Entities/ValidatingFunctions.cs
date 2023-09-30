using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject
{
    class ValidatingFunctions
    {
        public static bool is_car_registerd;
        public static bool do_not_edit;
        public static bool edit_installs_sign;
        public static int contr_id_to_add_profit;
        public static int id_to_edit_bill_details;
        private static string INSTALL_ID;
        private static int REMAINING_INSTALLMENTS = 0;
        private static bool LOGIN_TOKEN = false;
        private static string CONNECTION_STRINGS = "Server=127.0.0.1;port=3306;username=root;password=mysqlpw;database=elbashacars;SslMode=none;";
        //for unorganized installments.cs
        public static int id_contribute;
        public static int id_from_payinstall_to_alerts;
        public static DateTime date_from_payinstall_to_alerts;
        private static DataTable pinned_notification_reader;
        private static DataTable today_notification_reader;
        private static DataTable pinned_contr_reader;
        private static DataTable today_contr_reader;
        public static int contr_id_inside_profit;
        public static string car_num_to_start_car_edit;

        public static bool update_bills_notifications()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(CONNECTION_STRINGS);

                con.Open();
                string CommandText1 = "SELECT bills.id, bills.Buyer_name,installs.Total_price,installs.To_pay_price,installs.Paying_date,bills.Buyer_phone,bills.Inserunce_phone,installs.Notes FROM installs JOIN bills ON installs.bill_id=bills.id WHERE installs.Paying_date=CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false AND bills.going=true;";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = CommandText1;
                MySqlDataAdapter today_notification_reader1 = new MySqlDataAdapter(cmd);
                today_notification_reader = new DataTable();
                today_notification_reader1.Fill(today_notification_reader);
                string CommandText2 = "SELECT bills.id,bills.Buyer_name,SUM(installs.To_pay_price),COUNT(installs.id),MIN(installs.Paying_date),bills.Buyer_phone,bills.Notes  FROM installs INNER JOIN bills ON installs.bill_id=bills.id WHERE  installs.Paying_date<CURRENT_DATE() AND installs.To_pay_price!=0 AND installs.Stat=false AND   bills.going=true GROUP BY bills.id  ;";
                MySqlCommand cmd2 = new MySqlCommand(CommandText2, con);
                MySqlDataAdapter pinned_notification_reader1 = new MySqlDataAdapter(cmd2);
                pinned_notification_reader = new DataTable();
                pinned_notification_reader1.Fill(pinned_notification_reader);

                con.Close();
                return true;
            }

            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
                return false;
            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
                return false;
            }
        }
        public static bool update_contr_notification()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(CONNECTION_STRINGS);

                con.Open();
                string CommandText1 = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration FROM contr WHERE contr.next_pay_date= CURDATE() AND contr.stat=false AND contr.total_cash>0;";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = CommandText1;
                MySqlDataAdapter today_contr_reader1 = new MySqlDataAdapter(cmd);
                today_contr_reader = new DataTable();
                today_contr_reader1.Fill(today_contr_reader);
                string CommandText2 = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration FROM contr WHERE contr.next_pay_date< CURDATE() AND contr.stat=false AND contr.total_cash>0;";
                MySqlCommand cmd2 = new MySqlCommand(CommandText2, con);
                MySqlDataAdapter pinned_contr_reader1 = new MySqlDataAdapter(cmd2);
                pinned_contr_reader = new DataTable();
                pinned_contr_reader1.Fill(pinned_contr_reader);

                con.Close();
                return true;

            }
            catch
            {
                today_contr_reader = null;
                pinned_contr_reader = null;
                MessageBox.Show("خطأ");
                return false;
            }
        }


        public static string getDotsIfNumberEqualZero(string number, int numberOfDots)
        {
            // number = number.Trim();
            if (int.Parse(number) > 0)
            {
                return number.ToString();
            }
            else { return string.Concat(Enumerable.Repeat(".", numberOfDots)); }
        }
        public static string getDotsIfTextEmpty(string text, int numberOfDots)
        {
            text = text.Trim();
            if (text != null && !text.Equals(""))
            {
                return text;
            }
            else { return string.Concat(Enumerable.Repeat(".", numberOfDots)); }
        }

        public static DataTable get_today_contr()
        {
            return today_contr_reader;

        }

        public static DataTable get_pinned_contr()
        {
            return pinned_contr_reader;

        }

        public static DataTable get_today_alerts()
        {
            return today_notification_reader;
        }


        public static DataTable get_pinned_alerts()
        {
            return pinned_notification_reader;
        }


        public static string getCONNECTION_STRINGS() => CONNECTION_STRINGS;


        public static void setLOGIN_TOKEN(bool token)
        { LOGIN_TOKEN = token; }
        public static bool getLOGIN_TOKEN()
        { return LOGIN_TOKEN; }



        public static void set_INSTALL_ID(string element)
        { INSTALL_ID = element; }
        public static string get_INSTALL_ID()
        { return INSTALL_ID; }


        public static void setREMAINING_INSTALLMENTS(int num)
        { REMAINING_INSTALLMENTS = num; }
        public static int getREMAINING_INSTALLMENTS()
        { return REMAINING_INSTALLMENTS; }




        public static TextBox validate_textboxes(List<TextBox> arr)
        {
            TextBox current = null;
            bool check = false;
            foreach (TextBox i in arr)
            {
                if (i.Text.Equals(""))
                {
                    current = i;
                    check = true;
                    break;
                }
            }
            if (current != null)
            { return current; }
            else { return null; }

        }

        public static void ResetAllControls(List<Control> arr)
        {
            foreach (Control control in arr)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                if (control is DataGridView)
                {
                    DataGridView box = (DataGridView)control;
                    box.DataSource = null;
                }
                if (control is NumericUpDown)
                {
                    NumericUpDown box = (NumericUpDown)control;
                    box.Value = 0;

                }
                if (control is DateTimePicker)
                {
                    DateTimePicker box = (DateTimePicker)control;
                    box.Value = DateTime.Today;
                }
            }


        }
        public static void signin_signout(List<Control> arr, bool stat)
        {
            foreach (Control i in arr)
            { i.Enabled = stat; }
        }

        public static string invertString(string text)
        {
            // char[] charArray = text.ToCharArray();
            //   Array.Reverse(charArray);
            //return new string(charArray);
            return text;
        }
        public static string getEmptyDate()
        {
            return "   /   /   20";
        }
    }
}
