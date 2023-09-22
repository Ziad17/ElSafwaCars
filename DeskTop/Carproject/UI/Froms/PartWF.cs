using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Froms
{
    public partial class PartWF : Form
    {
        public PartWF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PartWF_Load(object sender, EventArgs e)
        {
            ValidatingFunctions.ResetAllControls(new List<Control>() { contr_name, contr_phone, contr_total_price, contr_first_pay_date, contr_notes, contr_duration });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price;
            TextBox emptyTextBox = null;
            emptyTextBox = ValidatingFunctions.validate_textboxes(new List<TextBox>() { contr_name, contr_phone });
            if (emptyTextBox != null)
            {
                errorProvider1.SetError(emptyTextBox, "empty");
                return;
            }
            else
            {
                price = int.Parse(contr_total_price.Value.ToString());
                if (price > 0)
                {
                    if (int.Parse(id_contr.Value.ToString()) > 0)
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            string command = "INSERT INTO contr(id,name,number,total_cash,next_pay_date,create_date,notes,stat,duration) VALUES(@id,@name,@number,@price,@first_pay,@created_date,@notes,false,@duration);";
                            cmd.CommandText = command;
                            cmd.Parameters.AddWithValue("@id", int.Parse(id_contr.Value.ToString()));

                            cmd.Parameters.AddWithValue("@name", contr_name.Text);
                            cmd.Parameters.AddWithValue("@number", contr_phone.Text);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@created_date", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@first_pay", contr_first_pay_date.Value);
                            cmd.Parameters.AddWithValue("@notes", contr_notes.Text);
                            cmd.Parameters.AddWithValue("@duration", contr_duration.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();
                            con.Close();
                            ValidatingFunctions.ResetAllControls(new List<Control>() { contr_name, contr_phone, contr_total_price, contr_first_pay_date, contr_notes, contr_duration });
                            MessageBox.Show("تم بنجاح");

                            Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                            form1.button5_Click(sender, e);
                            this.Close();

                        }
                        catch (MySqlException ee)
                        {
                            if (ee.ToString().Contains("entry"))
                            { MessageBox.Show("رقم المساهمة مكرر"); }
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
                    else { MessageBox.Show("رقم مساهمة خاطئ"); }

                }
                else { MessageBox.Show("مبلغ مالي خاطئ"); }

            }



        }

        private void contr_name_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void contr_phone_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void contr_notes_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void contr_total_price_ValueChanged(object sender, EventArgs e)
        {
            contr_total_price.Select(0, contr_total_price.Text.Length);

        }

        private void id_contr_ValueChanged(object sender, EventArgs e)
        {
            id_contr.Select(0, id_contr.Text.Length);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contr_duration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
