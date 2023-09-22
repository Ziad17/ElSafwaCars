using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Carproject.UI.Forms;

namespace Carproject.UI.UserControls
{
    public partial class MainUI : UserControl
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewNotificationsForm alert_form = new ViewNotificationsForm();
            alert_form.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginForm login_form = new LoginForm();
            login_form.ShowDialog();


        }

        public void sign_out_Click(object sender, EventArgs e)
        {
            ValidatingFunctions.setLOGIN_TOKEN(false);
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                HomeScreenForm form1 = (HomeScreenForm)System.Windows.Forms.Application.OpenForms["Form1"];
                ValidatingFunctions.setLOGIN_TOKEN(false);
                ValidatingFunctions.signin_signout(new List<Control>(){form1.button3,
                        form1.button4,
                        form1.button5,
                        form1.button6,
                        form1.button10,
                form1.button8,
                form1.button9}
                , false);
                sign_in.Enabled = true;
                sign_out.Enabled = false;
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {




        }

    }
}
