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
namespace Carproject
{
    public partial class UnOrgInstaWF : Form
    {
        
        private int current_value;
        private string error;
        private List<Installments> install_array;
        int insert_count = 0;
        public UnOrgInstaWF()
        {
            InitializeComponent();

            if (ValidatingFunctions.edit_installs_sign == true)
            {
                this.Text = "تعديل الأقساط";
                groupBox1.Text = "تعديل الأقساط";
                confirm_installs.Text="حفظ التعديلات";
                install_value.Maximum = NewBillSingleton.get_rest_price();
                label5.Text = NewBillSingleton.get_rest_price().ToString();
                date_to_pay.Value = NewBillSingleton.get_first_pay_date();
                comboBox1.SelectedIndex = 1;
                current_value = NewBillSingleton.get_rest_price();
                error = "";
                income_gridview.Columns[5].DefaultCellStyle.Format = "dd MMMM yyyy";
            }
            else
            {
                install_value.Maximum = NewBillSingleton.get_rest_price();
                label5.Text = NewBillSingleton.get_rest_price().ToString();
                date_to_pay.Value = NewBillSingleton.get_first_pay_date();
                comboBox1.SelectedIndex = 1;
                current_value = NewBillSingleton.get_rest_price();
                error = "";
                income_gridview.Columns[5].DefaultCellStyle.Format = "dd MMMM yyyy";

            }
            discount.Maximum = install_value.Maximum;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewBillSingleton.delete_the_bill();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void add_install_Click(object sender, EventArgs e)
        {
            string note = notes.Text;
            error = "";
            int index = comboBox1.SelectedIndex;
            if (install_value.Value > 0)
            {
                if (date_to_pay.Value != null)
                {
                    try
                    {
                        var date = date_to_pay.Value.ToShortDateString();
                        current_value = current_value - int.Parse(install_value.Value.ToString());
                        income_gridview.Rows.Add(new string[] {(income_gridview.Rows.Count+1).ToString(),install_value.Value.ToString(),
                    install_value.Value.ToString(),
                    install_value.Value.ToString(),
                    "لم يدفع",
                    date_to_pay.Value.ToString("dd MMMM yyyy"),
                    notes.Text});

                        if (current_value <= 0)
                        {
                            add_install.Enabled = false;
                        }
                        label5.Text = current_value.ToString();
                        install_value.Maximum = current_value;
                        notes.Clear();
                        if (current_value == 0)
                        { confirm_installs.Enabled = true; }

                        //date_to_pay.MinDate = date_to_pay.Value;
                        if (index == 0) { date_to_pay.Value = date_to_pay.Value.AddDays(7); }
                        else { date_to_pay.Value = date_to_pay.Value.AddMonths(1); }
                    }
                    catch(Exception er)
                    {
                        error = "برجاء تحديد مبلغ مالي صحيح";
                    }
                }
                else
                { error = "برجاء تحديد تاريخ مناسب"; }
            }
            else { error = "برجاء تحديد مبلغ مالي صحيح"; }
            if (!error.Equals(""))
            { MessageBox.Show(error); }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidatingFunctions.ResetAllControls(new List<Control>() { install_value, label5, notes, income_gridview });
            income_gridview.Rows.Clear();
            income_gridview.DataSource = null;
            income_gridview.Refresh();

            confirm_installs.Enabled = false;
            label5.Text = NewBillSingleton.get_rest_price().ToString();
            date_to_pay.MinDate = NewBillSingleton.get_first_pay_date();
            date_to_pay.Value = NewBillSingleton.get_first_pay_date();
            add_install.Enabled = true;
            current_value = NewBillSingleton.get_rest_price();
            if (current_value > 0)
            {
                add_install.Enabled = true;
                install_value.Maximum = current_value;
            }
            if (income_gridview.Rows.Count >= 1)
            {
                comboBox1.Enabled = false;
            }
            else
            { comboBox1.Enabled = true; }
           
            
        }

        private void delete_selected_Click(object sender, EventArgs e)
        {
            if (income_gridview.Rows.Count >= 1)
            {
                current_value += int.Parse(income_gridview.Rows[income_gridview.Rows.Count - 1].Cells[1].Value.ToString());
                label5.Text = current_value.ToString();
                confirm_installs.Enabled = false;
                if (income_gridview.Rows.Count > 1)
                {
                   // date_to_pay.MinDate = DateTime.Parse(income_gridview.Rows[income_gridview.Rows.Count - 1].Cells[5].Value.ToString());
                    date_to_pay.Value = DateTime.Parse(income_gridview.Rows[income_gridview.Rows.Count -1].Cells[5].Value.ToString());
                }
                else 
                { 
                    //date_to_pay.MinDate = NewBillSingleton.get_first_pay_date();
                    date_to_pay.Value = NewBillSingleton.get_first_pay_date();
                }
                income_gridview.Rows.RemoveAt(income_gridview.Rows.Count - 1);
            }
            if (current_value > 0)
            { add_install.Enabled = true;
            install_value.Maximum = current_value;
            
            }
            if (income_gridview.Rows.Count >= 1)
            {
                comboBox1.Enabled = false;
            }
            else
            { comboBox1.Enabled = true; }
        }

        private void confirm_installs_Click(object sender, EventArgs e)
        {
            List<int> arr_id=new List<int>(){};
            if (ValidatingFunctions.edit_installs_sign == true)
            {
                var confirmResult = MessageBox.Show("متابعة؟",
                                         "حفظ التعديل",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        List<Installments> install_array1 = new List<Installments>();
                        // NewBillSingleton.set_installments(null);
                        for (int i = 0; i < income_gridview.Rows.Count; i++)
                        {
                            install_array1.Add(new Installments(NewBillSingleton.get_id(),
                                int.Parse(income_gridview.Rows[i].Cells[1].Value.ToString()),
                                income_gridview.Rows[i].Cells[6].Value.ToString(),
                                DateTime.Parse(income_gridview.Rows[i].Cells[5].Value.ToString())));
                        }

                        MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                        con.Open();
                        MySqlCommand check_cmd = con.CreateCommand();
                        check_cmd.CommandText = "SELECT installs.id FROM installs WHERE installs.To_pay_price=installs.Total_price AND installs.bill_id=@id;";
                        check_cmd.Parameters.AddWithValue("id", NewBillSingleton.get_id());
                        MySqlDataReader rd = check_cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            arr_id.Add(int.Parse(rd[0].ToString()));
                        }
                        rd.Close();
                        
                      
                        
                            
                        foreach (Installments ins in install_array1)
                        {
                            insert_count += 1;
                            MySqlCommand cmd_installs = con.CreateCommand();
                            //string id_key = id.ToString() + counter.ToString();
                            cmd_installs.CommandText = "INSERT INTO installs(bill_id,Total_price,To_pay_price,Paid_price,Stat,Paying_date,Notes) VALUES(@bill_id,@Total_price,@To_pay_price,@Paid_price,@Stat,@Paying_date,@Notes);";
                            //cmd_installs.Parameters.AddWithValue("@id1", id_key);
                            cmd_installs.Parameters.AddWithValue("@bill_id", NewBillSingleton.get_id());
                            cmd_installs.Parameters.AddWithValue("@Total_price", ins.get_total_price());
                            cmd_installs.Parameters.AddWithValue("@To_pay_price", ins.get_to_pay_price());
                            cmd_installs.Parameters.AddWithValue("@Paid_price", ins.get_remain());
                            cmd_installs.Parameters.AddWithValue("@Stat", ins.get_stat());
                            cmd_installs.Parameters.AddWithValue("@Paying_date", ins.get_paying_date());
                            cmd_installs.Parameters.AddWithValue("@Notes", ins.get_notes());
                            cmd_installs.ExecuteNonQuery();
                        }
                        for (int i = 0; i < arr_id.Count; i++)
                        {
                            MySqlCommand delete_cmd = con.CreateCommand();
                            delete_cmd.CommandText = "DELETE FROM installs WHERE installs.id=@id;";
                            delete_cmd.Parameters.AddWithValue("id", int.Parse(arr_id.ElementAt(i).ToString()));
                            delete_cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("تم أضافة " + insert_count.ToString() + " قسط جديد ");
                        this.Close();
                    //}
                    //else { MessageBox.Show(count.ToString()+"ddd"+install_array1.Count.ToString());
                    //this.Close();
                    //}
                    }
                    
                    catch (MySqlException ee)
                    {
                        if (ee.ToString().Contains("entry"))
                        { MessageBox.Show("رقم الفاتورة مكرر"); }
                        else
                        {


                             MessageBox.Show("خطأ في السيرفر"); 

                        }
                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show("خطأ"); 
                    }
                }
                else { }
            }





            else
            {
                var confirmResult = MessageBox.Show("متابعة؟",
                                         "حفظ الأقساط",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    install_array = new List<Installments>();
                    NewBillSingleton.set_installments(null);
                    for (int i = 0; i < income_gridview.Rows.Count; i++)
                    {
                        install_array.Add(new Installments(NewBillSingleton.get_id(),
                            int.Parse(income_gridview.Rows[i].Cells[1].Value.ToString()),
                            income_gridview.Rows[i].Cells[6].Value.ToString(),
                            DateTime.Parse(income_gridview.Rows[i].Cells[5].Value.ToString())));


                    }
                    NewBillSingleton.set_installments(install_array);
                    this.Close();
                    Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
                    BellUI main = (BellUI)form1.Controls.OfType<BellUI>().ToList().ElementAt(0);
                    int counter = 1;
                    foreach (Installments element in NewBillSingleton.get_installments())
                    {
                        string stat = "";
                        if (element.get_stat() == true)
                        { stat = "مدفوع"; }
                        else { stat = "لم يدفع"; }
                        main.dataGridView1.Rows.Add(new String[]{counter.ToString(),
                    element.get_total_price().ToString(),
                    element.get_to_pay_price().ToString(),
                    element.get_remain().ToString(),
                    stat,
                    element.get_paying_date().ToString("dd MMMM yyyy"),
                    element.get_notes()});
                        counter += 1;

                    }
                    main.add_new_bill_button.Enabled = true;
                }
                else
                { }
            }
        }

       

