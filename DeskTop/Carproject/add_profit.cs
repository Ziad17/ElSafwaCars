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
    public partial class add_profit : Form
    {
        public add_profit()
        {
            InitializeComponent();
        }

        private void add_profit_Load(object sender, EventArgs e)
        {
            if(ValidatingFunctions.contr_id_to_add_profit>0)
            {
                try 
                {
                    MySqlConnection con=new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT contr.id,contr.name,contr.number,contr.total_cash ,contr.next_pay_date,contr.duration FROM contr WHERE contr.id=@id;";
                    cmd.Parameters.AddWithValue("@id",ValidatingFunctions.contr_id_to_add_profit);
                    MySqlDataReader rd=cmd.ExecuteReader();
                    rd.Read();
                    id.Text=rd[0].ToString();
                    name.Text = rd[1].ToString();
                   // phone.Text = rd[2].ToString();
                    total.Text=rd[3].ToString();
                    if (rd[5].ToString().Contains("ش"))
                    {
                        DateTime s = (DateTime)rd[4];
                        date_to_alert.Value = s.AddMonths(1);
                    }
                    else
                    {
                        DateTime s = (DateTime)rd[4];
                        date_to_alert.Value = s.AddDays(7);
                    }

                }
                catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر");
                this.Close();
                }
                catch (Exception eee) {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(price.Value>0)
            {
                try 
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO profit(contr_id,paying_date,pay_value,notes) VALUES(@contr_id,@paying_date,@pay_value,@notes);";
                    cmd.Parameters.AddWithValue("@contr_id", ValidatingFunctions.contr_id_to_add_profit);
                    cmd.Parameters.AddWithValue("@paying_date", first_pay_bill.Value);
                    cmd.Parameters.AddWithValue("@pay_value", int.Parse(price.Value.ToString()));
                    cmd.Parameters.AddWithValue("@notes",notes.Text);
                    cmd.ExecuteNonQuery();
                    //MySqlCommand cmd1 = con.CreateCommand();
                    cmd.CommandText = "UPDATE contr SET contr.next_pay_date=@date_1, contr.proft_num=contr.proft_num+1 WHERE contr.id=@id;";
                    cmd.Parameters.AddWithValue("@id", ValidatingFunctions.contr_id_to_add_profit);
                    cmd.Parameters.AddWithValue("@date_1",date_to_alert.Value );

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
            else{
                MessageBox.Show("مبلغ خطأ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void price_MouseClick(object sender, MouseEventArgs e)
        {
            price.Select(0, price.Text.Length);

        }
    }
}
