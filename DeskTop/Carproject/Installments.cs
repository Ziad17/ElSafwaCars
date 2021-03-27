using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{
    class Installments
    {
        private int bill_id;
        private int total_price;
        private int to_pay_price;
        private int remain;
        private bool stat;
        private string notes;
        private DateTime paying_date;
        
        
        
        public Installments(int bill_id1,int total_price1,string notes1,DateTime paying_date1)
        {
            this.bill_id = bill_id1;
            this.total_price = total_price1;
            this.to_pay_price = total_price1;
            this.remain = total_price-to_pay_price;
            this.stat = false;
            this.notes = notes1;
            this.paying_date = paying_date1;
        }
        public int get_bill_id()
        { return bill_id; }

        public void set_total_price(int element)
        { this.total_price = element; }
        public int get_total_price()
        { return this.total_price; }

        public  void set_to_pay_price(int element)
        { this.to_pay_price = element; }
        public int get_to_pay_price()
        { return this.to_pay_price; }


        public void set_remain(int element)
        { this.remain = element; }
        public int get_remain()
        { return this.remain; }


        public void set_stat(bool element)
        { this.stat = element; }
        public bool get_stat()
        { return this.stat; }

        public void set_notes(string element)
        { this.notes = element; }
        public string get_notes()
        { return this.notes; }

        public void set_paying_date(DateTime element)
        { this.paying_date = element; }
        public DateTime get_paying_date()
        { return this.paying_date; }
    }
}
