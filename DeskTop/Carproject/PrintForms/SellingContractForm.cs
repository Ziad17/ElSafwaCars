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

using System.Drawing.Drawing2D;

namespace Carproject.PrintForms
{
    public partial class SellingContractForm : Form
    {
        private string firstTerm = "يقر البائع بأن السيارة المذكورة بعاليه ملكه وليس عليها أي ديون أو أقساط أو قرارات أو رسوم جمركية وحجوزات تعوق نقل ملكيتها للمشتري";
        private string secondTerm = "يقر البائع بأن جميع البيانات الواردة بهذه السيارة صحيحة وعلى مسؤليته الشخصية";       
        private string thirdTerm = "يقر البائع بأنه مسئول عن سيارته حتى تحرير عقد البيع من مخالفات وضرائب وحوادث وما شبه ذلك دون أدنى مسؤلية على المشتري";
        private string forthTerm = "يلتزم البائع بتسليم المشتري ساعة التوثيق شهادةالمخالفات والبيانات الخاصة بالسيارة محل هذا العقد";
        private string fifthTerm = "يقر المشتري بأنه عاين السيارة المعاينة التامة النافية للجهالة وقبلها بحالتها التي عليها وأصبح مسؤلا عنها مع ملاحظة أن لقلم المرور المختص الحق في مطالبته بكل ما يترتب على السيارة دون الرجوع إلى المالك الأصلي إبتداء من وقت إستلامها ";
        private string sixthTerm = "";
        private string seventhTerm = "";
        private string eighthTerm = "بعد مرور 24 ساعة من توقيع هذا العقد ليس لأي من الطرفين الحق في التراجع";
        private string ninethTerm = "أن كانت السيارة نمر استغنى أو مسروقة أو مسلمة تلزم الباثع بالشرط الجزائي";
        private string tenthTerm = "";// check if it's off or not 
        private string elevenTerm = "";
        private string twelveTerm = "لا يحق للمشتري مطالبة البائع بأي إلتزامات مادية بعد هذا التاريخ وكذلك لا يعتبره مدنيا ولا جنائيا";
        private string threeteenTerm = "";


        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        
        public SellingContractForm()

        {

        
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
   

         //   cboCurrency.DataSource = currencies;

        //    cboCurrency_DropDownClosed(null, null);


            InitializeComponent();
            refresh_cars(re_number);
            paid_price_number_tx.Maximum = total_price_number_tx.Value;
            populateInfo();
         //   button1_Click(new Object(),new EventArgs());




        }

        private void checkIFExistsThenAdd(ComboBox box, String item)
        {
          

                if (!box.Items.Contains(item))
                {
                    box.Items.Add(item);
                }
            
        }
        private void populateInfo()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());

            con.Open();
            string CommandText1 = "SELECT * FROM selling_contract;";
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = CommandText1;
            
           

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {


                checkIFExistsThenAdd(buyer_name_tx, rd.GetValue(1).ToString());
                checkIFExistsThenAdd(buyer_card_tx, rd.GetValue(2).ToString());
                checkIFExistsThenAdd(buyer_address_tx, rd.GetValue(3).ToString());
                checkIFExistsThenAdd(seller_name_tx, rd.GetValue(4).ToString());
                checkIFExistsThenAdd(seller_card_tx, rd.GetValue(5).ToString());
                checkIFExistsThenAdd(seller_address_tx, rd.GetValue(6).ToString());
                checkIFExistsThenAdd(re_model, rd.GetValue(8).ToString());
                checkIFExistsThenAdd(re_mark, rd.GetValue(9).ToString());
                checkIFExistsThenAdd(re_shaseh, rd.GetValue(10).ToString());
                checkIFExistsThenAdd(re_motor, rd.GetValue(11).ToString());
                checkIFExistsThenAdd(re_kind, rd.GetValue(12).ToString());
                checkIFExistsThenAdd(re_color, rd.GetValue(13).ToString());
                checkIFExistsThenAdd(re_shape, rd.GetValue(14).ToString());
                checkIFExistsThenAdd(penalty_tx, rd.GetValue(19).ToString());



            }
            con.Close();

