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
    public partial class login : Form
    {
        private string password_right;
        public login()
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
            if (username.Text.ToString().Equals("elbasha"))
            {
                if (password.Text.ToString().Equals(password_right))
                {

                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        Form1 form1=(Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                        ValidatingFunctions.setLOGIN_TOKEN(true);
                        ValidatingFunctions.signin_signout(new List<Control>(){form1.button3,
                        form1.button4,
                        form1.button5,
                        form1.button6,
                        form1.button8,
                        form1.button9,
                        form1.button10}
                        ,true);
                        MainUI main = (MainUI)form1.Controls.OfType<MainUI>().ToList().ElementAt(0);
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
