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
    public partial class Bill_information_edit : Form
    {
        public Bill_information_edit()
        {
            InitializeComponent();
        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void validate_button_Click(object sender, EventArgs e)
        {

            TextBox emptyTextBox = ValidatingFunctions.validate_textboxes(new List<TextBox>(){pay_buyer_name,
                pay_buyer_num,
                    pay_insurence_num,
                restrict_sell_bill
               });
            if (emptyTextBox != null)
            {
                errorProvider1.SetError(emptyTextBox, "empty");
                return;
            }
            if (id_num.Value > 0 && ValidatingFunctions.id_to_edit_bill_details>0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE bills SET bills.Buyer_name=@name,bills.Buyer_phone=@Buyer_phone,bills.Inserunce_phone=@Inserunce_phone,bills.Restrict_sell_for=@Restrict_sell_for,bills.Notes=@Notes,bills.created_date=@created_date WHERE bills.id=@old_id";
                   // cmd.Parameters.AddWithValue("@id",int.Parse(id_num.Value.ToString()));
                    cmd.Parameters.AddWithValue("@name",pay_buyer_name.Text);
                    cmd.Parameters.AddWithValue("@Buyer_phone",pay_buyer_num.Text);
                    cmd.Parameters.AddWithValue("@Inserunce_phone",pay_insurence_num.Text);
                    
                    cmd.Parameters.AddWithValue("@Restrict_sell_for",restrict_sell_bill.Text);
                    cmd.Parameters.AddWithValue("@Notes",notes_bill.Text);

                    cmd.Parameters.AddWithValue("@created_date",first_pay_bill.Value);


                    cmd.Parameters.AddWithValue(@"old_id",ValidatingFunctions.id_to_edit_bill_details);
                    object ii = cmd.ExecuteNonQuery();
                    int check = int.Parse(ii.ToString());
                    con.Close();
                    if (check <= 0)
                    {
                          MessageBox.Show("خطأ");
                      
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("تم بنجاح");
                        this.Close();
                    }
                    



                }
                catch (MySqlException ee)
                {
                    if (ee.ToString().Contains("entry"))
                    { MessageBox.Show("رقم الفاتورة مكرر"); }
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
            
        }

        private void pay_buyer_name_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void pay_buyer_num_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void pay_insurence_num_TextChanged(object sender, EventArgs e)
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

        private void Bill_information_edit_Load(object sender, EventArgs e)
        {
            if (ValidatingFunctions.id_to_edit_bill_details > 0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.Restrict_sell_for,bills.Notes,bills.created_date FROM bills WHERE bills.id=@id;";
                    cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_to_edit_bill_details);
                    MySqlDataReader re = cmd.ExecuteReader();
                    re.Read();
                    id_num.Value = int.Parse(re[0].ToString());
                    pay_buyer_name.Text = re[1].ToString();
                    pay_buyer_num.Text = re[2].ToString();
                    pay_insurence_num.Text = re[3].ToString();
                    restrict_sell_bill.Text = re[4].ToString();
                    notes_bill.Text = re[5].ToString();
                    first_pay_bill.Value = (DateTime)re[6];
                }
                catch (MySqlException ee) {
                    MessageBox.Show("خطأ في السيرفر");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string error = "خطأ";
            NewBillSingleton.delete_the_bill();
            bool yes = false;
            try 
            {
                int to_pay = 0;
                DateTime date;

                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                string command;
                command = "SELECT SUM(installs.To_pay_price) FROM installs WHERE installs.To_pay_price=installs.Total_price AND installs.bill_id=@id;";
                cmd.CommandText = command;
                cmd.Parameters.AddWithValue("@id", int.Parse(id_num.Value.ToString()));
                to_pay=int.Parse( cmd.ExecuteScalar().ToString());

               
             
                command = "SELECT Paying_date FROM installs WHERE installs.To_pay_price=installs.Total_price AND installs.bill_id=@id2 ORDER BY(Paying_date) ASC; ";
                cmd.CommandText = command;
                cmd.Parameters.AddWithValue("@id2", int.Parse(id_num.Value.ToString()));
                MySqlDataReader eq = cmd.ExecuteReader();
                eq.Read();
                date = (DateTime)eq[0];
                eq.Close();

                command = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.Restrict_sell_for,bills.Notes,bills.Total_price,bills.Paid_price FROM bills WHERE bills.id=@id1;";
                cmd.CommandText = command;
                cmd.Parameters.AddWithValue("@id1", int.Parse(id_num.Value.ToString()));
                MySqlDataReader rd=cmd.ExecuteReader();
                rd.Read();
               // MessageBox.Show(date.ToShortDateString());


                yes = NewBillSingleton.struct_the_bill(int.Parse(rd[0].ToString()),
                rd[1].ToString(),
               rd[2].ToString(),
               rd[3].ToString(),
               rd[4].ToString(),
               rd[5].ToString(),
               int.Parse(rd[6].ToString()),
               int.Parse(rd[7].ToString()),
               to_pay,
               date);
                ValidatingFunctions.edit_installs_sign = true;
            }
            catch (Exception ee) {
                if (ee.ToString().Contains("correct format"))
                {
                    error = "تم سداد هذه الفاتورة بالكامل";
                 }
                yes = false; 

            }
            
            if (yes == true)
            {
                UnOrgInstaWF gf = new UnOrgInstaWF();
                gf.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show(error); }
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bill_id = int.Parse(id_num.Value.ToString());

            PrintForms.BillDetailsForm bill_details = new PrintForms.BillDetailsForm(bill_id);
            bill_details.button1_Click(sender,e);


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
            
        }
    }
}
