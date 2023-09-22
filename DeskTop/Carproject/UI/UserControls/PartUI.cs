using System;
using System.Windows.Forms;
using Carproject.UI.Forms;

namespace Carproject.UI.UserControls
{
    public partial class PartUI : UserControl
    {
        public PartUI()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddContributionForm part_form = new AddContributionForm();
            part_form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidatingFunctions.id_contribute = 0;
            ViewContributionsForm form = new ViewContributionsForm();
            form.ShowDialog();
            HomeScreenForm form1 = (HomeScreenForm)System.Windows.Forms.Application.OpenForms["Form1"];
            form1.button5_Click(sender, e);

        }

        private void PartUI_Load(object sender, EventArgs e)
        {

        }

        private void ccc_Enter(object sender, EventArgs e)
        {

        }

        private void contr_today_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (contr_today.Rows.Count > 0)
                {
                    int index = contr_today.SelectedRows[0].Index;

                    string id = contr_today.Rows[index].Cells[0].Value.ToString();
                    //  MessageBox.Show(id);
                    ValidatingFunctions.id_contribute = int.Parse(id);
                    ViewContributionsForm form = new ViewContributionsForm();
                    form.ShowDialog();
                    // View_install_by_id(id);

                }
            }

        }

        private void contr_pinned_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (contr_pinned.Rows.Count > 0)
                {
                    int index = contr_pinned.SelectedRows[0].Index;

                    string id = contr_pinned.Rows[index].Cells[0].Value.ToString();
                    // MessageBox.Show(id);
                    ValidatingFunctions.id_contribute = int.Parse(id);
                    ViewContributionsForm form = new ViewContributionsForm();
                    form.ShowDialog();
                    // View_install_by_id(id);

                }
            }

        }


    }
}
