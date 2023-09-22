using System;
using System.Collections.Generic;

namespace Carproject
{
    class NewBillSingleton
    {

        private static int id;
        private static string buyer_name;
        private static string buyer_phone;
        private static string insurence_phone;
        private static string restrict_sell_for;
        private static string notes;
        private static CarHelperModel carHelperModel_sold;
        private static int total_price;
        private static int paid_price;
        private static int rest_price;
        private static DateTime first_pay_date;
        private static bool structed;
        private static List<Installments> installments;

        public static bool struct_the_bill(int id1,
            string buyer_name1,
            string buyer_phone1,
            string insurence_phone1,
            string restrict_sell_for1,
            string notes1,
            int total_price1,
            int paid_price1,
            int rest_price1,
            DateTime first_pay_date1
            )
        {
            id = id1;
            buyer_name = buyer_name1;
            buyer_phone = buyer_phone1;
            insurence_phone = insurence_phone1;
            restrict_sell_for = restrict_sell_for1;
            notes = notes1;

            total_price = total_price1;
            rest_price = rest_price1;
            paid_price = paid_price1;
            first_pay_date = first_pay_date1;


            structed = true;
            return structed;
        }

        public static bool delete_the_bill()
        {
            if (structed == true)
            {
                id = 0;
                buyer_name = null;
                buyer_phone = null;
                insurence_phone = null;
                restrict_sell_for = null;
                notes = null;

                total_price = 0;
                rest_price = 0;
                paid_price = 0;
                installments = null;
                structed = false;
                return true;
            }
            else { return false; }

        }

        ////setters and getters 
        public static int get_id()
        { return id; }



        public static string get_buyer_name()
        { return buyer_name; }
        public static void set_buyer_name(string element)
        { NewBillSingleton.buyer_name = element; }

        public static string get_buyer_phone()
        { return buyer_phone; }
        public static void set_buyer_phone(string element)
        { NewBillSingleton.buyer_phone = element; }

        public static string get_insurence_phone()
        { return insurence_phone; }
        public static void set_insurence_phone(string element)
        { NewBillSingleton.insurence_phone = element; }

        public static string get_restrict_sell_for()
        { return restrict_sell_for; }
        public static void set_restrict_sell_for(string element)
        { NewBillSingleton.restrict_sell_for = element; }

        public static string get_notes()
        { return notes; }
        public static void set_notes(string element)
        { NewBillSingleton.notes = element; }


        public static int get_total_price()
        { return total_price; }
        public static void set_total_price(int element)
        { NewBillSingleton.total_price = element; }

        public static int get_rest_price()
        { return rest_price; }
        public static void set_rest_price(int element)
        { NewBillSingleton.rest_price = element; }

        public static int get_paid_price()
        { return paid_price; }
        public static void set_paid_price(int element)
        { NewBillSingleton.paid_price = element; }

        public static DateTime get_first_pay_date()
        { return first_pay_date; }
        public static void set_first_pay_date(DateTime element)
        { NewBillSingleton.first_pay_date = element; }

        public static bool get_structed_notation()
        { return structed; }
        public static void set_structed_notation(bool element)
        { NewBillSingleton.structed = element; }

        public static void set_installments(List<Installments> arr)
        {
            NewBillSingleton.installments = arr;
        }
        public static List<Installments> get_installments()
        {
            return installments;
        }
    }
}
