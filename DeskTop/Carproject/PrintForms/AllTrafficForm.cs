using System.Windows.Forms;

namespace Carproject.PrintForms
{
    public partial class AllTrafficForm : Form
    {
        public AllTrafficForm()
        {
            InitializeComponent();
        }

        private void restrict_button_Click(object sender, System.EventArgs e)
        {

        }

        public void Print(DocumentType documentType)
        {
            var printViewModel = new PrintViewModel()
            {
                BuyerName = buyerNameTextBox.Text,
                CreationDate = creationDateTextBox.Text,
                CarColor = colorTextBox.Text,
                BuyerAddress = buyerAddressTextBox.Text,
                CarMark = carMarkTextBox.Text,
                CarModel = modelTextBox.Text,
                CarType = carTypeTextBox.Text,
                CarVersion = carVersionTextBox.Text,
                Cargo = cargoTextBox.Text,
                CommercialNumber = "65464664645",
                LiterCapacity = capacityTextBox.Text,
                PlateNumber = carNumberTextBox.Text,
                SellingDate = sellingDateTextBox.Text,
                Shape = shapeTextBox.Text,
                TaxRegisterNumber = "646546321654",
                ShasehNumber = shasehTextBox.Text,
                TrafficAdminstration = trafficTextBox.Text,
                MotorNumber = motorTextBox.Text,
                PassengersNumber = passangersTextBox.Text,
                SocialSecurityNumber = nationalIdTextBox.Text,
                TrafficNumber = "118",
            };

            switch (documentType)
            {
                case DocumentType.Selling:
                    break;
                case DocumentType.SellingWithOwnership:
                    break;
                case DocumentType.Quittance:
                    break;
                case DocumentType.AnnualRenewal:
                    break;
            }
        }

        private void groupBox3_Enter(object sender, System.EventArgs e)
        {

        }
    }
}



