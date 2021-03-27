using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{
    class car
    {

        private static string car_number;
        private static string motor_number;
        private static string car_mark;
        private static string car_model;
        private static string shaseh_number;            



        public static string get_car_number()
        { return car_number; }
        public static void set_car_number(string element)
        { car.car_number = element; }

        public static string get_motor_number()
        { return motor_number; }
        public static void set_motor_number(string element)
        { car.motor_number = element; }

        public static string get_car_mark()
        { return car_mark; }
        public static void set_car_mark(string element)
        { car.car_mark = element; }

        public static string get_car_model()
        { return car_model; }
        public static void set_car_model(string element)
        { car.car_model = element; }

        public static string get_shaseh_number()
        { return shaseh_number; }
        public static void set_shaseh_number(string element)
        { car.shaseh_number = element; }
        public static void clear()
        {
            car_number = null;
            motor_number = null;
            shaseh_number = null;
            car_mark = null;
            car_model = null;
 
        }
    }
}
