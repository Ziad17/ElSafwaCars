using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Carproject
{
    public partial class add_withdraw : Form
    {
        public add_withdraw()
        {
            InitializeComponent();
            take_radio.Checked = true;

        }

        private void add_withdraw_Load(object sender, EventArgs e)
        {
            if (ValidatingFunctions.id_contribute > 0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT contr.id,contr.name,contr.number,contr.total_cash FROM contr WHERE contr.id=@id;";
                    cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_contribute);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    id.Text = rd[0].ToString();
                    name.Text = rd[1].ToString();
                    //phone.Text = rd[2].ToString();
                    total.Text = rd[3].ToString();
                    price.Maximum = int.Parse(rd[3].ToString());


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
            else
            {
                MessageBox.Show("خطأ");
                this.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (price.Value > 0)
            {
                if (take_radio.Checked == true)
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO withdarws(contr_id,withdraw_value,notes,withdraw_date) VALUES(@contr_id,@withdraw_value,@notes,@withdraw_date);";
                        cmd.Parameters.AddWithValue("@contr_id", ValidatingFunctions.id_contribute);
                        cmd.Parameters.AddWithValue("@withdraw_date", first_pay_bill.Value);
                        cmd.Parameters.AddWithValue("@withdraw_value", int.Parse(price.Value.ToString()));
                        cmd.Parameters.AddWithValue("@notes", notes.Text);
                        cmd.ExecuteNonQuery();
                        //MySqlCommand cmd1 = con.CreateCommand();
                        cmd.CommandText = "UPDATE contr SET contr.total_cash=contr.total_cash-@number, contr.withdraw_num=contr.withdraw_num+1 WHERE contr.id=@id;";
                        cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_contribute);
                        cmd.Parameters.AddWithValue("@number", int.Parse(price.Value.ToString()));


                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تم بنجاح");
                        this.Close();
                    }
                    catch (MySqlException ee)
                    {
                        // MessageBox.Show(ee.ToString());
                        MessageBox.Show("خطأ في السيرفر");

                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show("خطأ");

                    }
                }
                else if (give_radio.Checked == true)
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO withdarws(contr_id,withdraw_value,notes,withdraw_date,withdraw) VALUES(@contr_id,@withdraw_value,@notes,@withdraw_date,false);";
                        cmd.Parameters.AddWithValue("@contr_id", ValidatingFunctions.id_contribute);
                        cmd.Parameters.AddWithValue("@withdraw_date", first_pay_bill.Value);
                        cmd.Parameters.AddWithValue("@withdraw_value", int.Parse(price.Value.ToString()));
                        cmd.Parameters.AddWithValue("@notes", notes.Text);
                        cmd.ExecuteNonQuery();
                        //MySqlCommand cmd1 = con.CreateCommand();
                        cmd.CommandText = "UPDATE contr SET contr.total_cash=contr.total_cash+@number, contr.withdraw_num=contr.withdraw_num+1 WHERE contr.id=@id;";
                        cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_contribute);
                        cmd.Parameters.AddWithValue("@number", int.Parse(price.Value.ToString()));


                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تم بنجاح");
                        this.Close();
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
                else
                {
                    MessageBox.Show("خطأ");
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("مبلغ خطأ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void first_pay_bill_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void name_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (give_radio.Checked == true)
            { price.Maximum = 10000000; }
        }

        private void price_MouseClick(object sender, MouseEventArgs e)
        {
            price.Select(0, price.Text.Length);

        }

        private void take_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (take_radio.Checked == true)
            {
                try { price.Maximum = int.Parse(total.Text); }
                catch (Exception ee) { price.Maximum = 0; }                
            }
        }
    }
}
