using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Carproject.Entities;

namespace Carproject.UI.Forms
{
    public partial class AddLawSuitForm : Form
    {
        private readonly int _billId;
        private List<BillViewModel> _bills;

        public AddLawSuitForm(int billId)
        {
            _billId = billId;
            InitializeComponent();
            PopulateBills();
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(billIdTextBox.Text))
                throw new ArgumentException("رقم الفاتورة خاطئ");
        }

        public void PopulateBills()
        {
            using var context = new ElbashacarsContext();

            _bills = context.Bills.Select(c => new BillViewModel() { BillId = c.Id, Name = c.BuyerName }).ToList();

            billIdTextBox.Items.AddRange(_bills.Select(c => c.BillId.ToString()).ToArray());

            if (_billId != 0)
            {
                billIdTextBox.SelectedItem = _billId;
            }
        }

        private void AddLawSuitButtonClick(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                var billId = int.Parse(billIdTextBox.Text);

                using var context = new ElbashacarsContext();

                if (!context.Bills.Any(c => c.Id == billId))
                    throw new ArgumentException("رقم الفاتورة غير موجود");

                var lawSuit = new LawSuit()
                {
                    BillId = billId,
                    CaseCreator = caseCreatorTextBox.Text,
                    CaseNumber = caseNumberTextBox.Text,
                    Guarantor = gurantorTextBox.Text,
                    InventoryNumber = inventoryNumberTextBox.Text,
                    Judgement = judgmentTextBox.Text,
                    LawyerName = lawyerNameTextBox.Text,
                    OpposingSessionDate = opposingSessionTextBox.Text,
                    OpposingSessionJudgement = opposingJudgmentTextBox.Text,
                    Notes = notesTextBox.Text
                };

                context.LawSuits.Add(lawSuit);
                context.SaveChanges();

                ClearInputs();

                MessageBox.Show("تم إضافة الشكوى");

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void ClearInputs()
        {
            billIdTextBox.Text = string.Empty;
            caseCreatorTextBox.Text = string.Empty;
            caseNumberTextBox.Text = string.Empty;
            gurantorTextBox.Text = string.Empty;
            inventoryNumberTextBox.Text = string.Empty;
            judgmentTextBox.Text = string.Empty;
            lawyerNameTextBox.Text = string.Empty;
            opposingSessionTextBox.Text = string.Empty;
            opposingJudgmentTextBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;
        }

        private void AddLawSuitForm_Load(object sender, EventArgs e)
        {

        }

        private void billIdTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTextBox.Text = _bills.First(c => c.BillId == int.Parse(billIdTextBox.SelectedItem.ToString())).Name;
        }
    }

    class BillViewModel
    {
        public int BillId { get; set; }

        public string Name { get; set; }
    }
}