            buyer_name_tx.Refresh();
            buyer_card_tx.Refresh();
            buyer_address_tx.Refresh();
            seller_name_tx.Refresh();
            seller_card_tx.Refresh();
            buyer_name_tx.Refresh();
            seller_address_tx.Refresh();
            re_model.Refresh();
            re_mark.Refresh();
            re_shaseh.Refresh();
            re_motor.Refresh();
            re_kind.Refresh();
            re_color.Refresh();
            re_shape.Refresh();
            penalty_tx.Refresh();





       
        }
        public void refresh_cars(ComboBox combobox)
        {
            try
            {

                combobox.Items.Clear();
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT cars.Car_Number FROM cars WHERE cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                List<string> arr = new List<string>() { };

                MySqlDataReader rd = cmd1.ExecuteReader();

                while (rd.Read())
                {

                    combobox.Items.Add(rd.GetValue(0).ToString());

                }

                combobox.Refresh();
                con.Close();
            }
            catch (MySqlException ee) { MessageBox.Show("خطأ في السيرفر"); }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SellingContractForm_Load(object sender, EventArgs e)
        {

        }

        private void re_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "SELECT cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number FROM cars WHERE cars.Car_Number=@number AND cars.registered=true AND cars.Sold=false AND LENGTH(cars.Car_Number) >=1;";
                cmd1.Parameters.AddWithValue("@number", re_number.Items[re_number.SelectedIndex].ToString());
                //  MessageBox.Show(re_number.Items[re_number.SelectedIndex].ToString());
                MySqlDataReader rd = cmd1.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    re_model.Text = rd[0].ToString();
                    re_motor.Text = rd[1].ToString();
                    re_mark.Text = rd[2].ToString();
                    re_shaseh.Text = rd[3].ToString();
                     ;


                }
                else
                {
                    MessageBox.Show("خطأ");
                }
                con.Close();

            }
            catch (MySqlException ee)
            {
                MessageBox.Show("خطأ في السيرفر");
            }
            catch (Exception eee)
            {
                MessageBox.Show("خطأ");

            }
        }
        int paper_width = 800;
        int paper_height = 1170;
        int upper_margin = 0;
        int left_margin = 5;
        int bottom_margin = 20;
        int right_margin = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {




                MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());

                con.Open();
                string CommandText1 = "INSERT INTO selling_contract(Buyer_name,Buyer_card,Buyer_address, Seller_name ,Seller_card ,Seller_address, Car_number , Car_model ,Car_mark ,Car_shaseh ,Car_motor ,Car_kind ,Car_color ,Car_shape ,Total_price, Paid_price ,Remain_price ,Daily_rent ,Penalty_clause ,Auth_date ,Created_date, Created_time)" +
                    "VALUES(@Buyer_name,@Buyer_card,@Buyer_address, @Seller_name ,@Seller_card ,@Seller_address, @Car_number , @Car_model ,@Car_mark ,@Car_shaseh ,@Car_motor ,@Car_kind ,@Car_color ,@Car_shape ,@Total_price, @Paid_price ,@Remain_price ,@Daily_rent ,@Penalty_clause ,@Auth_date ,@Created_date, @Created_time)";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = CommandText1;
                cmd.Parameters.AddWithValue("@Buyer_name", buyer_name_tx.Text);
                cmd.Parameters.AddWithValue("@Buyer_card", buyer_card_tx.Text);
                cmd.Parameters.AddWithValue("@Buyer_address", buyer_address_tx.Text);
                cmd.Parameters.AddWithValue("@Seller_name", seller_name_tx.Text);
                cmd.Parameters.AddWithValue("@Seller_card", seller_card_tx.Text);
                cmd.Parameters.AddWithValue("@Seller_address", seller_address_tx.Text);
                cmd.Parameters.AddWithValue("@Car_number", re_number.Text);
                cmd.Parameters.AddWithValue("@Car_model", re_model.Text);
                cmd.Parameters.AddWithValue("@Car_mark", re_mark.Text);
                cmd.Parameters.AddWithValue("@Car_shaseh", re_shaseh.Text);
                cmd.Parameters.AddWithValue("@Car_motor", re_motor.Text);
                cmd.Parameters.AddWithValue("@Car_kind", re_kind.Text);
                cmd.Parameters.AddWithValue("@Car_color", re_color.Text);
                cmd.Parameters.AddWithValue("@Car_shape", re_shape.Text);
                cmd.Parameters.AddWithValue("@Total_price", total_price_number_tx.Value);
                cmd.Parameters.AddWithValue("@Paid_price", paid_price_number_tx.Value);
                cmd.Parameters.AddWithValue("@Remain_price", remai_price_number_tx.Value);
                cmd.Parameters.AddWithValue("@Daily_rent", daily_rent_tx.Value);
                cmd.Parameters.AddWithValue("@Penalty_clause", penalty_tx.Text);
                cmd.Parameters.AddWithValue("@Auth_date", auth_date_tx.Value);
                cmd.Parameters.AddWithValue("@Created_date", date_tx.Value);
                cmd.Parameters.AddWithValue("@Created_time", time_tx.Value);


                cmd.ExecuteNonQuery();
                con.Close();


                printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);
              //  printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

                printPreviewDialog1.Document = printDocument1;

                 printDocument1.Print();
                //printPreviewDialog1.ShowDialog();


            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الطباعة");

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try {
             //   MessageBox.Show("printing");
                string seller_name = seller_name_tx.Text;
                string seller_card = seller_card_tx.Text;
                string seller_address = seller_address_tx.Text;
                string buyer_name = buyer_name_tx.Text;
                string buyer_card = buyer_card_tx.Text;
                string buyer_address = buyer_address_tx.Text;
                string car_number = re_number.Text;
                string car_motor = re_motor.Text;
                string car_mark = re_mark.Text;
                string car_model = re_model.Text;
                string car_shaseh = re_shaseh.Text;
                string car_color = re_color.Text;
                string car_shape = re_shape.Text;
                string car_kind = re_kind.Text;
                string total_price_number = ValidatingFunctions.getDotsIfNumberEqualZero(total_price_number_tx.Value.ToString(),10);
                string total_price_text = total_price_ext_tx.Text;
                string paid_price_number = ValidatingFunctions.getDotsIfNumberEqualZero(paid_price_number_tx.Value.ToString(),10);
                string paid_price_text = paid_price_text_tx.Text;
                string remain_price_number = ValidatingFunctions.getDotsIfNumberEqualZero(remai_price_number_tx.Value.ToString(), 20);
                string remain_price_text = remain_price_text_tx.Text;
                string remain_price = remain_price_tx.Text;
                string penalty_claue = penalty_tx.Text.ToString();
                string daily_rent = ValidatingFunctions.getDotsIfNumberEqualZero(daily_rent_tx.Value.ToString(),20);
                string time = time_tx.Value.ToShortTimeString();
                string date = String.Format("{0:yyyy/M/d}", date_tx.Value);
                string auth_date = String.Format("{0:yyyy/M/d}", auth_date_tx.Value);
                string auth_Day=auth_date_tx.Value.ToString("dddd");
                if (!checkBox_time.Checked)
                { time = ValidatingFunctions.getDotsIfTextEmpty("", 20); }
                if (!checkBox_date.Checked)
                { date = (ValidatingFunctions.getEmptyDate()); }
                if (!checkBox_auth.Checked)
                { auth_date=(ValidatingFunctions.getEmptyDate());
                auth_Day = ValidatingFunctions.getDotsIfTextEmpty("", 30);
                }

                string firstTerm = "يقر البائع بأن السيارة المذكورة بعاليه ملكه وليس عليها أي ديون أو أقساط أو قرارات أو رسوم جمركية وحجوزات تعوق نقل ملكيتها للمشتري";
                string secondTerm = "يقر البائع بأن جميع البيانات الواردة بهذه السيارة صحيحة وعلى مسؤليته الشخصية";
                string thirdTerm = "يقر البائع بأنه مسئول عن سيارته حتى تحرير عقد البيع من مخالفات وضرائب وحوادث وما شبه ذلك دون أدنى مسؤلية على المشتري";
                string forthTerm = "يلتزم البائع بتسليم المشتري ساعة التوثيق شهادة المخالفات والبيانات الخاصة بالسيارة محل هذا العقد";
                string fifthTerm = "يقر المشتري بأنه عاين السيارة المعاينة التامة النافية للجهالة وقبلها بحالتها التي عليها وأصبح مسؤلا عنها مع ملاحظة أن لقلم المرور المختص الحق في مطالبته بكل ما يترتب على السيارة دون الرجوع إلى المالك الأصلي إبتداء من وقت إستلامها ";
                string sixthTerm_1="إتفق الطرفان على التوثيق في الشهر العقاري يوم: ";
                string sixthTerm_2 = "الموافق: ";
                
                string sixthTerm = sixthTerm_1+auth_Day+" "+sixthTerm_2+auth_date;
                string seventhTerm_1 = "من يتراجع من الطرفين أو يخل ببند من بنود العقد يدفع ";
                string seventhTerm_2 = "جنيه للطرف الاخر كشرط جزائي ";
                
                string seventhTerm = seventhTerm_1+ValidatingFunctions.getDotsIfTextEmpty(penalty_claue,50)+" "+seventhTerm_2;
                string eighthTerm = "بعد مرور 24 ساعة من توقيع هذا العقد ليس لأي من الطرفين الحق في التراجع";
                string ninethTerm = "أن كانت السيارة نمر استغنى أو مسروقة أو مسلمة تلزم البائع بالشرط الجزائي";
                string tenthTerm ="يعتبر العقد لاغي من بعد تاريخ تجديد ميعاد التاريخ المسجل أو التوكيل  ";
                string elevenTerm = "لا يحق للمشتري مطالبة البائع بأي إلتزامات مادية بعد هذا التاريخ وكذلك لا يعتبره مدنيا ولا جنائيا";
                string twelveTerm1 = "في حالة رجوع السيارة من المشتري إلى البائع يلتزم المشتري بدفع الشرط الجزائي المنصوص عليه في العقد بالإضافة إلى";
                string twleveTerm2 = " جنيه عن كل يوم كانت السيارة بحوزته";
                string twleveTerm = twelveTerm1 +daily_rent.ToString() + twleveTerm2;


                Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
                Font builtInFont = new Font("Times New Roman", 13, FontStyle.Bold);
                Font conditionsFont = new Font("Arial", 13, FontStyle.Bold);

                //         Font filledInFont = new Font();
                StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                format.Trimming = StringTrimming.Word;


                 
                float half_x_coord = (paper_width - left_margin - right_margin) / 2;
                float default_line_space = 3.0f;

                float tiny_line_space = 3.0f;
                float normal_box_height = 23.0f;
                float large_box_height = 40.0f;

                float line_y_cursor = upper_margin;




                //LOGO

                Rectangle rect_all_page = new Rectangle(3, 3, paper_width - 3, paper_height - 3);
                Pen pen = new Pen(Color.Black, 2);
                pen.Alignment = PenAlignment.Inset; //<-- this
                e.Graphics.DrawRectangle(pen, rect_all_page);



                Image logo = new Bitmap(Carproject.Properties.Resources.pngegg); 
                RectangleF rect_logo = new RectangleF((paper_width/2)-50, line_y_cursor, 100, 100);
                e.Graphics.DrawImage(logo,


rect_logo
);
                line_y_cursor += 30 + default_line_space;


                String title = "عقد بيع سيارة";
                StringFormat format1 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                format1.LineAlignment = StringAlignment.Center;
                format1.Alignment = StringAlignment.Center;
                RectangleF rect_title = new RectangleF(0, line_y_cursor, paper_width, 100);
                e.Graphics.DrawString(title,
                    headerFont,
                    new SolidBrush(Color.Black),

rect_title, format1
);
                line_y_cursor += 100 + default_line_space;



//                //first  y line
                
                RectangleF rect_line1 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                RectangleF rect_line1_2 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);


                string line1_1 = "أنه في يوم الموافق: ";
                string line1_2 = "الساعة: ";
                string first_line_1 = line1_1+date;
                string first_line_2 = line1_2+time;

                e.Graphics.DrawString(first_line_1,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line1, format
                );
                e.Graphics.DrawString(first_line_2,
               builtInFont,
               new SolidBrush(Color.Black),
               rect_line1_2, format
               );

                line_y_cursor += normal_box_height + default_line_space;
                
