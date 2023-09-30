using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Carproject.Entities;

namespace Carproject.UI.Forms
{
    public partial class EditLawSuitForm : Form
    {
        private readonly int _lawSuitId;
        private List<BillViewModel> _bills;
        private LawSuit lawSuit;

        public EditLawSuitForm(int lawSuitId)
        {
            _lawSuitId = lawSuitId;
            InitializeComponent();
            PopulateInputs();
        }

        public void PopulateInputs()
        {
            using var context = new ElbashacarsContext();

            lawSuit = context.LawSuits.Include(c => c.Bill).FirstOrDefault(c => c.Id == _lawSuitId);

            if (lawSuit == null)
            {
                MessageBox.Show("تعذر العثور على الشكوى");
                editLawSuitButton.Enabled = false;
            }
            else
            {
                nameTextBox.Text = lawSuit.Bill.BuyerName;
                billIdTextBox.Text = lawSuit.BillId.ToString();
                caseCreatorTextBox.Text = lawSuit.CaseCreator;
                caseNumberTextBox.Text = lawSuit.CaseNumber;
                gurantorTextBox.Text = lawSuit.Guarantor;
                inventoryNumberTextBox.Text = lawSuit.InventoryNumber;
                judgmentTextBox.Text = lawSuit.Judgement;
                lawyerNameTextBox.Text = lawSuit.LawyerName;
                opposingSessionTextBox.Text = lawSuit.OpposingSessionDate;
                opposingJudgmentTextBox.Text = lawSuit.OpposingSessionJudgement;
                notesTextBox.Text = lawSuit.Notes;
            }
        }

        private void EditLawSuitButtonClick(object sender, EventArgs e)
        {
            try
            {
                using var context = new ElbashacarsContext();

                lawSuit.CaseCreator = caseCreatorTextBox.Text;
                lawSuit.CaseNumber = caseNumberTextBox.Text;
                lawSuit.Guarantor = gurantorTextBox.Text;
                lawSuit.InventoryNumber = inventoryNumberTextBox.Text;
                lawSuit.Judgement = judgmentTextBox.Text;
                lawSuit.LawyerName = lawyerNameTextBox.Text;
                lawSuit.OpposingSessionDate = opposingSessionTextBox.Text;
                lawSuit.OpposingSessionJudgement = opposingJudgmentTextBox.Text;
                lawSuit.Notes = notesTextBox.Text;

                context.LawSuits.AddOrUpdate(lawSuit);
                context.SaveChanges();

                MessageBox.Show("تم تعديل الشكوى");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new ElbashacarsContext();

            var confirmResult = MessageBox.Show("هل انت متأكد من مسح الشكوى؟", "مسح",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var lawSuitToRemove = context.LawSuits.First(c => c.Id == _lawSuitId);
                context.LawSuits.Remove(lawSuitToRemove);
                context.SaveChanges();
                MessageBox.Show("تم المسح");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
