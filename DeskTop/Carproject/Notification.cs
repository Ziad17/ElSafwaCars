using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Carproject
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AlertsWF_Load(object sender, EventArgs e)
        {
            ValidatingFunctions.update_bills_notifications();
          
            if (ValidatingFunctions.get_today_alerts().Rows.Count>0)
            {
                DataTable dt = ValidatingFunctions.get_today_alerts();
          
                installs_today.DataSource = dt;
                installs_today.Columns[0].HeaderText = "رقم الفاتورة";
                installs_today.Columns[1].HeaderText = "أسم المشتري";
                installs_today.Columns[2].HeaderText = "القيمة";
                installs_today.Columns[3].HeaderText = "المستحق";
                installs_today.Columns[4].HeaderText = "تاريخ السداد";
                installs_today.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                installs_today.Columns[5].HeaderText = "هاتف المشتري";
            //    installs_today.Columns[6].HeaderText = "هاتف الضامن";
                installs_today.Columns[6].HeaderText = "ملاحظات";
                installs_today.Rows[installs_today.SelectedRows[0].Index].Cells[0].Selected = false;

            }
            else
            {
                groupBox2.Text = "لا يوجد أقساط اليوم";
            }
            if (ValidatingFunctions.get_pinned_alerts().Rows.Count > 0)
            {

                installs_pinned.DataSource = ValidatingFunctions.get_pinned_alerts();
                installs_pinned.Columns[0].HeaderText = "رقم الفاتورة";
                installs_pinned.Columns[1].HeaderText = "أسم المشتري";
                installs_pinned.Columns[2].HeaderText = "اجمالي المستحق";
                installs_pinned.Columns[3].HeaderText = "عدد الاقساط المتأخرة";
                installs_pinned.Columns[4].HeaderText = "لم يسدد منذ";
                installs_pinned.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                installs_pinned.Columns[5].HeaderText = "هاتف المشتري";
          //      installs_pinned.Columns[6].HeaderText = "هاتف الضامن";
                installs_pinned.Columns[6].HeaderText = "ملاحظات";
                installs_pinned.Rows[installs_pinned.SelectedRows[0].Index].Cells[0].Selected = false;
            }
            else
            {
                groupBox1.Text = "لا يوجد أقساط منتظرة";
 
            }
         
            
        }

        private void installs_today_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            { return; }
            else
            {
                if (ValidatingFunctions.getLOGIN_TOKEN() == true)
                {
                    if (installs_today.Rows.Count > 0)
                    {

                        //int index = installs_today.SelectedRows[0].Index;
                        int index = installs_today.SelectedRows[0].Index;

                        int id = int.Parse(installs_today.Rows[index].Cells[0].Value.ToString());
                        DateTime date = (DateTime)installs_today.Rows[index].Cells[4].Value;
                        ValidatingFunctions.date_from_payinstall_to_alerts = date;
                        ValidatingFunctions.id_from_payinstall_to_alerts = id;
                        PayInstallDialog dg = new PayInstallDialog();
                      //  this.Close();
                        dg.ShowDialog();
                        this.Close();
                        //string id = installs_today.Rows[index].Cells[0].Value.ToString();
                        //Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                        //form1.payinstall2.View_install_by_id(id);
                        //form1.payinstall2.BringToFront();
                        //form1.Sidepanel.Height = form1.button6.Height;
                        //form1.Sidepanel.Top = form1.button6.Top;
                        

                    }
                }
                else
                {
                    login login_form = new login();
                    login_form.Show();
                }
            }
        }

        private void installs_pinned_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex <= -1)
                { return; }
                else
                {
                    if (ValidatingFunctions.getLOGIN_TOKEN() == true)
                    {
                        if (installs_pinned.Rows.Count > 0)
                        {

                            int index = installs_pinned.SelectedRows[0].Index;

                            int id = int.Parse(installs_pinned.Rows[index].Cells[0].Value.ToString());
                            DateTime date = (DateTime)installs_pinned.Rows[index].Cells[4].Value;
                            ValidatingFunctions.date_from_payinstall_to_alerts = date;
                            ValidatingFunctions.id_from_payinstall_to_alerts = id;
                            PayInstallDialog dg = new PayInstallDialog();
                            dg.ShowDialog();
                            this.Close();
                            //Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                            //form1.payinstall2.View_install_by_id(id);
                            //form1.payinstall2.BringToFront();
                            //form1.Sidepanel.Height = form1.button6.Height;
                            //form1.Sidepanel.Top = form1.button6.Top;


                        }
                    }
                    else
                    {
                        login login_form = new login();
                        login_form.Show();
                    }
                }
            }
            catch (ArgumentOutOfRangeException es)
            { }

        }

        private void installs_today_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            groupBox1.BringToFront();
            groupBox2.Hide();
            groupBox1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox2.BringToFront();

           
            groupBox2.Show();
            groupBox1.Hide();
        }

        private void installs_pinned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