//                //second y line
                string line2_1 = "قد باع السيد/ ";
                string line2_2 = "بطاقة رقم: ";



                RectangleF rect_line2 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                RectangleF rect_line2_2 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);
                string second_line_1 = getFormattedString(line2_1, seller_name, rect_line2, format, builtInFont, e);
                string second_line_2 = getFormattedString(line2_2, seller_card, rect_line2_2, format, builtInFont,e);


                e.Graphics.DrawString(second_line_1,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line2, format
                );

                e.Graphics.DrawString(second_line_2,
               builtInFont,
               new SolidBrush(Color.Black),
               rect_line2_2, format
               );

                line_y_cursor += normal_box_height + default_line_space;

                // 3rd y line
                string line3 = "المقيم: ";
                RectangleF rect_line3 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                string line_3rd = getFormattedString(line3,  seller_address, rect_line3, format, builtInFont, e);

                e.Graphics.DrawString(line_3rd,
             builtInFont,
             new SolidBrush(Color.Black),
             rect_line3, format
             );

                line_y_cursor += large_box_height + default_line_space;

                //new line 


                string line4_1 = "إلى السيد/ ";
                string line4_2 = "بطاقة رقم: ";


                RectangleF rect_line4 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                RectangleF rect_line4_2 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);
                string line_4th_1 = getFormattedString(line4_1, buyer_name, rect_line4, format, builtInFont, e);
                string line_4th_2 = getFormattedString(line4_2, buyer_card, rect_line4_2, format, builtInFont, e);


                e.Graphics.DrawString(line_4th_1,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line4, format
                );

                e.Graphics.DrawString(line_4th_2,
               builtInFont,
               new SolidBrush(Color.Black),
               rect_line4_2, format
               );

                line_y_cursor += normal_box_height + default_line_space;


                //new line 

                string line5 = "المقيم: ";
                RectangleF rect_line5 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                string line_5th = getFormattedString(line5, buyer_address, rect_line5, format, builtInFont, e);

                e.Graphics.DrawString(line_5th,
             builtInFont,
             new SolidBrush(Color.Black),
             rect_line5, format
             );

                line_y_cursor += normal_box_height + default_line_space;

                //new line 

                string line6_1 = "رقم السيارة: ";
                string line6_2 = "موتور: ";
                string line6_3 = "شاسيه: ";
                string line6_4 = "موديل: ";


                RectangleF rect_line6_4 = new RectangleF(0, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                RectangleF rect_line6_3 = new RectangleF((paper_width - left_margin - right_margin) / 4, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                RectangleF rect_line6_2 = new RectangleF((paper_width - left_margin - right_margin) / 2, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                RectangleF rect_line6_1 = new RectangleF((paper_width - left_margin - right_margin) / 4 * 3, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);

                string line_6th_1 = getFormattedString(line6_1, car_number, rect_line6_1, format, builtInFont, e);
                string line_6th_2 = getFormattedString(line6_2, car_motor, rect_line6_2, format, builtInFont, e);
                string line_6th_3 = getFormattedString(line6_3, car_shaseh, rect_line6_3, format, builtInFont, e);
                string line_6th_4 = getFormattedString(line6_4, car_model, rect_line6_4, format, builtInFont, e);
                e.Graphics.DrawString(line_6th_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line6_1, format
            );

                e.Graphics.DrawString(line_6th_2,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line6_2, format
            );

                e.Graphics.DrawString(line_6th_3,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line6_3, format
            );

                e.Graphics.DrawString(line_6th_4,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line6_4, format
            );

                line_y_cursor += normal_box_height + default_line_space;

                //new line 

                string line7_1 = "نقل أجرة ملاكي: ";
                string line7_2 = "ماركة: ";
                string line7_3 = "اللون: ";
                string line7_4 = "الشكل: ";


                RectangleF rect_line7_4 = new RectangleF(0, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                RectangleF rect_line7_3 = new RectangleF((paper_width - left_margin - right_margin) / 4, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                RectangleF rect_line7_2 = new RectangleF((paper_width - left_margin - right_margin) / 2, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                RectangleF rect_line7_1 = new RectangleF((paper_width - left_margin - right_margin) / 4 * 3, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);

                string line_7th_1 = getFormattedString(line7_1, car_kind, rect_line7_1, format, builtInFont, e);
                string line_7th_2 = getFormattedString(line7_2, car_mark, rect_line7_2, format, builtInFont, e);
                string line_7th_3 = getFormattedString(line7_3, car_color, rect_line7_3, format, builtInFont, e);
                string line_7th_4 = getFormattedString(line7_4, car_shape, rect_line7_4, format, builtInFont, e);
                e.Graphics.DrawString(line_7th_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line7_1, format
            );

                e.Graphics.DrawString(line_7th_2,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line7_2, format
            );

                e.Graphics.DrawString(line_7th_3,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line7_3, format
            );

                e.Graphics.DrawString(line_7th_4,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line7_4, format
            );

                line_y_cursor += normal_box_height + default_line_space;

                //new line 

                string line8_1 = "وذلك بمبلغ وقدره:  ";
                string line8_2 = "فقط: ";

                RectangleF rect_line8_2 = new RectangleF(0, line_y_cursor, (paper_width - left_margin - right_margin) / 4 * 3, normal_box_height);
                RectangleF rect_line8_1 = new RectangleF((paper_width - left_margin - right_margin) / 4 * 3, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                string line_8th_1 = getFormattedString(line8_1, total_price_number, rect_line8_1,format,builtInFont,e);
                string line_8th_2 = getFormattedString(line8_2,  total_price_text, rect_line8_2,format,builtInFont,e);
                e.Graphics.DrawString(line_8th_1,
       builtInFont,
       new SolidBrush(Color.Black),
       rect_line8_1, format
       );

                e.Graphics.DrawString(line_8th_2,
       builtInFont,
       new SolidBrush(Color.Black),
       rect_line8_2, format
       );
                line_y_cursor += normal_box_height + default_line_space;

                //new line 


                string line9_1 = "دفع منها المشتري: ";
                string line9_2 = "فقط: ";
              
                RectangleF rect_line9_2 = new RectangleF(0, line_y_cursor, (paper_width - left_margin - right_margin) / 4 * 3, normal_box_height);
                RectangleF rect_line9_1 = new RectangleF((paper_width - left_margin - right_margin) / 4 * 3, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                string line_9th_1 = getFormattedString(line9_1,  paid_price_number, rect_line9_1,format,builtInFont,e);
                ;
                string line_9th_2 = getFormattedString(line9_2,  paid_price_text,rect_line9_2 ,format,builtInFont,e);
                e.Graphics.DrawString(line_9th_1,
       builtInFont,
       new SolidBrush(Color.Black),
       rect_line9_1, format
       );

                e.Graphics.DrawString(line_9th_2,
       builtInFont,
       new SolidBrush(Color.Black),
       rect_line9_2, format
       );
                line_y_cursor += normal_box_height + default_line_space;

                string re_line9_1 = "والباقي وقدره:  ";
                string re_line9_2 = "فقط: ";

                RectangleF re_rect_line9_2 = new RectangleF(0, line_y_cursor, (paper_width - left_margin - right_margin) / 4 * 3, normal_box_height);
                RectangleF re_rect_line9_1 = new RectangleF((paper_width - left_margin - right_margin) / 4 * 3, line_y_cursor, (paper_width - left_margin - right_margin) / 4, normal_box_height);
                string re_line_9th_1 = getFormattedString(re_line9_1, remain_price_number, re_rect_line9_1, format, builtInFont, e);
                ;
                string re_line_9th_2 = getFormattedString(re_line9_2, remain_price_text, re_rect_line9_2, format, builtInFont, e);
                e.Graphics.DrawString(re_line_9th_1,
       builtInFont,
       new SolidBrush(Color.Black),
       re_rect_line9_1, format
       );

                e.Graphics.DrawString(re_line_9th_2,
       builtInFont,
       new SolidBrush(Color.Black),
       re_rect_line9_2, format
       );
                line_y_cursor += normal_box_height + default_line_space;



                //new line 


                string line10 = "ويحصل كالأتي: ";
                RectangleF rect_line10 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, large_box_height+10);
                string line_10th = getFormattedString(line10, remain_price,rect_line10,format,builtInFont,e);
               
                e.Graphics.DrawString(line_10th,
    builtInFont,
    new SolidBrush(Color.Black),
    rect_line10, format
    );


                e.Graphics.DrawString(line_10th,
builtInFont,
new SolidBrush(Color.Black),
rect_line10, format
);

                line_y_cursor += large_box_height + default_line_space+20;
                int lineOrder = 1;

                //new line 

                string line11 = lineOrder+"- " + firstTerm;
                RectangleF rect_line11 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, large_box_height);
                e.Graphics.DrawString(line11,
conditionsFont,
new SolidBrush(Color.Black),
rect_line11, format
);
                lineOrder += 1;
                line_y_cursor += large_box_height + default_line_space;



                //new line 

                string line12 = lineOrder+"- " + secondTerm;

                RectangleF rect_line12 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin,normal_box_height);
                e.Graphics.DrawString(line12,
conditionsFont,
new SolidBrush(Color.Black),
rect_line12, format
);
                lineOrder += 1;
                line_y_cursor += normal_box_height + default_line_space;


                //new line 

                string line13 = lineOrder+"- " + thirdTerm;

                RectangleF rect_line13 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, large_box_height);
                e.Graphics.DrawString(line13,
conditionsFont,
new SolidBrush(Color.Black),
rect_line13, format
);
                lineOrder += 1;
                line_y_cursor += large_box_height + default_line_space;


                //new line 

                string line14 = lineOrder+"- " + forthTerm;

                RectangleF rect_line14 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                e.Graphics.DrawString(line14,
conditionsFont,
new SolidBrush(Color.Black),
rect_line14, format
);
                lineOrder += 1;

                line_y_cursor += normal_box_height + default_line_space;

                //new line 

                string line15 = lineOrder+"- " + fifthTerm;

                RectangleF rect_line15 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, large_box_height);
                e.Graphics.DrawString(line15,
conditionsFont,
new SolidBrush(Color.Black),
rect_line15, format
);
                lineOrder += 1;

                line_y_cursor += large_box_height + default_line_space;

                //new line 
                if (checkBox2.Checked)
                {
                    string line16 = lineOrder + "- " + sixthTerm;

                    RectangleF rect_line16 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                    e.Graphics.DrawString(line16,
    conditionsFont,
    new SolidBrush(Color.Black),
    rect_line16, format
    );
                    lineOrder += 1;

                    line_y_cursor += normal_box_height + default_line_space;
                }
                //new line 

                string line17 = lineOrder+"- " + seventhTerm;

                RectangleF rect_line17 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, large_box_height);
                e.Graphics.DrawString(line17,
conditionsFont,
new SolidBrush(Color.Black),
rect_line17, format
);
                lineOrder += 1;

                line_y_cursor += large_box_height + default_line_space;



                //new line 

                string line18 = lineOrder+"- " + eighthTerm;

                RectangleF rect_line18 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                e.Graphics.DrawString(line18,
conditionsFont,
new SolidBrush(Color.Black),
rect_line18, format
);
                lineOrder += 1;

                line_y_cursor += normal_box_height + default_line_space;


                //new line 

                string line19 = lineOrder+"- " + ninethTerm;

                RectangleF rect_line19 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                e.Graphics.DrawString(line19,
conditionsFont,
new SolidBrush(Color.Black),
rect_line19, format
);
                lineOrder += 1;

                line_y_cursor += normal_box_height + default_line_space;


                //new line 

                string line20 = lineOrder+"- " + tenthTerm;

                RectangleF rect_line20 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                e.Graphics.DrawString(line20,
conditionsFont,
new SolidBrush(Color.Black),
rect_line20, format
);
                lineOrder += 1;

                line_y_cursor += normal_box_height + default_line_space;


                //new line 

                string line21 = lineOrder+"- " + elevenTerm;

                RectangleF rect_line21 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                e.Graphics.DrawString(line21,
conditionsFont,
new SolidBrush(Color.Black),
rect_line21, format
);
                lineOrder += 1;

                line_y_cursor += normal_box_height + default_line_space;



                //new line 
                string line22 = lineOrder+"- " + twelveTerm1 + ValidatingFunctions.getDotsIfTextEmpty(daily_rent.ToString(), 20) + twleveTerm2; ;

                RectangleF rect_line22 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, large_box_height);
                e.Graphics.DrawString(line22,
conditionsFont,
new SolidBrush(Color.Black),
rect_line22, format
);
                lineOrder += 1;
                line_y_cursor += large_box_height+10 + default_line_space;







                //23th line 
                string line23_1 = "المشتري"; ;

                RectangleF rect_line23_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);
                e.Graphics.DrawString(line23_1,
conditionsFont,
new SolidBrush(Color.Black),
rect_line23_1, format1
);


                string line23_2 = "البائع"; ;

                RectangleF rect_line23_2 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                e.Graphics.DrawString(line23_2,
conditionsFont,
new SolidBrush(Color.Black),
rect_line23_2, format1
);
 
           
                line_y_cursor += normal_box_height + default_line_space;

                string line24_1 = ValidatingFunctions.getDotsIfTextEmpty("",50); ;

                RectangleF rect_line24_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);
                e.Graphics.DrawString(line24_1,
conditionsFont,
new SolidBrush(Color.Black),
rect_line24_1, format1
);


                string line24_2 = ValidatingFunctions.getDotsIfTextEmpty("", 50); ;


                RectangleF rect_line24_2 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                e.Graphics.DrawString(line24_2,
conditionsFont,
new SolidBrush(Color.Black),
rect_line24_2, format1

);

                line_y_cursor += normal_box_height + default_line_space;

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                RectangleF divider_rect = new RectangleF(0, line_y_cursor, paper_width, normal_box_height);

                string divider = "";
                bool fit=false;
                while (!fit)
                {
                    if (e.Graphics.MeasureString(divider, builtInFont).Width < divider_rect.Size.Width)
                    {
                        divider += "-";
                    }
                    else { fit = true; }
                }

                line_y_cursor+=10;
                e.Graphics.DrawString(divider,
conditionsFont,
new SolidBrush(Color.Black),
divider_rect, format1

);

                String title_recieve = "إقرار إستلام سيارة";

                RectangleF rect_title_recieve = new RectangleF(0, line_y_cursor, paper_width, 70);
                e.Graphics.DrawString(title_recieve,
                    headerFont,
                    new SolidBrush(Color.Black),

rect_title_recieve, format1
);
                line_y_cursor += 70 + default_line_space;




                string receieve_name = "";
                string receieve_card = "";
                string receieve_address = "";
                string receieve_car = "";
                string receieve_time = "";
                string receieve_date = "";

                if (checkBox1.Checked)
                {
                    receieve_name = buyer_name;
                    receieve_card = buyer_card;
                    receieve_address = buyer_address;
                    receieve_car = car_number;
                    receieve_time = time;
                    receieve_date = date;
                }


                //25th y line
                string line25_1 = "أستلمت أنا السيد/ ";
                string line25_2 = "بطاقة رقم: ";



                RectangleF rect_line25 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                RectangleF rect_line25_2 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);
                string line_25_1 = getFormattedString(line25_1, receieve_name, rect_line25, format, builtInFont, e);
                string line_25_2 = getFormattedString(line25_2, receieve_card, rect_line25_2, format, builtInFont, e);


                e.Graphics.DrawString(line_25_1,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line25, format
                );

                e.Graphics.DrawString(line_25_2,
               builtInFont,
               new SolidBrush(Color.Black),
               rect_line25_2, format
               );

                line_y_cursor += normal_box_height + default_line_space+10;

                // 3rd y line
                string line26 = "المقيم: ";
                RectangleF rect_line26 = new RectangleF(0, line_y_cursor, paper_width - left_margin - right_margin, normal_box_height);
                string line_26 = getFormattedString(line26, receieve_address, rect_line26, format, builtInFont, e);

                e.Graphics.DrawString(line_26,
             builtInFont,
             new SolidBrush(Color.Black),
             rect_line26, format
             );

                line_y_cursor += normal_box_height + default_line_space+10;

                string line27_1 = "أنني أستلمت السيارة رقم: ";
                string line27_2 = "وذلك في تمام الساعة: ";
                string line27_3 = "من يوم: ";



                RectangleF rect_line27 = new RectangleF(paper_width/3*2-10, line_y_cursor, paper_width/3-10, normal_box_height);
                RectangleF rect_line27_2 = new RectangleF(paper_width/3-10, line_y_cursor, paper_width/3-10, normal_box_height);
                RectangleF rect_line27_3 = new RectangleF(0, line_y_cursor, paper_width/3, normal_box_height);
                
                string line_27_1 = getFormattedString(line27_1, receieve_car, rect_line27, format, builtInFont, e);
                string line_27_2 = getFormattedString(line27_2, receieve_time, rect_line27_2, format, builtInFont, e);
                string line_27_3 = getFormattedString(line27_3, receieve_date, rect_line27_3, format, builtInFont, e);


                e.Graphics.DrawString(line_27_1,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line27, format
                );
                e.Graphics.DrawString(line_27_2,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line27_2, format
                );

                e.Graphics.DrawString(line_27_3,
               builtInFont,
               new SolidBrush(Color.Black),
               rect_line27_3, format
               );

                line_y_cursor += normal_box_height + default_line_space + 10;


                string line28_1 = "وأصبحت مسئولا عنها المسئولية المدنية والجنائية. ";
                string line28_2 = "توقيع المستلم";
                string line28_3 = "(" + ValidatingFunctions.getDotsIfTextEmpty("", 30) + ")";


                RectangleF rect_line28 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
                RectangleF rect_line28_2 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);
                string line_28_1 = line28_1;
                string line_28_2 = getFormattedString(line28_2, line28_3, rect_line2_2, format, builtInFont, e);


                e.Graphics.DrawString(line_28_1,
                builtInFont,
                new SolidBrush(Color.Black),
                rect_line28, format
                );

                e.Graphics.DrawString(line_28_2,
               builtInFont,
               new SolidBrush(Color.Black),
               rect_line28_2, format
               );

                line_y_cursor += normal_box_height + default_line_space;


           

                //SQLCOMMAND INSERTION
            



            }
            catch (Exception eee) {
                MessageBox.Show("خطأ في الطباعة");
            }

        }
        public string getMatchingSpaceString(string symbol, Font font, System.Drawing.Printing.PrintPageEventArgs e, RectangleF rec)
        {
            string text = "";
            bool fit = false;
            while (!fit)
            {
                if (e.Graphics.MeasureString(text, font).Width < rec.Size.Width)
                {
                    text += symbol;
                }
                else { fit = true; }
            }
            return text;

        }
        public string getFormattedString(string first_string, string second_string, RectangleF rec, StringFormat format, Font font, System.Drawing.Printing.PrintPageEventArgs e)

