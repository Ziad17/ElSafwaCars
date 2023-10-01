using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Carproject.Entities;
using Carproject.UI.Forms;
using MySql.Data.MySqlClient;

namespace Carproject.UI.UserControls
{
    public partial class ViewLawSuitsControl : UserControl
    {
        private bool searchAll;
        public int SELECTION_MODE;
        public int MODE_MULTI = 1;
        public int MODE_SINGLE = 2;
        public int multi_index;
        public int single_id;

        public ViewLawSuitsControl()
        {
            InitializeComponent();
            populate_names();
        }


        public void PayInstall_Load(object sender, EventArgs e)
        {
            searchAll = true;
            RefreshData(sender, e);
        }

        public void populate_names()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            string name = name_search.Text;
            string command = "SELECT bills.Buyer_name FROM bills;";


            cmd.CommandText = command;


            MySqlDataAdapter rd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            foreach (DataRow datarow in dt.Rows)
            {
                name_search.Items.Add(datarow["Buyer_name"].ToString());
            }


            con.Close();
            name_search.SelectionStart = name_search.Text.Length;
        }


        private void SearchClick(object sender, EventArgs e)
        {
            if (id_radio.Checked || name_radio.Checked || caseNumberRadioButton.Checked)
            {
                string error = "";
                try
                {
                    var lawSuits = new List<LawSuit>();
                    using var context = new ElbashacarsContext();

                    if (id_radio.Checked)
                    {
                        var id = int.Parse(id_search.Value.ToString());
                        lawSuits = context.LawSuits.Where(c => c.BillId == id).ToList();
                    }

                    if (name_radio.Checked)
                    {
                        string name = name_search.Text;
                        lawSuits = context.LawSuits.Where(c => c.Bill.BuyerName.Contains(name)).ToList();
                    }
                    if (caseNumberRadioButton.Checked)
                    {
                        string caseNumber = caseNumberComboBox.Text;
                        lawSuits = context.LawSuits.Where(c => c.CaseNumber.Contains(caseNumber)).ToList();
                    }

                    FillTable(lawSuits);
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
            }

        }

        private void CaseNumebrRadioCheckedChanged(object sender, EventArgs e)
        {
            if (caseNumberRadioButton.Checked)
            {
                id_search.Visible = false;
                caseNumberComboBox.Visible = true;
                name_search.Visible = false;
            }
        }

        private void name_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (name_radio.Checked)
            {
                name_search.Text = "";
                id_search.Visible = false;
                caseNumberComboBox.Visible = false;
                name_search.Visible = true;
            }
        }

        private void id_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (id_radio.Checked)
            {
                id_search.Value = 0;
                id_search.Visible = true;
                caseNumberComboBox.Visible = false;
                name_search.Visible = false;
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            lawSuitsGrid.DataSource = null;
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SearchAll_Click(object sender, EventArgs e)
        {
            using var context = new ElbashacarsContext();
            lawSuitsGrid.DataSource = null;
            lawSuitsGrid.Refresh();

            searchAll = true;

            var lawSuits = context.LawSuits.Include(c => c.Bill).OrderByDescending(c => c.CreationDate).ToList();
            FillTable(lawSuits);
        }

        public void FillTable(List<LawSuit> lawSuits)
        {
            try
            {
                var model = lawSuits
                    .Select(c => new
                    {
                        c.Id,
                        c.BillId,
                        c.Bill.BuyerName,
                        c.CaseNumber,
                        c.InventoryNumber,
                        c.Judgement,
                        c.LawyerName,
                        c.CaseCreator,
                    }).ToList();

                if (model.Count > 0)
                {
                    lawSuitsGrid.DataSource = model;
                    lawSuitsGrid.Refresh();
                    lawSuitsGrid.Columns[0].HeaderText = "م";
                    lawSuitsGrid.Columns[0].Width = 15;
                    lawSuitsGrid.Columns[1].HeaderText = "رقم الفاتورة";
                    lawSuitsGrid.Columns[2].HeaderText = "الإسم";
                    lawSuitsGrid.Columns[3].HeaderText = "رقم القضية";
                    lawSuitsGrid.Columns[4].HeaderText = "رقم الحصر";
                    lawSuitsGrid.Columns[5].HeaderText = "الحكم";
                    lawSuitsGrid.Columns[6].HeaderText = "المحامي";
                    lawSuitsGrid.Columns[7].HeaderText = " الشاكي";
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void name_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
        }

        private void date_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
        }

        private void id_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search.PerformClick(); }
        }

        private void id_search_MouseClick(object sender, MouseEventArgs e)
        {
            id_search.Select(0, id_search.Text.Length);

        }

        private void name_search_TextChanged(object sender, EventArgs e)
        {


        }

        private void name_search_SelectedIndexChanged(object sender, EventArgs e)
        {

            name_search.Text = (string)name_search.Items[name_search.SelectedIndex];

        }

        private void AddLawSuitButtonClick(object sender, EventArgs e)
        {
            var addLawSuitForm = new AddLawSuitForm(0);

            var result = addLawSuitForm.ShowDialog();

            if (result == DialogResult.OK)
                RefreshData(sender, e);
        }

        private void LawSuitsGridDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = lawSuitsGrid.SelectedRows[0];
            var id = item.Cells[0].Value.ToString();

            if (int.TryParse(id, out _) && int.Parse(id) != 0)
            {
                var editForm = new EditLawSuitForm(int.Parse(id));
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                    RefreshData(sender, e);
            }
        }

        public void RefreshData(object sender, EventArgs e)
        {
            if (searchAll)
                SearchAll_Click(sender, e);
        }
    }

}