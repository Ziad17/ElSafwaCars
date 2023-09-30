using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Carproject.PrintForms
{
    public partial class AllTrafficForm : Form
    {

        Font headerFont;
        Font builtInFont;
        Font tax_font;
        Font address_font;
        Font thanks_font;
        StringFormat format;
        StringFormat centreFormat;
        Color redColor;
        int paper_width;
        int paper_height;
        int upper_margin;
        int left_margin;
        int bottom_margin;
        int right_margin;


        public AllTrafficForm()
        {
            InitializeComponent();
            refresh_cars(re_number); initStyles();
            testing();

        }

        private void initStyles()
        {
            string colorcode = "ff7F4747";
            int argb = Int32.Parse(colorcode, NumberStyles.HexNumber);
            redColor = Color.FromArgb(argb);


            headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
            builtInFont = new Font("Times New Roman", 22, FontStyle.Bold);
            tax_font = new Font("Times New Roman", 17, FontStyle.Regular);
            address_font = new Font("Times New Roman", 14, FontStyle.Regular);

            thanks_font = new Font("ABUHMEDA  FREE", 22, FontStyle.Italic);
            format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            format.Trimming = StringTrimming.Word;
            centreFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            centreFormat.LineAlignment = StringAlignment.Center;
            centreFormat.Alignment = StringAlignment.Center;
            paper_width = 800;
            paper_height = 1170;
            upper_margin = 0;
            left_margin = 15;
            bottom_margin = 20;
            right_margin = 15;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //مبايعة حظر
            string buyer_name = buyer_name_tx.Text;
            string buyer_address = buyer_address_tx.Text;
            string car_number = re_number.Text;
            string car_motor = re_motor.Text;
            string car_mark = re_mark.Text;
            string car_model = re_model.Text;
            string city = comboBox1.Text;

            string car_shaseh = re_shaseh.Text;
            string car_color = re_color.Text;
            string date = String.Format("{0:yyyy/M/d}", date_tx.Value);
            string day;
            string month;
            string year;

            if (!checkBox_date.Checked)
            {

                date = "";

            }



            float half_x_coord = (paper_width - left_margin - right_margin) / 2;
            float default_line_space = 20f;

            float normal_box_height = 35.0f;

            float line_x_cursor = 0f;

            float line_y_cursor = 200f;





            Image logo = new Bitmap(Carproject.Properties.Resources.template_m_h);
            RectangleF rect_logo = new RectangleF(0, 0, paper_width, paper_height);
            e.Graphics.DrawImage(logo,


rect_logo
);
            string line_date = "الإسكندرية في " + date;
            RectangleF rect_line_date = new RectangleF(line_x_cursor, line_y_cursor, paper_width, normal_box_height);
            e.Graphics.DrawString(line_date, builtInFont, new SolidBrush(Color.Black), rect_line_date, format);

            line_y_cursor += normal_box_height + default_line_space;

            string line_city = "السيد قائد مرور محافظة : " + city;
            RectangleF rect_line_city = new RectangleF(line_x_cursor, line_y_cursor, paper_width, normal_box_height);
            e.Graphics.DrawString(line_city, builtInFont, new SolidBrush(Color.Black), rect_line_city, format);

            line_y_cursor += normal_box_height + default_line_space;


            string line_greeting = "تحية طيبة وبعد..";
            RectangleF rect_line_greeting = new RectangleF(line_x_cursor, line_y_cursor, paper_width, normal_box_height);
            e.Graphics.DrawString(line_greeting, thanks_font, new SolidBrush(redColor), rect_line_greeting, centreFormat);

            line_y_cursor += normal_box_height + default_line_space;

            float normal_box_width = paper_width / 5;
            float big_box_width = paper_width / 5 * 4;


            RectangleF rect_line1 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(car_number, builtInFont, new SolidBrush(Color.Black), rect_line1, centreFormat);
            RectangleF rect_line1_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("لوحات رقم: ", headerFont, new SolidBrush(Color.Black), rect_line1_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line2 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(car_mark, builtInFont, new SolidBrush(Color.Black), rect_line2, centreFormat);
            RectangleF rect_line2_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("ماركة: ", headerFont, new SolidBrush(Color.Black), rect_line2_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line3 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(car_model, builtInFont, new SolidBrush(Color.Black), rect_line3, centreFormat);
            RectangleF rect_line3_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("موديــــل: ", headerFont, new SolidBrush(Color.Black), rect_line3_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line4 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(car_color, builtInFont, new SolidBrush(Color.Black), rect_line4, centreFormat);
            RectangleF rect_line4_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("اللون: ", headerFont, new SolidBrush(Color.Black), rect_line4_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line5 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(car_shaseh, builtInFont, new SolidBrush(Color.Black), rect_line5, centreFormat);
            RectangleF rect_line5_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("شاسيه رقم: ", headerFont, new SolidBrush(Color.Black), rect_line5_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line6 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(car_motor, builtInFont, new SolidBrush(Color.Black), rect_line6, centreFormat);
            RectangleF rect_line6_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("موتور رقم: ", headerFont, new SolidBrush(Color.Black), rect_line6_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line7 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(buyer_name, builtInFont, new SolidBrush(Color.Black), rect_line7, centreFormat);
            RectangleF rect_line7_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("إلى السيد: ", headerFont, new SolidBrush(Color.Black), rect_line7_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            RectangleF rect_line8 = new RectangleF(0, line_y_cursor, big_box_width, normal_box_height);
            e.Graphics.DrawString(buyer_address, builtInFont, new SolidBrush(Color.Black), rect_line8, centreFormat);
            RectangleF rect_line8_1 = new RectangleF(big_box_width, line_y_cursor, normal_box_width, normal_box_height);
            e.Graphics.DrawString("المقيم: ", headerFont, new SolidBrush(Color.Black), rect_line8_1, format);

            line_y_cursor += normal_box_height + default_line_space;

            string first_note = "برجاء التكرم بإجراء اللازم وترخيص السيارة بإسم المذكور عاليه";
            RectangleF rect_line_first_note = new RectangleF(0, line_y_cursor, paper_width, normal_box_height);
            e.Graphics.DrawString(first_note, builtInFont, new SolidBrush(Color.Red), rect_line_first_note, centreFormat);

            line_y_cursor += normal_box_height + default_line_space - 15;

            string second_note = "لا تجدد سنويا إلا بموافقة محمد سليمان سعيد سليمان";
            RectangleF rect_line_second_note = new RectangleF(0, line_y_cursor, paper_width, normal_box_height);
            e.Graphics.DrawString(second_note, builtInFont, new SolidBrush(Color.Red), rect_line_second_note, centreFormat);

            line_y_cursor += normal_box_height + default_line_space - 5;


            string thanks_note = "وتفضلوا سيادتكم بقبول وافر الشكر والإحترام";
            RectangleF rect_line_thanks_note = new RectangleF(0, line_y_cursor, paper_width, normal_box_height);
            e.Graphics.DrawString(thanks_note, thanks_font, new SolidBrush(redColor), rect_line_thanks_note, centreFormat);

            line_y_cursor += normal_box_height + default_line_space;


            string sign_box = "توقيع (                                  )";
            RectangleF rect_line_sign_box = new RectangleF(0, line_y_cursor, paper_width / 2, normal_box_height);
            e.Graphics.DrawString(sign_box, builtInFont, new SolidBrush(Color.Black), rect_line_sign_box, format);

            line_y_cursor += normal_box_height + default_line_space;

            //string tax_note = "بطاقة ضريبية: 200-820-435  ملف رقم: 5-00728-00-09   منتزة ثان   سجل تجاري: 83403";
            //RectangleF rect_line_tax_note = new RectangleF(0, line_y_cursor, paper_width, normal_box_height);
            //e.Graphics.DrawString(tax_note, tax_font, new SolidBrush(Color.Red), rect_line_tax_note, centreFormat);

            //line_y_cursor += normal_box_height + default_line_space-20;

            //string address_note = "الطريق الدائري الجديد - محسن - بجوار فتحة زقزوق 01281055666 - 01223602786";
            //RectangleF rect_line_address_note = new RectangleF(0, line_y_cursor, paper_width, normal_box_height);
            //e.Graphics.DrawString(address_note, address_font, new SolidBrush(Color.Red), rect_line_address_note, centreFormat);



        }

        private void testing()
        {
            buyer_name_tx.Text = "محمد خالد السيد";
            buyer_address_tx.Text = "المنتزة اول-شرق الاسكندرية-مصر";
            re_number.SelectedIndex = 0;
            comboBox1.Text = "الاسكندرية";
            re_color.Text = "ابيض";
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
                checkIFExistsThenAdd(buyer_address_tx, rd.GetValue(3).ToString());
                checkIFExistsThenAdd(re_model, rd.GetValue(8).ToString());
                checkIFExistsThenAdd(re_mark, rd.GetValue(9).ToString());
                checkIFExistsThenAdd(re_shaseh, rd.GetValue(10).ToString());
                checkIFExistsThenAdd(re_motor, rd.GetValue(11).ToString());
                checkIFExistsThenAdd(re_color, rd.GetValue(13).ToString());



            }
            con.Close();

            buyer_name_tx.Refresh();
            buyer_address_tx.Refresh();
            buyer_name_tx.Refresh();
            re_model.Refresh();
            re_mark.Refresh();
            re_shaseh.Refresh();
            re_motor.Refresh();
            re_color.Refresh();






        }
        private void checkIFExistsThenAdd(ComboBox box, String item)
        {


            if (!box.Items.Contains(item))
            {
                box.Items.Add(item);
            }

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

        private void restrict_button_Click(object sender, EventArgs e)
        {

            // printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);
            //  printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            printPreviewDialog1.Document = printDocument1;

            // printDocument1.Print();
            printPreviewDialog1.ShowDialog();


        }



        private void selling_button_Click(object sender, EventArgs e)
        {

            //     printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);
            printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);
            //  printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            printPreviewDialog1.Document = printDocument2;

            printDocument2.Print();
            printPreviewDialog1.ShowDialog();

        }

        private void finishing_button_Click(object sender, EventArgs e)
        {
            //     printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);
            printDocument3.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);
            //  printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            printPreviewDialog1.Document = printDocument3;

            //  printDocument3.Print();
            printPreviewDialog1.ShowDialog();

        }


        private void renewal_button_Click(object sender, EventArgs e)
        {
            //     printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);
            printDocument4.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);
            //  printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            printPreviewDialog1.Document = printDocument4;

            printDocument4.Print();
            printPreviewDialog1.ShowDialog();
        }





        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


        }



        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


        }


        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {




        }
    }




    ////تجديد سنوي
    //string buyer_name = buyer_name_tx.Text;
    //string buyer_address = buyer_address_tx.Text;
    //string car_number = re_number.Text;
    //string car_motor = re_motor.Text;
    //string car_mark = re_mark.Text;
    //string car_model = re_model.Text;
    //string car_shaseh = re_shaseh.Text;
    //string car_color = re_color.Text;
    //string city = comboBox1.Text;

    //string date = String.Format("{0:yyyy/M/d}", date_tx.Value);
    //string day;
    //string month;
    //string year;

    //if (!checkBox_date.Checked)
    //{

    //    day = "";
    //    month = "";
    //    year = "";

    //}
    //else
    //{
    //    day = date_tx.Value.Day.ToString();
    //    month = date_tx.Value.Month.ToString();
    //    year = (date_tx.Value.Year - 2000).ToString();


    //}

    //Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
    //Font builtInFont = new Font("Times New Roman", 22, FontStyle.Bold);
    //Font smallFont = new Font("Times New Roman", 15, FontStyle.Bold);


    //StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
    //format.Trimming = StringTrimming.Word;


    //float half_x_coord = (paper_width - left_margin - right_margin) / 2;
    //float default_line_space = 0f;

    //float tiny_line_space = 3.0f;
    //float normal_box_height = 30.0f;
    //float large_box_height = 40.0f;

    //float line_x_cursor = 0f;

    //float first_line_y_coor = 0f;
    //float line_y_cursor = 0f;


    ////city printing
    //float city_box_width = 100f;
    //float city_x_coord = 0f;
    //float city_y_coord = 0f;
    //RectangleF rect_city = new RectangleF(city_x_coord, city_y_coord, city_box_width, normal_box_height);
    //e.Graphics.DrawString(city, builtInFont, new SolidBrush(Color.Black), rect_city, format);
    ////date prining
    //float day_box_width = 30;
    //float month_box_width = 30;
    //float year_box_width = 30;
    //float box_line_x_spaceing = 0f;
    //float date_x_coord = paper_width - 150f;
    //float date_y_coord = 150f;

    //RectangleF rect_year = new RectangleF(date_x_coord, date_y_coord, day_box_width, normal_box_height);
    //e.Graphics.DrawString(year, builtInFont, new SolidBrush(Color.Black), rect_year, format);

    //RectangleF rect_month = new RectangleF(date_x_coord + day_box_width + box_line_x_spaceing, date_y_coord, month_box_width, normal_box_height);
    //e.Graphics.DrawString(month, builtInFont, new SolidBrush(Color.Black), rect_month, format);

    //RectangleF rect_day = new RectangleF(date_x_coord + day_box_width + box_line_x_spaceing + box_line_x_spaceing + month_box_width, date_y_coord, year_box_width, normal_box_height);
    //e.Graphics.DrawString(day, builtInFont, new SolidBrush(Color.Black), rect_day, format);





    //RectangleF rect_line1 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_number, smallFont, new SolidBrush(Color.Black), rect_line1, format);

    ////line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line2 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_mark, builtInFont, new SolidBrush(Color.Black), rect_line2, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line3 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_model, builtInFont, new SolidBrush(Color.Black), rect_line3, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line4 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_color, builtInFont, new SolidBrush(Color.Black), rect_line4, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line5 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_shaseh, builtInFont, new SolidBrush(Color.Black), rect_line5, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line6 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_motor, builtInFont, new SolidBrush(Color.Black), rect_line6, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line7 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(buyer_name, builtInFont, new SolidBrush(Color.Black), rect_line7, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line8 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(buyer_address, smallFont, new SolidBrush(Color.Black), rect_line1, format);

    ////line_y_cursor += normal_box_height + default_line_space;












    ////تجديد سنوي
    //string buyer_name = buyer_name_tx.Text;
    //string buyer_address = buyer_address_tx.Text;
    //string car_number = re_number.Text;
    //string car_motor = re_motor.Text;
    //string car_mark = re_mark.Text;
    //string car_model = re_model.Text;
    //string car_shaseh = re_shaseh.Text;
    //string car_color = re_color.Text;
    //string city = comboBox1.Text;

    //string date = String.Format("{0:yyyy/M/d}", date_tx.Value);
    //string day;
    //string month;
    //string year;

    //if (!checkBox_date.Checked)
    //{

    //    day = "";
    //    month = "";
    //    year = "";

    //}
    //else
    //{
    //    day = date_tx.Value.Day.ToString();
    //    month = date_tx.Value.Month.ToString();
    //    year = (date_tx.Value.Year - 2000).ToString();


    //}

    //Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
    //Font builtInFont = new Font("Times New Roman", 22, FontStyle.Bold);
    //Font smallFont = new Font("Times New Roman", 15, FontStyle.Bold);


    //StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
    //format.Trimming = StringTrimming.Word;


    //float half_x_coord = (paper_width - left_margin - right_margin) / 2;
    //float default_line_space = 0f;

    //float tiny_line_space = 3.0f;
    //float normal_box_height = 30.0f;
    //float large_box_height = 40.0f;

    //float line_x_cursor = 0f;

    //float first_line_y_coor = 0f;
    //float line_y_cursor = 0f;


    ////city printing
    //float city_box_width = 100f;
    //float city_x_coord = 0f;
    //float city_y_coord = 0f;
    //RectangleF rect_city = new RectangleF(city_x_coord, city_y_coord, city_box_width, normal_box_height);
    //e.Graphics.DrawString(city, builtInFont, new SolidBrush(Color.Black), rect_city, format);
    ////date prining
    //float day_box_width = 30;
    //float month_box_width = 30;
    //float year_box_width = 30;
    //float box_line_x_spaceing = 0f;
    //float date_x_coord = paper_width - 150f;
    //float date_y_coord = 150f;

    //RectangleF rect_year = new RectangleF(date_x_coord, date_y_coord, day_box_width, normal_box_height);
    //e.Graphics.DrawString(year, builtInFont, new SolidBrush(Color.Black), rect_year, format);

    //RectangleF rect_month = new RectangleF(date_x_coord + day_box_width + box_line_x_spaceing, date_y_coord, month_box_width, normal_box_height);
    //e.Graphics.DrawString(month, builtInFont, new SolidBrush(Color.Black), rect_month, format);

    //RectangleF rect_day = new RectangleF(date_x_coord + day_box_width + box_line_x_spaceing + box_line_x_spaceing + month_box_width, date_y_coord, year_box_width, normal_box_height);
    //e.Graphics.DrawString(day, builtInFont, new SolidBrush(Color.Black), rect_day, format);





    //RectangleF rect_line1 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_number, smallFont, new SolidBrush(Color.Black), rect_line1, format);

    ////line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line2 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_mark, builtInFont, new SolidBrush(Color.Black), rect_line2, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line3 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_model, builtInFont, new SolidBrush(Color.Black), rect_line3, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line4 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_color, builtInFont, new SolidBrush(Color.Black), rect_line4, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line5 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_shaseh, builtInFont, new SolidBrush(Color.Black), rect_line5, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line6 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(car_motor, builtInFont, new SolidBrush(Color.Black), rect_line6, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line7 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(buyer_name, builtInFont, new SolidBrush(Color.Black), rect_line7, format);

    //line_y_cursor += normal_box_height + default_line_space;

    //RectangleF rect_line8 = new RectangleF(line_x_cursor, line_y_cursor, paper_width - line_x_cursor - 20, normal_box_height);
    //e.Graphics.DrawString(buyer_address, smallFont, new SolidBrush(Color.Black), rect_line1, format);

    ////line_y_cursor += normal_box_height + default_line_space;
}














////مبايعة هي هي مبايعة حظر + 2 سم
//string buyer_name = buyer_name_tx.Text;
//string buyer_address = buyer_address_tx.Text;
//string car_number = re_number.Text;
//string car_motor = re_motor.Text;
//string car_mark = re_mark.Text;
//string car_model = re_model.Text;
//string city = comboBox1.Text;

//string car_shaseh = re_shaseh.Text;
//string car_color = re_color.Text;
//string date = String.Format("{0:yyyy/M/d}", date_tx.Value);
//string day;
//string month;
//string year;

//if (!checkBox_date.Checked)
//{

//    day = "";
//    month = "";
//    year = "";

//}
//else
//{
//    day = date_tx.Value.Day.ToString();
//    month = date_tx.Value.Month.ToString();
//    year = (date_tx.Value.Year - 2000).ToString();

//}
//Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
//Font builtInFont = new Font("Times New Roman", 22, FontStyle.Bold);


//StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
//format.Trimming = StringTrimming.Word;


//float half_x_coord = (paper_width - left_margin - right_margin) / 2;
//float default_line_space = 30f; // to edit

//float tiny_line_space = 3.0f;
//float normal_box_height = 30.0f;
//float large_box_height = 40.0f;


//float first_line_y_coor = 0f;
//float line_y_cursor = 400f;


//Pen pen = new Pen(new SolidBrush(Color.Blue), 1);
//for (int i = 0; i < paper_height; i += 20)
//{
//    e.Graphics.DrawLine(pen, 0, i, paper_width, i);
//}
//Pen pen1 = new Pen(new SolidBrush(Color.Red), 1);
//for (int i = 0; i < paper_width; i += 20)
//{
//    e.Graphics.DrawLine(pen1, i, 0, i, paper_height);
//}



////date prining
//float day_box_width = 50;
//float month_box_width = 50;
//float year_box_width = 50;
//float box_line_x_spaceing = 0f;
//float date_x_coord = paper_width - 150f;
//float date_y_coord = 150f;

//RectangleF rect_year = new RectangleF(date_x_coord, date_y_coord, day_box_width, normal_box_height);
//e.Graphics.DrawString(year, builtInFont, new SolidBrush(Color.Black), rect_year, format);

//RectangleF rect_month = new RectangleF(date_x_coord + day_box_width + box_line_x_spaceing, date_y_coord, month_box_width, normal_box_height);
//e.Graphics.DrawString(month, builtInFont, new SolidBrush(Color.Black), rect_month, format);

//RectangleF rect_day = new RectangleF(date_x_coord + day_box_width + box_line_x_spaceing + box_line_x_spaceing + month_box_width, date_y_coord, year_box_width, normal_box_height);
//e.Graphics.DrawString(day, builtInFont, new SolidBrush(Color.Black), rect_day, format);



//float line_x_cursor = 70f; // to edit

//float width = 285f;
//float normal_box_width = paper_width - line_x_cursor;


//RectangleF rect_line1 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(car_number, builtInFont, new SolidBrush(Color.Black), rect_line1, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line2 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(car_mark, builtInFont, new SolidBrush(Color.Black), rect_line2, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line3 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(car_model, builtInFont, new SolidBrush(Color.Black), rect_line3, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line4 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(car_color, builtInFont, new SolidBrush(Color.Black), rect_line4, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line5 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(car_shaseh, builtInFont, new SolidBrush(Color.Black), rect_line5, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line6 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(car_motor, builtInFont, new SolidBrush(Color.Black), rect_line6, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line7 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(buyer_name, builtInFont, new SolidBrush(Color.Black), rect_line7, format);

//line_y_cursor += normal_box_height + default_line_space;

//RectangleF rect_line8 = new RectangleF(0, line_y_cursor, normal_box_width, normal_box_height);
//e.Graphics.DrawString(buyer_address, builtInFont, new SolidBrush(Color.Black), rect_line8, format);

//line_y_cursor += normal_box_height + default_line_space;


////city printing
//float city_x_coord = line_x_cursor - 200f;
//float city_y_coord = 200f;
//RectangleF rect_city = new RectangleF(city_x_coord, city_y_coord, normal_box_width, normal_box_height);
//e.Graphics.DrawString(city, builtInFont, new SolidBrush(Color.Black), rect_city, format);