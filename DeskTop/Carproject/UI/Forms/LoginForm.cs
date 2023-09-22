using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Carproject.UI.UserControls;
using MySql.Data.MySqlClient;

namespace Carproject.UI.Forms
{
    public partial class LoginForm : Form
    {
        private string password_right;
        public LoginForm()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            password.Text = "123456";
            if (username.Text.ToString().Equals("elbasha"))
            {
                if (password.Text.ToString().Equals(password_right))
                {

                    if (System.Windows.Forms.Application.OpenForms[nameof(HomeScreenForm)] != null)
                    {
                        HomeScreenForm homeScreenForm = (HomeScreenForm)System.Windows.Forms.Application.OpenForms[nameof(HomeScreenForm)];
                        ValidatingFunctions.setLOGIN_TOKEN(true);
                        ValidatingFunctions.signin_signout(new List<Control>(){homeScreenForm.button3,
                        homeScreenForm.button4,
                        homeScreenForm.button5,
                        homeScreenForm.button6,
                        homeScreenForm.button8,
                        homeScreenForm.button9,
                        homeScreenForm.viewLawSuitsButton,
                        homeScreenForm.button10}
                        , true);
                        MainUI main = (MainUI)homeScreenForm.Controls.OfType<MainUI>().ToList().ElementAt(0);
                        main.sign_in.Enabled = false;
                        main.sign_out.Enabled = true;
                    }
                    this.Close();
                }
                else { System.Windows.Forms.MessageBox.Show("الرقم السري غير صحيح"); }

            }
            else { System.Windows.Forms.MessageBox.Show("أسم المستخدم غير صحيح"); }
        }

        private void login_Load(object sender, EventArgs e)
        {
            username.Text = "elbasha";
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { password.Focus(); }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button2.PerformClick(); }
        }
    }
}
