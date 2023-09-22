using System;
using System.Drawing;
using System.Windows.Forms;

namespace Carproject.UI.Froms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            mainUI1.BringToFront();
            //     printTesting();

        }


        public void button2_Click(object sender, EventArgs e)
        {
            payinstall2.Hide();

            pictureBox1.Show();
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;

            mainUI1.BringToFront();


        }

        public void button3_Click(object sender, EventArgs e)
        {
            payinstall2.Hide();

            pictureBox1.Show();
            Sidepanel.Height = button3.Height;
            Sidepanel.Top = button3.Top;
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            bellUI1.refresh_cars(bellUI1.re_number);
            bellUI1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            payinstall2.Hide();

            pictureBox1.Show();
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            showcars1.BringToFront();


        }

        public void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            Sidepanel.Height = button5.Height;
            Sidepanel.Top = button5.Top;
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            payinstall2.Hide();

            ValidatingFunctions.update_contr_notification();

            partui1.contr_today.DataSource = null;
            partui1.contr_pinned.DataSource = null;

            if (ValidatingFunctions.get_today_contr().Rows.Count > 0)
            {
                partui1.ccc.Text = "تنبيهات اليوم";
                partui1.contr_today.DataSource = ValidatingFunctions.get_today_contr();
                partui1.contr_today.Columns[0].HeaderText = "رقم المساهمة";
                partui1.contr_today.Columns[1].HeaderText = "الأسم";
                partui1.contr_today.Columns[2].HeaderText = "رقم الهاتف";
                partui1.contr_today.Columns[3].HeaderText = "مبلغ المساهمة";
                partui1.contr_today.Columns[4].HeaderText = "تاريخ الدفع المستحق";
                partui1.contr_today.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                partui1.contr_today.Columns[5].HeaderText = "ناريخ الانشاء";
                partui1.contr_today.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
                partui1.contr_today.Columns[6].HeaderText = "ملاحظات";
                partui1.contr_today.Columns[7].HeaderText = "فترة الدفع";

            }
            else
            {
                partui1.ccc.Text = "لا يوجد تنبيهات اليوم";
            }
            if (ValidatingFunctions.get_pinned_contr().Rows.Count > 0)
            {
                partui1.groupBox1.Text = "تنبيهات معلقة";
                partui1.contr_pinned.DataSource = ValidatingFunctions.get_pinned_contr();
                partui1.contr_pinned.Columns[0].HeaderText = "رقم المساهمة";
                partui1.contr_pinned.Columns[1].HeaderText = "الأسم";
                partui1.contr_pinned.Columns[2].HeaderText = "رقم الهاتف";
                partui1.contr_pinned.Columns[3].HeaderText = "مبلغ المساهمة";
                partui1.contr_pinned.Columns[4].HeaderText = "تاريخ الدفع المستحق";
                partui1.contr_pinned.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                partui1.contr_pinned.Columns[5].HeaderText = "ناريخ الانشاء";
                partui1.contr_pinned.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
                partui1.contr_pinned.Columns[6].HeaderText = "ملاحظات";
                partui1.contr_pinned.Columns[7].HeaderText = "فترة الدفع";

            }
            else
            {
                partui1.groupBox1.Text = "لا يوجد تنبيهات منتظرة";

            }
            partui1.BringToFront();




        }

        public void button6_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button6.Height;
            Sidepanel.Top = button6.Top;
            pictureBox1.Hide();
            payinstall2.Show();
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            payinstall2.Location = new Point(0, 20);
            payinstall2.Size = new Size(1100, 760);
            payinstall2.BringToFront();

        }

        private void bellUI1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            payinstall2.Hide();

            pictureBox1.Show();
            Sidepanel.Height = button8.Height;
            Sidepanel.Top = button8.Top;
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;

            accUI1.populate_stats();
            accUI1.BringToFront();



        }

        private void button9_Click(object sender, EventArgs e)

        {
            payinstall2.Hide();

            pictureBox1.Show();
            Sidepanel.Height = button9.Height;
            Sidepanel.Top = button9.Top;
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;
            userChangeUI1.BringToFront();
        }

        private void userChangeUI1_Load(object sender, EventArgs e)
        {

        }

        private void mainUI1_Load(object sender, EventArgs e)
        {
        }

        private void printTesting()
        {
            PrintForms.SellingContractForm selling_Form = new PrintForms.SellingContractForm();
            //Hiding the Border to simulate a fullscreen-experience

            selling_Form.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            selling_Form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            payinstall2.Hide();

            pictureBox1.Show();
            Sidepanel.Height = button10.Height;
            Sidepanel.Top = button10.Top;
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;
            printForm.BringToFront();

        }
    }
}
