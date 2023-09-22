using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Carproject.UI.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.UserControls
{
    public partial class BellUI : UserControl
    {
        private bool car_setup;
        public BellUI()
        {
            InitializeComponent();
            // testing();
            unregistr_radio.Checked = true;
            registr_radio.Checked = false;
            refresh_cars(re_number);
            car_setup = false;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";

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

        private void testing()
        {
            buyername_bill.Text = "خالد";
            buyer_num_bill.Text = "01111111111111";
            car_num_bill.Text = "س ج د 5462";
            insure_num_bill.Text = "01277777777";
            model_num_bill.Text = "2019";
            motor_num_bill.Text = "4989";
            shaseh_num_bill.Text = "1521694";
            restrict_sell_bill.Text = "لا احد";
            notes_bill.Text = "ملاحظة";
            mark_car_bill.Text = "تويوتا";
            total_price_bill.Value = 50000;
            paid_price_bill.Value = 10000;
            rest_price_bill.Text = "40000";

        }


        private void clear_all_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            car_setup = false;
            register.Enabled = true;
            unregister.Enabled = true;
            groupBox1.Enabled = true;
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel2.Enabled = true;
            validate_button.Enabled = true;
            adding_installments.Enabled = false;
            add_new_bill_button.Enabled = false;
            ValidatingFunctions.ResetAllControls(new List<Control>(){buyername_bill,
                buyer_num_bill,
                car_num_bill,
                insure_num_bill,
                motor_num_bill,
                model_num_bill,
                shaseh_num_bill,
                restrict_sell_bill,
                notes_bill,
                dataGridView1,
            total_price_bill,
            rest_price_bill,
            paid_price_bill,
            mark_car_bill,
            first_pay_bill,
            id_num,
            re_motor,
            re_model,
            re_mark,
            re_shaseh
            });
            re_number.Text = "";
            errorProvider1.Dispose();

        }

        private void validate_button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con1 = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con1.Open();
                MySqlCommand cd = con1.CreateCommand();
                cd.CommandText = "SELECT bills.id FROM bills WHERE bills.id=@idd";
                cd.Parameters.AddWithValue("@idd", int.Parse(id_num.Value.ToString()));
                int o = int.Parse(cd.ExecuteScalar().ToString());
                con1.Close();
                if (int.Parse(id_num.Value.ToString()) == o)
                {
                    MessageBox.Show("رقم فاتورة مكرر");
                    return;

                }
            }
            catch (Exception ee) { }
            if (id_num.Value < 1)
            {
                MessageBox.Show("رقم فاتورة خاطئ");
                return;
            }
            TextBox emptyTextBox = null;
            emptyTextBox = ValidatingFunctions.validate_textboxes(new List<TextBox>(){buyername_bill,
                buyer_num_bill,
                    insure_num_bill,
                restrict_sell_bill});
            if (emptyTextBox != null)
            {
                errorProvider1.SetError(emptyTextBox, "empty");
                return;
            }
            if (registr_radio.Checked == true)
            {
                if (car_setup == false)
                {
                    MessageBox.Show("سيارة غير مسجلة");
                    return;
                }
                else
                {
                    if (!rest_price_bill.Text.Equals("") && int.Parse(total_price_bill.Value.ToString()) == int.Parse(paid_price_bill.Value.ToString()) + int.Parse(rest_price_bill.Text.ToString()))
                    {
                        //////right validation
                        validate_button.Enabled = false;
                        adding_installments.Enabled = true;
                        tableLayoutPanel1.Enabled = false;
                        tableLayoutPanel2.Enabled = false;
                        unregister.Enabled = false;
                        register.Enabled = false;
                    }
                    else
                    { MessageBox.Show("مبلغ مالي خاطئ"); }
                }
            }
            if (unregistr_radio.Checked == true)
            {
                TextBox empty = null;
                empty = ValidatingFunctions.validate_textboxes(new List<TextBox>() { car_num_bill, shaseh_num_bill, motor_num_bill, model_num_bill, car_num_bill, mark_car_bill });
                if (empty != null)
                {
                    errorProvider1.SetError(empty, "empty");
                    return;
                }
                else
                {

                    if (!rest_price_bill.Text.Equals("") && int.Parse(total_price_bill.Value.ToString()) == int.Parse(paid_price_bill.Value.ToString()) + int.Parse(rest_price_bill.Text.ToString()))
                    {
                        //////right validation
                        validate_button.Enabled = false;
                        adding_installments.Enabled = true;
                        tableLayoutPanel1.Enabled = false;
                        tableLayoutPanel2.Enabled = false;
                        groupBox1.Enabled = false;
                        register.Enabled = false;
                        unregister.Enabled = false;
                    }
                    else
                    { MessageBox.Show("مبلغ مالي خاطئ"); }
                }

            }






        }

        private void buyername_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void buyer_num_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void insure_num_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void restrict_sell_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void notes_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void rest_price_bill_TextChanged(object sender, EventArgs e)
        {

        }

        private void shaseh_num_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void model_num_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void mark_car_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void motor_num_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void car_num_bill_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void total_price_bill_ValueChanged(object sender, EventArgs e)
        {
            paid_price_bill.Maximum = total_price_bill.Value;
            decimal num = (total_price_bill.Value - paid_price_bill.Value);
            if (num > 0)
            { rest_price_bill.Text = (total_price_bill.Value - paid_price_bill.Value).ToString(); }
            else { rest_price_bill.Clear(); }
            dataGridView1.Rows.Clear();
        }

        private void paid_price_bill_ValueChanged(object sender, EventArgs e)
        {
            decimal num = (total_price_bill.Value - paid_price_bill.Value);
            if (num > 0)
            { rest_price_bill.Text = (total_price_bill.Value - paid_price_bill.Value).ToString(); }
            else { rest_price_bill.Clear(); }
            dataGridView1.Rows.Clear();

        }

        private void adding_installments_Click(object sender, EventArgs e)
        {
            ValidatingFunctions.edit_installs_sign = false;
            dataGridView1.Rows.Clear();
            NewBillSingleton.delete_the_bill();
            bool yes = false;
            yes = NewBillSingleton.struct_the_bill(int.Parse(id_num.Value.ToString()),
                buyername_bill.Text,
               buyer_num_bill.Text,
               insure_num_bill.Text,
               restrict_sell_bill.Text,
               notes_bill.Text,

           int.Parse(total_price_bill.Value.ToString()),
           int.Parse(paid_price_bill.Value.ToString()),
           int.Parse(rest_price_bill.Text),
           first_pay_bill.Value);
            if (yes == true)
            {
                AddInstallmentsForm form = new AddInstallmentsForm();
                form.ShowDialog();
            }


        }

        private void add_new_bill_button_Click(object sender, EventArgs e)
        {
            try
            {
                CarHelperModel.clear();
                int id;
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());

                con.Open();
                int i = 0;
                MySqlCommand car_command = con.CreateCommand();
                if (registr_radio.Checked == true)
                {
                    CarHelperModel.set_car_number(re_number.Text);
                }
                else
                {
                    CarHelperModel.set_car_number(car_num_bill.Text);
                    CarHelperModel.set_car_number(car_num_bill.Text);
                    car_command.CommandText = "INSERT INTO cars(cars.Car_Number,cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number,cars.registered,cars.Sold) VALUES(@car_number,@Car_model,@Motor_number,@Car_mark,@Shaseh_number,false,true);";
                    car_command.Parameters.AddWithValue("@car_number", CarHelperModel.get_car_number());
                    car_command.Parameters.AddWithValue("@Car_model", model_num_bill.Text);
                    car_command.Parameters.AddWithValue("@Motor_number", motor_num_bill.Text);
                    car_command.Parameters.AddWithValue("@Car_mark", mark_car_bill.Text);
                    car_command.Parameters.AddWithValue("@Shaseh_number", shaseh_num_bill.Text);
                    i = car_command.ExecuteNonQuery();
                }



                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO bills(id,Buyer_name,Buyer_phone,Inserunce_phone,Restrict_sell_for,Notes,Total_price,Paid_price,To_pay_price,First_pay_date,created_date,paid_installs_number,notpaid_installs_number,bills.car_number) "
                + "VALUES(@id,@Buyer_name,@Buyer_phone,@Inserunce_phone,@Restrict_sell_for,@Notes,@Total_price,@Paid_price,@To_pay_price,@First_pay_date,@First_pay_date1,0,@num_installs,@car_number);";
                cmd.Parameters.AddWithValue("@id", NewBillSingleton.get_id());
                cmd.Parameters.AddWithValue("@Buyer_name", NewBillSingleton.get_buyer_name());
                cmd.Parameters.AddWithValue("@Buyer_phone", NewBillSingleton.get_buyer_phone());
                cmd.Parameters.AddWithValue("@Inserunce_phone", NewBillSingleton.get_insurence_phone());
                cmd.Parameters.AddWithValue("@Restrict_sell_for", NewBillSingleton.get_restrict_sell_for());
                cmd.Parameters.AddWithValue("@Notes", NewBillSingleton.get_notes());

                cmd.Parameters.AddWithValue("@Total_price", NewBillSingleton.get_total_price());
                cmd.Parameters.AddWithValue("@Paid_price", NewBillSingleton.get_paid_price());
                cmd.Parameters.AddWithValue("@To_pay_price", NewBillSingleton.get_rest_price());
                cmd.Parameters.AddWithValue("@First_pay_date", NewBillSingleton.get_first_pay_date());
                cmd.Parameters.AddWithValue("@First_pay_date1", NewBillSingleton.get_first_pay_date());

                cmd.Parameters.AddWithValue("@num_installs", NewBillSingleton.get_installments().Count);
                cmd.Parameters.AddWithValue("@car_number", CarHelperModel.get_car_number());


                cmd.ExecuteNonQuery();


                int counter = 1;
                foreach (Installments ins in NewBillSingleton.get_installments())
                {
                    MySqlCommand cmd_installs = con.CreateCommand();
                    //string id_key = id.ToString() + counter.ToString();
                    cmd_installs.CommandText = "INSERT INTO installs(bill_id,Total_price,To_pay_price,Paid_price,Stat,Paying_date,Notes) VALUES(@bill_id,@Total_price,@To_pay_price,@Paid_price,@Stat,@Paying_date,@Notes);";
                    //cmd_installs.Parameters.AddWithValue("@id1", id_key);
                    cmd_installs.Parameters.AddWithValue("@bill_id", NewBillSingleton.get_id());
                    cmd_installs.Parameters.AddWithValue("@Total_price", ins.get_total_price());
                    cmd_installs.Parameters.AddWithValue("@To_pay_price", ins.get_to_pay_price());
                    cmd_installs.Parameters.AddWithValue("@Paid_price", ins.get_remain());
                    cmd_installs.Parameters.AddWithValue("@Stat", ins.get_stat());
                    cmd_installs.Parameters.AddWithValue("@Paying_date", ins.get_paying_date());
                    cmd_installs.Parameters.AddWithValue("@Notes", ins.get_notes());
                    counter += 1;
                    cmd_installs.ExecuteNonQuery();

                }



                if (registr_radio.Checked == true)
                {
                    CarHelperModel.set_car_number(re_number.Text);
                    car_command.CommandText = "UPDATE cars SET cars.Sold=true WHERE cars.Car_Number=@car_number";
                    car_command.Parameters.AddWithValue("@car_number", CarHelperModel.get_car_number());
                    i = car_command.ExecuteNonQuery();


                }


                if (i != 1)
                {
                    MessageBox.Show("خطأ");
                    return;
                }




                con.Close();







                tableLayoutPanel1.Enabled = true;
                tableLayoutPanel2.Enabled = true;
                validate_button.Enabled = true;
                adding_installments.Enabled = false;
                add_new_bill_button.Enabled = false;
                groupBox1.Enabled = true;
                ValidatingFunctions.ResetAllControls(new List<Control>(){buyername_bill,
                buyer_num_bill,
                car_num_bill,
                insure_num_bill,
                motor_num_bill,
                model_num_bill,
                shaseh_num_bill,
                restrict_sell_bill,
                notes_bill,
                dataGridView1,
                total_price_bill,
                rest_price_bill,
                paid_price_bill,
                mark_car_bill,
                first_pay_bill,
                id_num
            });
                register.Enabled = true;
                unregistr_radio.Enabled = true;
                unregister.Enabled = true;

                re_motor.Text = "";
                re_number.Text = "";
                re_mark.Text = "";
                re_model.Text = "";
                re_shaseh.Text = "";
                refresh_cars(re_number);
                errorProvider1.Dispose();
                NewBillSingleton.delete_the_bill();
                MessageBox.Show("تم بنجاح");

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            catch (MySqlException ee)
            {

                if (ee.ToString().Contains("entry"))
                {
                    MessageBox.Show("رقم الفاتورة او السيارة  مكرر");
                    id_num.Enabled = true;
                    validate_button.Enabled = true;
                    adding_installments.Enabled = true;
                    tableLayoutPanel1.Enabled = true;
                    tableLayoutPanel2.Enabled = true;
                    groupBox1.Enabled = true;
                    register.Enabled = true;
                    unregister.Enabled = true;
                    add_new_bill_button.Enabled = false;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("خطأ في السيرفر");
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
            }
        }

        private void BellUI_Load(object sender, EventArgs e)
        {


        }

        private void unregistr_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (unregistr_radio.Checked == true)
            {
                registr_radio.Checked = false;
                unregister.Visible = true;
                register.Visible = false;
                ValidatingFunctions.ResetAllControls(new List<Control>(){car_num_bill,motor_num_bill,mark_car_bill,
                model_num_bill,shaseh_num_bill});
                /////
            }
        }

        private void register_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (registr_radio.Checked == true)
            {
                unregistr_radio.Checked = false;
                unregister.Visible = false;
                register.Visible = true;
                ValidatingFunctions.ResetAllControls(new List<Control>() { re_mark, re_model, re_motor, re_shaseh });

                /////
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    car_setup = true;


                }
                else
                {
                    MessageBox.Show("خطأ");
                    car_setup = false;
                }
                con.Close();

            }
            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
                car_setup = false;
            }
            catch (Exception eee)
            {
                car_setup = false;
                MessageBox.Show("خطأ");

            }
        }

        private void re_number_TextChanged(object sender, EventArgs e)
        {
            if (!re_number.Items.Contains(re_number.Text))
            {
                ValidatingFunctions.ResetAllControls(new List<Control>() { re_mark, re_model, re_motor, re_shaseh });
                car_setup = false;

            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandText = "SELECT cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number FROM cars WHERE cars.Car_Number=@number AND cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                    cmd1.Parameters.AddWithValue("@number", re_number.Text);
                    // MessageBox.Show(re_number.Text);
                    MySqlDataReader rd = cmd1.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        re_model.Text = rd[0].ToString();
                        re_motor.Text = rd[1].ToString();
                        re_mark.Text = rd[2].ToString();
                        re_shaseh.Text = rd[3].ToString();
                        car_setup = true;


                    }
                    else
                    {
                        MessageBox.Show("خطأ");
                        car_setup = false;
                    }
                    con.Close();

                }
                catch (MySqlException ee)
                {
                    MessageBox.Show("خطأ في السيرفر");
                    car_setup = false;
                }
                catch (Exception eee)
                {
                    MessageBox.Show("خطأ");

                    car_setup = false;


                }
            }
        }



        private void id_num_MouseClick(object sender, MouseEventArgs e)
        {
            id_num.Select(0, id_num.Text.Length);
        }



        private void total_price_bill_MouseClick(object sender, MouseEventArgs e)
        {
            total_price_bill.Select(0, total_price_bill.Text.Length);
        }

        private void paid_price_bill_MouseClick(object sender, MouseEventArgs e)
        {
            paid_price_bill.Select(0, paid_price_bill.Text.Length);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            validate_button.Enabled = true;
            adding_installments.Enabled = false;
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel2.Enabled = true;
            unregister.Enabled = true;
            groupBox1.Enabled = true;
            register.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            add_new_bill_button.Enabled = false;
        }




    }
}
