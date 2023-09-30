using System;
using System.Windows.Forms;
using System.IO;
using Carproject.UI.Forms;
using MySql.Data.MySqlClient;
using QuestPDF.Drawing;
using QuestPDF.Infrastructure;

namespace Carproject
{
    static class Program
    {
        public static void RegisterFonts()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            string cairoFontFileUrl = Path.Combine(folder, "Cairo-Medium.ttf");
            string cairoExtraBoldFontFileUrl = Path.Combine(folder, "Cairo-ExtraBold.ttf");
            string cairoBoldFontFileUrl = Path.Combine(folder, "Cairo-Bold.ttf");

            var cairoFontFile = File.OpenRead(cairoFontFileUrl);
            var cairoExtraBoldFontFile = File.OpenRead(cairoExtraBoldFontFileUrl);
            var cairoBoldFontFile = File.OpenRead(cairoBoldFontFileUrl);

            FontManager.RegisterFont(cairoBoldFontFile);
            FontManager.RegisterFont(cairoExtraBoldFontFile);
            FontManager.RegisterFont(cairoFontFile);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
        ///
        [STAThread]
        static void Main()
        {
            StreamWriter streamwriter;
            StreamReader streamreader;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
            //  Application.Run(new ShowCars());
            RegisterFonts();
            Application.Run(new HomeScreenForm());

            //     Application.Run(new PrintForms.BillDetailsForm(1));

            //try
            //{
            //    con.Open();
            //    con.Close();


            //    Application.Run(new Form1());

            //    string user = "root";
            //    string pwd = "1234";
            //    string path = @"D:\elbashaaa\backup";

            //    //exportPath.Append(Directory.GetCurrentDirectory());

            //    String file_name = @"\backup.sql";
            //    Process m = new Process();
            //    m.StartInfo.FileName = "cmd.exe";

            //    m.StartInfo.UseShellExecute = false;
            //    m.StartInfo.WorkingDirectory = @"C:\xampp\mysql\bin\";
            //    m.StartInfo.RedirectStandardInput = true;

            //    m.StartInfo.RedirectStandardOutput = true;
            //    m.Start();
            //    streamwriter = m.StandardInput;
            //    streamreader = m.StandardOutput;
            //    streamwriter.WriteLine("mysqldump -u user -p" + pwd + "  -h localhost elbashacars > " + path + file_name);
            //    streamwriter.Close();
            //    m.WaitForExit();
            //    m.Close();


            //}





            //catch (Exception ee)
            //{
            //   // MessageBox.Show("قاعدة البيانات معطلة");
            //    MessageBox.Show(ee.ToString());


            //}
        }
    }
}



// //  MySQLDump.StartInfo.Arguments = @"mysqldump -uroot -p -h localhost elbashacars > C:\Users\Home\Desktop ";

//    //string theDump = MySQLDump.StandardOutput.ReadToEnd();
// //   MySQLDump.WaitForExit();
// //   MySQLDump.Close();
//    //ProcessStartInfo psi = new ProcessStartInfo();
//    //psi.FileName = @"C:\xampp\mysql\bin\mysql.exe";
//    //psi.RedirectStandardInput = true;
//    //psi.RedirectStandardOutput = false;
//    //psi.CreateNoWindow = true;
//    //psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}<{4}", user, pwd, "localhost", "elbashacars", @"C:\Users\Home\Desktop\hh.sql");
//    //psi.UseShellExecute = false;
//    //Process process = Process.Start(psi);
//    //process.StandardInput.WriteLine();
//    //process.StandardInput.Close();
//    //process.WaitForExit();
//    //process.Close();

//    //String path = @"""C:\xampp\mysql\bin\mysqldump.exe"" -u " + user + @" -p " + pwd + @" > ""C:\Users\Home\Desktop\" + "hhh" + @"""";

//    //Process p = new Process();
//    //p.StartInfo.FileName = path;
//    //p.Start();

//}

//CREATE TABLE selling_contract
//(
//id INT(7) UNSIGNED PRIMARY KEY AUTO_INCREMENT,
//   Buyer_name TEXT,
//    Buyer_card TEXT,
//    Buyer_address TEXT,
//    Seller_name TEXT,
//    Seller_card TEXT,
//    Seller_address TEXT,
//    Car_number TEXT,
//    Car_model TEXT,
//    Car_mark TEXT,
//    Car_shaseh TEXT,
//    Car_motor TEXT,
//    Car_kind TEXT,
//    Car_color TEXT,
//    Car_shape TEXT,
//    Total_price INT(255),
//    Paid_price INT(255),
//    Remain_price INT(255),
//    Daily_rent INT(255),
//    Penalty_clause TEXT,
//    Auth_date DATETIME,
//    Created_date  DATETIME,
//    Created_time  DATETIME


//);
