using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carproject.PrintForms
{
    public partial class BillDetailsForm : Form
    {
        int bill_id;

        string name;//
        string car_number;//
        string motor;//
        string shaseh;//
        string mark;//
        string model;//
        string total_price;//
        string first_payment;//
        string remain_payment;//
        string first_pay_date;//
        string notes;//
        string restrict_sell;//
        string bill_num;//
        string phone_num;//
        string insurance_num;//

        private void prepare_info()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT bills.id,bills.Buyer_name,bills.Buyer_phone,bills.Inserunce_phone,bills.Restrict_sell_for,bills.Notes,bills.created_date,car_number,Total_price,Paid_price,To_pay_price FROM bills WHERE bills.id=@id;";
            cmd.Parameters.AddWithValue("@id", bill_id);

            MySqlDataReader re = cmd.ExecuteReader();
            re.Read();
            bill_num = re[0].ToString();
            name = re[1].ToString();
            phone_num = re[2].ToString();
            insurance_num = re[3].ToString();
            restrict_sell = re[4].ToString();
            notes = re[5].ToString();
            first_pay_date =    String.Format("{0:yyyy/M/d}",(DateTime)re[6]);

            car_number = re[7].ToString();
            total_price = re[8].ToString();
            first_payment = re[9].ToString();
            remain_payment=re[10].ToString();
            re.Close();
            MySqlCommand cmd1 = con.CreateCommand();
            cmd.CommandText = "SELECT Car_Number,Car_model,Motor_number,Car_mark,Shaseh_number FROM cars WHERE Car_Number=@car_number;";
            cmd.Parameters.AddWithValue("@car_number", car_number);

            MySqlDataReader re1 = cmd.ExecuteReader();
            re1.Read();
            car_number = re1[0].ToString();
            model = re1[1].ToString();
            motor = re1[2].ToString();
            mark = re1[3].ToString();
            shaseh = re1[4].ToString();
            con.Close();

        }


        public BillDetailsForm(int id)
        {
            InitializeComponent();
            bill_id = id;

            try
            {
                prepare_info();
                prepare_tables();
                prepare_size();

              
            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ بطباعة الجدول");
            }
            }

       

        private void prepare_size()
        {

            half_x_coord = (paper_width - left_margin - right_margin) / 2;




            //dv.Width = dv.Width*2;
            //dv1.Width = (int)half_x_coord;
            //float unit = dv.Width / 8;
            //dv.Columns[0].Width = (int)unit;
            //dv.Columns[1].Width = (int)unit * 2;
            //dv.Columns[2].Width = (int)unit * 3;
            //dv.Columns[3].Width = (int)unit * 2;

            //dv1.Columns[0].Width = (int)unit;
            //dv1.Columns[1].Width = (int)unit * 2;
            //dv1.Columns[2].Width = (int)unit * 3;
            //dv1.Columns[3].Width = (int)unit * 2;

            this.dv.DefaultCellStyle.SelectionBackColor = this.dv.DefaultCellStyle.BackColor;
            this.dv.DefaultCellStyle.SelectionForeColor = this.dv.DefaultCellStyle.ForeColor;
            this.dv1.DefaultCellStyle.SelectionBackColor = this.dv.DefaultCellStyle.BackColor;
            this.dv1.DefaultCellStyle.SelectionForeColor = this.dv.DefaultCellStyle.ForeColor;
            dv.ColumnHeadersDefaultCellStyle.ForeColor = this.ForeColor;
            dv.ColumnHeadersDefaultCellStyle.BackColor = this.BackColor;
            dv.EnableHeadersVisualStyles = false;
            dv1.ColumnHeadersDefaultCellStyle.ForeColor = this.ForeColor;
            dv1.ColumnHeadersDefaultCellStyle.BackColor = this.BackColor;
            dv1.EnableHeadersVisualStyles = false;
        
        

        }
        bool NO_OTHER_ROW = false;
        public void prepare_tables()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            string command;
            command = "SELECT installs.Total_price,Paying_date,Paid_price FROM installs WHERE installs.bill_id=@id ORDER BY Paying_date ASC;";
            cmd.CommandText = command;
            cmd.Parameters.AddWithValue("@id", bill_id);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(cmd);
            //   DataTable dt1 = new DataTable();
            DataTable majorDataTable = new DataTable();
       
            dataadapter.Fill(majorDataTable);
           
            DataTable firstDataTable = new DataTable();
            firstDataTable.Columns.Add("1",typeof(int));
            firstDataTable.Columns.Add("2",typeof(DateTime));
            firstDataTable.Columns.Add("3",typeof(int));
           

            DataTable secondDataTable = new DataTable();
            secondDataTable.Columns.Add("4", typeof(int));
            secondDataTable.Columns.Add("5", typeof(DateTime));
            secondDataTable.Columns.Add("6", typeof(int));
           

            int rows_pivot=28;

            if (majorDataTable.Rows.Count < rows_pivot)
            {
                NO_OTHER_ROW = true;
                rows_pivot = majorDataTable.Rows.Count; 
            }
            for (int i = 0; i <rows_pivot ; i++)
            {
                firstDataTable.Rows.Add(majorDataTable.Rows[i].ItemArray);
            }
            for(int i=rows_pivot;i<majorDataTable.Rows.Count;i++)
            {
                secondDataTable.Rows.Add(majorDataTable.Rows[i].ItemArray);
            }




            DataColumn col = firstDataTable.Columns.Add("رقم", typeof(int));
            col.SetOrdinal(0);

            dv.DataSource = firstDataTable;

            for (int i = 0; i < firstDataTable.Rows.Count; i++)
            { dv.Rows[i].Cells[0].Value = i + 1; }
            dv.Columns[1].HeaderText = "قيمة القسط";
            dv.Columns[2].HeaderText = "تاريخ السداد";
            dv.Columns[3].HeaderText = "المدفوع";
            dv.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";


            DataColumn col1 = secondDataTable.Columns.Add("رقم", typeof(int));
            col1.SetOrdinal(0);

            dv1.DataSource = secondDataTable;

            for (int i = 0; i < secondDataTable.Rows.Count; i++)
            { dv1.Rows[i].Cells[0].Value = i + 1+firstDataTable.Rows.Count; }
            dv1.Columns[1].HeaderText = "قيمة القسط";
            dv1.Columns[2].HeaderText = "تاريخ السداد";
            dv1.Columns[3].HeaderText = "المدفوع";
            dv1.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";

            try
            {
                if (NO_OTHER_ROW)
                {
                    turnZerosIntoBlank(dv);
                }
                else
                {
                    turnZerosIntoBlank(dv);
                    turnZerosIntoBlank(dv1);

                }
            }
            catch (Exception e)
            {
          //  MessageBox.Show(e.ToString()); 
            }


            
        }

        private void turnZerosIntoBlank(DataGridView data)
        {
            foreach (DataGridViewRow row in data.Rows)
            {
                if ((int)row.Cells[3].Value == 0)
                {
                    row.Cells[3].Value =  DBNull.Value;
                }
            }
        }

        int paper_width = 800;
        int paper_height = 1170;
        int upper_margin = 15;
        int left_margin = 20;
        int bottom_margin = 5;
        int right_margin = 20;
        float half_x_coord;



        public void button1_Click(object sender, EventArgs e)
        {


            string file = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();

            // the directory to store the output.
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            //printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);

            //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            //printDocument1.PrinterSettings = new System.Drawing.Printing.PrinterSettings() {

            //    // set the printer to 'Microsoft Print to PDF'
            //    PrinterName = "Win2PDF",

            //    // tell the object this document will print to file
            //    PrintToFile = true,

            //    // set the filename to whatever you like (full path)
            //    PrintFileName = Path.Combine(directory, file + ".pdf"),
            //};
            printDocument1.Print();
            
            
          //  printPreviewDialog1.Document = printDocument1;

         //   printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            
            string line1_1 = "الإســــــــــــم:";
            string line1_2 = "رقم السيـــــارة:";

            string line2_1 = "رقم الـــاسيه:";
            string line2_2 = "رقم الـــــموتور:";

            string line3_1 = "الـــــــمـاركــة:";
            string line3_2 = "المـــــــوديــل:";

            string line4_1 = "الثمن الإجمالي:";
            string line4_2 = "الـــمــقـــدم:";

            string line5_1 = "الـبــاقــــــــي:";
            string line5_2 = "أول كمبيالة:";

            string line6_1 = "مـــــلاحــظــات:";
            string line6_2 = "حظر البيع لصالح:";

            string line7_1 = "هــاتف المشتري:";
            string line7_2 = "هاتف الضــامن:";

            Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
            Font builtInFont = new Font("Times New Roman", 13, FontStyle.Bold);
            Font conditionsFont = new Font("Arial", 13, FontStyle.Bold);

            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            format.Trimming = StringTrimming.Word;

            float default_line_space = 3.0f;
            
            float normal_box_height = 20.0f;
            float large_box_height = 40.0f;
            float line_y_cursor = upper_margin+10;

            float info_rec_height = 0;
            
            //header line
            StringFormat format_center = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            format_center.LineAlignment = StringAlignment.Center;
            format_center.Alignment = StringAlignment.Center;
            RectangleF bill_rec = new RectangleF(0,line_y_cursor, paper_width, normal_box_height+5);
            e.Graphics.DrawString(bill_id.ToString(),
                headerFont,
                new SolidBrush(Color.Black),

bill_rec, format_center
);
            line_y_cursor += normal_box_height + default_line_space+15;
            info_rec_height = line_y_cursor;

            //1st line
            RectangleF rect_line1 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line1_2 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);



            string first_line_1 = line1_1 + " " + name;
            string first_line_2 = line1_2+" "+car_number ;

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
            info_rec_height = line_y_cursor;

            //2nd line
            RectangleF rect_line2 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line2_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);



            string second_line_1 = line2_1 + " " + shaseh;
            string second_line_2 = line2_2 + " " + motor;

            e.Graphics.DrawString(second_line_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line2, format
            );
            e.Graphics.DrawString(second_line_2,
           builtInFont,
           new SolidBrush(Color.Black),
           rect_line2_1, format
           );

            line_y_cursor += normal_box_height + default_line_space;
            info_rec_height = line_y_cursor;


            //3th line
            RectangleF rect_line3 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line3_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);



            string third_line_1 = line3_1 + " " + mark;
            string third_line_2 = line3_2 + " " + model;

            e.Graphics.DrawString(third_line_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line3, format
            );
            e.Graphics.DrawString(third_line_2,
           builtInFont,
           new SolidBrush(Color.Black),
           rect_line3_1, format
           );

            line_y_cursor += normal_box_height + default_line_space;
            info_rec_height = line_y_cursor;

            //4th line
            RectangleF rect_line4 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line4_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);



            string th4_line_1 = line4_1 + " " + total_price;
            string th4_line_2 = line4_2 + " " + first_payment;

            e.Graphics.DrawString(th4_line_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line4, format
            );
            e.Graphics.DrawString(th4_line_2,
           builtInFont,
           new SolidBrush(Color.Black),
           rect_line4_1, format
           );

            line_y_cursor += normal_box_height + default_line_space;
            info_rec_height = line_y_cursor;

            //5th line
            RectangleF rect_line5 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line5_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);

            

            string th5_line_1 = line5_1 + " " + remain_payment;
            string th5_line_2 = line5_2 + " " + first_pay_date;

            e.Graphics.DrawString(th5_line_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line5, format
            );
            e.Graphics.DrawString(th5_line_2,
           builtInFont,
           new SolidBrush(Color.Black),
           rect_line5_1, format
           );

            line_y_cursor += normal_box_height + default_line_space;
            info_rec_height = line_y_cursor;

            //6th line
            RectangleF rect_line6 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line6_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);



            string th6_line_1 = line6_1 + " " + notes;
            string th6_line_2 = line6_2 + " " + restrict_sell;

            e.Graphics.DrawString(th6_line_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line6, format
            );
            e.Graphics.DrawString(th6_line_2,
           builtInFont,
           new SolidBrush(Color.Black),
           rect_line6_1, format
           );

            line_y_cursor += normal_box_height + default_line_space;
            info_rec_height = line_y_cursor-upper_margin;



            //7th line
            RectangleF rect_line7 = new RectangleF(half_x_coord, line_y_cursor, half_x_coord, normal_box_height);
            RectangleF rect_line7_1 = new RectangleF(0, line_y_cursor, half_x_coord, normal_box_height);



            string th7_line_1 = line7_1 + " " + phone_num;
            string th7_line_2 = line7_2 + " " + insurance_num;

            e.Graphics.DrawString(th7_line_1,
            builtInFont,
            new SolidBrush(Color.Black),
            rect_line7, format
            );
            e.Graphics.DrawString(th7_line_2,
           builtInFont,
           new SolidBrush(Color.Black),
           rect_line7_1, format
           );

            line_y_cursor += normal_box_height + default_line_space;

            info_rec_height = line_y_cursor - upper_margin;








            int height = int.Parse(info_rec_height.ToString());
            Rectangle rect_all= new Rectangle(left_margin, upper_margin,paper_width-left_margin-right_margin, height );
            GraphicsPath rect_all_info =BillDetailsForm.RoundedRect(rect_all,15);
           // Rectangle rect_all_info = new Rectangle(0, 0,paper_width, height +5);
            Pen pen = new Pen(Color.Black, 3);
         //   pen.Alignment = PenAlignment.Inset; //<-- this
            e.Graphics.DrawPath(pen, rect_all_info);

            line_y_cursor += 15;



            //table Printing

            //Bitmap bm1 = new Bitmap((int)half_x_coord, dv1.Height);
            
            //dv1.DrawToBitmap(bm1, new Rectangle(0, 0, (int)half_x_coord, dv1.Height));
            
            //e.Graphics.DrawImage(bm1, 0, line_y_cursor);
            dv.Width = 360;
            dv.Height = (dv.RowCount + 1) * (dv.RowTemplate.Height);
            dv.Columns[0].Width = 30;
            dv.Columns[1].Width = 70;
            dv.Columns[2].Width = 110;
            dv.Columns[3].Width = 150;

           
            Bitmap bm_test = new Bitmap(dv.Width, dv.Height);
            dv.DrawToBitmap(bm_test, new Rectangle(0, 0, dv.Width , dv.Height));

            Bitmap bm = this.RoundCorners(this.RoundCorners(bm_test,20,Color.Black), 17);
            
            e.Graphics.DrawImage(bm, 410-5 , line_y_cursor);

            if (!NO_OTHER_ROW)
            {

                dv1.Width = 360;
                dv1.Height = (dv1.RowCount + 1) * (dv1.RowTemplate.Height);
                dv1.Columns[0].Width = 30;
                dv1.Columns[1].Width = 70;
                dv1.Columns[2].Width = 110;
                dv1.Columns[3].Width = 150;


                Bitmap bm1_test = new Bitmap(dv1.Width, dv1.Height);
                dv1.DrawToBitmap(bm1_test, new Rectangle(0, 0, dv1.Width, dv1.Height));

                Bitmap bm1 = this.RoundCorners(this.RoundCorners(bm1_test, 20, Color.Black), 17);

                e.Graphics.DrawImage(bm1, left_margin + 3, line_y_cursor);
                // MessageBox.Show("s");
            }

        }

        public Bitmap RoundCorners(Bitmap StartImage, int CornerRadius)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
               // g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new TextureBrush(StartImage);
                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);
                Pen pen = new Pen(Color.Black, 3);
                return RoundedImage;
            }
        }

        public Bitmap RoundCorners(Bitmap StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                 g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new TextureBrush(StartImage);
                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);
                Pen pen = new Pen(Color.Black, 3);
                return RoundedImage;
            }
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