{
            int string_len;
            int line;
            string text=first_string;
            e.Graphics.MeasureString(ValidatingFunctions.getDotsIfTextEmpty("",  500), font, rec.Size, new StringFormat(StringFormatFlags.MeasureTrailingSpaces), out string_len, out line);


                return text+ValidatingFunctions.getDotsIfTextEmpty(second_string, (string_len-text.Length)/3*2);
}

        private void paid_price_number_tx_ValueChanged(object sender, EventArgs e)
        {
            remai_price_number_tx.Value = total_price_number_tx.Value - paid_price_number_tx.Value;
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(paid_price_number_tx.Value.ToString()), currencies[0]);
                paid_price_text_tx.Text = toWord.ConvertToArabic();
            }
            catch (Exception ex)
            {
                paid_price_text_tx.Text = String.Empty;
            }


        }

        private void total_price_number_tx_ValueChanged(object sender, EventArgs e)
        {
            paid_price_number_tx.Maximum = total_price_number_tx.Value;
            paid_price_number_tx.Value = 0;
            remai_price_number_tx.Value = 0;
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(total_price_number_tx.Value.ToString()),currencies[0]);
                total_price_ext_tx.Text = toWord.ConvertToArabic();
            }
            catch (Exception ex)
            {
                total_price_ext_tx.Text = String.Empty;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             seller_name_tx.Text="";
             seller_card_tx.Text = "";
             seller_address_tx.Text = "";
             buyer_name_tx.Text = "";
             buyer_card_tx.Text = "";
             buyer_address_tx.Text = "";
             re_number.Text = "";
             re_motor.Text = "";
             re_mark.Text = "";
             re_model.Text = "";
             re_shaseh.Text = "";
             re_color.Text = "";
             re_shape.Text = "";
             re_kind.Text = "";
             total_price_number_tx.Value=0;
            total_price_ext_tx.Text= "";
            paid_price_number_tx.Value=0;
          paid_price_text_tx.Text= "";
          remai_price_number_tx.Value = 0;
            remain_price_text_tx.Text= "";
            remain_price_tx.Text= "";
       penalty_tx.Text= "";
       daily_rent_tx.Value = 0;
        }

        private void remai_price_number_tx_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(remai_price_number_tx.Value.ToString()), currencies[0]);
                remain_price_text_tx.Text = toWord.ConvertToArabic();
            }
            catch (Exception ex)
            {
                remain_price_text_tx.Text = String.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];

            form1.button3_Click(sender, e);

            button1_Click(sender, e);
             form1.bellUI1.buyername_bill.Text = buyer_name_tx.Text;
             form1.bellUI1.total_price_bill.Value = total_price_number_tx.Value;
             form1.bellUI1.paid_price_bill.Value = paid_price_number_tx.Value;

             form1.bellUI1.registr_radio.Checked = true;
             form1.bellUI1.re_number.Text = re_number.Text;


        }

    }
 

}
