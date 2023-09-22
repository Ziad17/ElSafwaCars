using System;
using System.Windows.Forms;
using Carproject.UI.Forms;

namespace Carproject.UI.UserControls
{
    public partial class PrintForm : UserControl
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintForms.SellingContractForm selling_Form = new PrintForms.SellingContractForm();
            //Hiding the Border to simulate a fullscreen-experience

            selling_Form.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            selling_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintForms.AllTrafficForm selling_Form = new PrintForms.AllTrafficForm();
            //Hiding the Border to simulate a fullscreen-experience

            selling_Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
            form1.button6_Click(sender, e);
        }
    }
}