        private void income_gridview_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (income_gridview.Rows.Count >= 1)
            {
                comboBox1.Enabled = false;
            }
            else
            { comboBox1.Enabled = true; }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnOrgInstaWF_Load(object sender, EventArgs e)
        {

        }

        private void install_value_ValueChanged(object sender, EventArgs e)
        {
           // install_value.Value = int.Parse(install_value.Value.ToString("C"));
        }

        private void install_value_MouseClick(object sender, MouseEventArgs e)
        {
            install_value.Select(0, install_value.Text.Length);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //1- get the discount amount
            //    2- identify the installs in Array
            //        3- identify the pivot 
            //            4-delete
                            MySqlConnection con = new MySqlConnection(ValidatingFunctions.getCONNECTION_STRINGS());
                            con.Open();
                            bool isEqual = false;
            MySqlCommand cmd_installs = con.CreateCommand();
            List<int> installs=new List<int>(){};
            int installs_sum=0;
            int pivot_id=0;
             int previous_sum=0;
            int pivot_deduction_amout=0;
            int bill_id = NewBillSingleton.get_id();
            int amountOfDiscount = Int32.Parse(discount.Value.ToString());
     

                MySqlCommand all_unpaid_installs = con.CreateCommand();
            all_unpaid_installs.CommandText = "SELECT installs.id,installs.To_pay_price FROM installs WHERE installs.bill_id=@bill_id AND NOT installs.To_pay_price=0 ORDER BY Paying_date DESC;";
            all_unpaid_installs.Parameters.AddWithValue("@bill_id", bill_id);
            
                 MySqlDataReader rd = all_unpaid_installs.ExecuteReader();
                        while (rd.Read())
                        {
                            int install_price=int.Parse(rd[1].ToString());
                                int install_id=int.Parse(rd[0].ToString());
                            installs_sum+=install_price;

                            if(installs_sum==amountOfDiscount)
                            {
                                installs.Add(install_id);
                                isEqual = true;
                                break;

                            }
                            else if(installs_sum<amountOfDiscount)
                            {
                                installs.Add(install_id);                                


                            }
                            else
                            {
                                pivot_id = install_id;
                                pivot_deduction_amout = amountOfDiscount - previous_sum;
                                break;
                             

                            }
                             previous_sum = installs_sum;

                        }
                        rd.Close();

                //deletion of
                string msgg;
                if(isEqual)
                { msgg = "ستقوم بمسح " + installs.Count.ToString() + " قسط " + " وتعديل سعر قسط واحد إلي  " + pivot_deduction_amout.ToString(); }
                else{msgg="ستقوم بمسح "+installs.Count.ToString()+" قسط ";}
                var confirmResult = MessageBox.Show(msgg, "مسح",
                                                 
                                                 MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            
                              for (int i = 0; i < installs.Count; i++)
                        {

                            MySqlCommand delete_cmd1 = con.CreateCommand();
                            delete_cmd1.CommandText = "DELETE FROM sub_installs WHERE sub_installs.install_id=@id;";
                            delete_cmd1.Parameters.AddWithValue("id", installs[i]);
                            delete_cmd1.ExecuteNonQuery();
                                  MySqlCommand delete_cmd = con.CreateCommand();
                            delete_cmd.CommandText = "DELETE FROM installs WHERE installs.id=@id;";
                            delete_cmd.Parameters.AddWithValue("id", installs[i]);
                            delete_cmd.ExecuteNonQuery();
                          

                          
                                  
                        }
                            
                                MySqlCommand update_cmd = con.CreateCommand();
                            update_cmd.CommandText = "UPDATE  installs SET installs.To_pay_price=installs.To_pay_price-@deduction,installs.Total_price=Total_price-@deduction+Paid_price WHERE installs.id=@id;";
                            update_cmd.Parameters.AddWithValue("deduction", pivot_deduction_amout);
                            update_cmd.Parameters.AddWithValue("id", pivot_id);
                            
                                update_cmd.ExecuteNonQuery();
                            
                            
                              MySqlCommand bill_cmd = con.CreateCommand();
                            bill_cmd.CommandText = "UPDATE bills SET bills.Total_price=Total_price-@discount,bills.To_pay_price=To_pay_price-@discount WHERE bills.id=@id;";
                            bill_cmd.Parameters.AddWithValue("discount", amountOfDiscount);
                            
                            bill_cmd.Parameters.AddWithValue("id", NewBillSingleton.get_id());
                            bill_cmd.ExecuteNonQuery();
                            MessageBox.Show("تم");
   
                        }
                        else
                        { }
                          
              
               
            //}
            con.Close();
            NewBillSingleton.set_rest_price(NewBillSingleton.get_rest_price() - amountOfDiscount);
            label5.Text = NewBillSingleton.get_rest_price().ToString(); 
        }

        private void income_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
