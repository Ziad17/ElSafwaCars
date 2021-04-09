using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carproject.PrintForms
{
    public partial class PrintCarsForm : Form
    {
        public PrintCarsForm()
        {
            InitializeComponent();
                try
            {
            //    prepare_info();
                prepare_tables();
                prepare_size();

              
            }
            catch (Exception ee)
            {
                MessageBox.Show("خطأ بطباعة الجدول");
            }
        }

        int paper_width = 800;
        int paper_height = 1170;
        int upper_margin = 15;
        int left_margin = 20;
        int bottom_margin = 5;
        int right_margin = 20;
        float half_x_coord;

            public void prepare_tables()
        {
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            string command;
            command = "SELECT cars.Car_number,cars.Car_model,cars.Motor_number,cars.Car_mark,cars.Shaseh_number,cars.location FROM cars WHERE cars.Sold=0 AND NOT cars.Car_number='' ";
            cmd.CommandText = command;
         
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(cmd);
            DataTable majorDataTable = new DataTable();
       
            dataadapter.Fill(majorDataTable);



                  DataColumn col1 = majorDataTable.Columns.Add("رقم", typeof(int));
            col1.SetOrdinal(0);
            dv.DataSource = majorDataTable;

            for (int i = 0; i < majorDataTable.Rows.Count; i++)
            { dv.Rows[i].Cells[0].Value = i + 1; }

            dv.Columns[1].HeaderText = "رقم السيارة";
            dv.Columns[2].HeaderText = "موديل السيارة";
            dv.Columns[3].HeaderText = "رقم الموتور";
            dv.Columns[4].HeaderText = "الماركة";
            dv.Columns[5].HeaderText = "رقم الشاسيه";
            dv.Columns[6].HeaderText = "المكان";


    
           
       


            
        }


        private void prepare_size()
        {

            half_x_coord = 0;


            this.dv.DefaultCellStyle.SelectionBackColor = this.dv.DefaultCellStyle.BackColor;
            this.dv.DefaultCellStyle.SelectionForeColor = this.dv.DefaultCellStyle.ForeColor;
          dv.ColumnHeadersDefaultCellStyle.ForeColor = this.ForeColor;
            dv.ColumnHeadersDefaultCellStyle.BackColor = this.BackColor;
            dv.EnableHeadersVisualStyles = false;
            if (dv.Rows.Count > 33)
            {
                dv.RowsDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));


                dv.RowTemplate.Height = dv.RowTemplate.Height - 8;
            
            
            }
     


        }
      

        public void button3_Click(object sender, EventArgs e)
        {

           
            //printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(left_margin, right_margin, upper_margin, bottom_margin);

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", paper_width, paper_height);

     
          
           // printDocument1.Print();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headerFont = new Font("Times New Roman", 22, FontStyle.Bold);
            Font builtInFont = new Font("Times New Roman", 13, FontStyle.Bold);
            Font conditionsFont = new Font("Arial", 13, FontStyle.Bold);

            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            format.Trimming = StringTrimming.Word;

            float default_line_space = 3.0f;

            float normal_box_height = 20.0f;
            float large_box_height = 40.0f;
            float line_y_cursor = upper_margin + 10;

            float info_rec_height = 0;


            Image logo = new Bitmap(Carproject.Properties.Resources.pngegg);
            RectangleF rect_logo = new RectangleF((paper_width / 2) - 50, 0, 100, 100);
            e.Graphics.DrawImage(logo,


rect_logo
);
            line_y_cursor +=  10+ default_line_space;
            String title = "سيارات الباشا";
            StringFormat format1 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Center;
            RectangleF rect_title = new RectangleF(0, line_y_cursor, paper_width, 100);
            e.Graphics.DrawString(title,
                new Font("ABUHMEDA  FREE", 18, FontStyle.Italic) ,
                new SolidBrush(Color.Black),

rect_title, format1
);
            line_y_cursor += 60 + default_line_space;

            //e.Graphics.DrawImage(bm1, 0, line_y_cursor);
         //   dv.Width = 360;
     //       dv.Height = (dv.RowCount + 1) * (dv.RowTemplate.Height);


            dv.Height = dv.RowCount * dv.RowTemplate.Height-2;


            Bitmap bm_test = new Bitmap(dv.Width+10, dv.Height);
            dv.DrawToBitmap(bm_test, new Rectangle(0, 0, dv.Width, dv.Height));

            Bitmap bm = this.RoundCorners(this.RoundCorners(bm_test, 10, Color.Black), 10);

            e.Graphics.DrawImage(bm_test, 40, line_y_cursor);

          
            
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

        private void PrintCarsForm_Load(object sender, EventArgs e)
        {

        }

    }

}
