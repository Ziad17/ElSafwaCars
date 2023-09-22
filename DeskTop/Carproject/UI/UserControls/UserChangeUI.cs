using System;
using System.Linq;
using System.Windows.Forms;
using Carproject.UI.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.UserControls
{
    public partial class UserChangeUI : UserControl
    {
        private string password_right;
        private string new_pass;
        public UserChangeUI()
        {
            InitializeComponent();

        }

        private void UserChangeUI_Load(object sender, EventArgs e)
        {



            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT passwords.current_password FROM passwords WHERE passwords.id=1;";
                password_right = cmd.ExecuteScalar().ToString();
                con.Close();

            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT passwords.current_password FROM passwords WHERE passwords.id=1;";
                password_right = cmd.ExecuteScalar().ToString();
                con.Close();

            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");
            }
            if (old.Text.Equals(password_right))
            {
                new_pass = password.Text;
                if (new_pass.Equals(confirm.Text))
                {
                    var confirmResult = MessageBox.Show("متابعة؟",
                                         "حفظ التعديل",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "UPDATE passwords SET passwords.current_password=@pass WHERE passwords.id=1;";
                            cmd.Parameters.AddWithValue("@pass", new_pass);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            old.Text = "";
                            password.Text = "";
                            confirm.Text = "";
                            HomeScreenForm form1 = (HomeScreenForm)System.Windows.Forms.Application.OpenForms["Form1"];
                            MainUI main = (MainUI)form1.Controls.OfType<MainUI>().ToList().ElementAt(0);
                            form1.button2_Click(sender, e);
                            main.sign_out_Click(sender, e);



                        }
                        catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
                        catch (Exception eee)
                        {
                            MessageBox.Show("خطأ");
                        }
                    }

                }
                else { MessageBox.Show("كلمتي السر غير متاطبقتين "); }
            }
            else
            { MessageBox.Show("كلمة السر القديمة خاطئة"); }
        }

        private void old_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { password.Focus(); }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            { confirm.Focus(); }
        }

        private void confirm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            { button2.PerformClick(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
