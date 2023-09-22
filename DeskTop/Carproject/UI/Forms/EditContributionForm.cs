using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Forms
{
    public partial class EditContributionForm : Form
    {
        public EditContributionForm()
        {
            InitializeComponent();
        }

        private void contr_edit_details_Load(object sender, EventArgs e)
        {
            if (ValidatingFunctions.id_contribute > 0)
            {
                try
                {
                    comboBox1.SelectedIndex = 0;
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT contr.id,contr.name,contr.number,contr.total_cash,contr.next_pay_date,contr.create_date,contr.notes,contr.duration,contr.stat FROM contr WHERE contr.id=@id;";
                    cmd.Parameters.AddWithValue("@id", ValidatingFunctions.id_contribute);
                    MySqlDataReader re = cmd.ExecuteReader();
                    re.Read();
                    id_num.Value = int.Parse(re[0].ToString());
                    pay_buyer_name.Text = re[1].ToString();
                    pay_buyer_num.Text = re[2].ToString();
                    numericUpDown1.Value = int.Parse(re[3].ToString());
                    dateTimePicker1.Value = (DateTime)re[4];
                    first_pay_bill.Value = (DateTime)re[5];
                    notes_bill.Text = re[6].ToString();
                    string dur = re[7].ToString();
                    if (dur.Contains("ش"))
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                    else { comboBox1.SelectedIndex = 1; }
                    bool uu = (bool)re[8];
                    if (uu)
                    { comboBox2.SelectedIndex = 0; }
                    else { comboBox2.SelectedIndex = 1; }
                    con.Close();
                }
                catch (MySqlException ee)
                {
                    this.Close();
                    MessageBox.Show("خطأ في السيرفر");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validate_button_Click(object sender, EventArgs e)
        {
            TextBox emptyTextBox = ValidatingFunctions.validate_textboxes(new List<TextBox>(){pay_buyer_name,
                pay_buyer_num


             });
            if (emptyTextBox != null)
            {
                errorProvider1.SetError(emptyTextBox, "empty");
                return;
            }
            if (numericUpDown1.Value >= 0 && ValidatingFunctions.id_contribute > 0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE contr SET contr.name=@name,contr.number=@number,contr.total_cash=@total_cash,contr.next_pay_date=@next_pay_date,contr.create_date=@create_date,contr.notes=@notes,contr.duration=@duration,contr.stat=@stat WHERE contr.id=@id;";
                    cmd.Parameters.AddWithValue("@id", int.Parse(id_num.Value.ToString()));
                    cmd.Parameters.AddWithValue("@name", pay_buyer_name.Text);
                    cmd.Parameters.AddWithValue("@number", pay_buyer_num.Text);
                    cmd.Parameters.AddWithValue("@total_cash", int.Parse(numericUpDown1.Value.ToString()));

                    cmd.Parameters.AddWithValue("@next_pay_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@create_date", first_pay_bill.Value);

                    cmd.Parameters.AddWithValue("@notes", notes_bill.Text);
                    string dur = "";
                    if (comboBox1.SelectedIndex == 0)
                    {
                        dur = "شهريا";
                    }
                    else { dur = "أسبوعيا"; }
                    cmd.Parameters.AddWithValue("@duration", dur);
                    bool stat;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        stat = true;

                    }
                    else { stat = false; }
                    cmd.Parameters.AddWithValue("@stat", stat);




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

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            numericUpDown1.Select(0, numericUpDown1.Text.Length);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
