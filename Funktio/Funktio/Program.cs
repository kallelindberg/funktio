using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktio
{
    class Program
    {
        static bool Stars(int input)
        {
            if (input >= 0)
            {
                while (input > 0)
                {
                    Console.Write("*");
                    input--;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Anna positiivinen numero");
                return false;
            }
        }
        static String Minimi(int number1, int number2)
        {
            String output;
            if (number1 >= number2) output = "eka oli isompi";
            else if (number1 <= number2) output = "toka oli isompi";
            else if (number1 == number2) output = "Yhtäsuuret";
            else output = "Voe helevettilääne";
            return output;
        }
        static int RequestNumber(int number1, int number2)
        {
            int luku = 0;
            bool result = false;
            Console.WriteLine("Anna luku");
            while (result == false)
            {
                String lukustr = Console.ReadLine();
                result = Int32.TryParse(lukustr, out luku);
                if (result && number1 <= luku && number2 >= luku)
                {}
                else
                {
                    result = false;
                    Console.WriteLine("Anna parempi luku");
                }
             }
           return luku;
        }
        static void Main(string[] args)
        {
            // For triggering the first function
            //            bool result = false;
            //            while (result == false)
            //            {
            //                Console.WriteLine("Anna numero?: ");
            //                try
            //                {
            //                   int i = Int32.Parse(Console.ReadLine());
            //                    result = Stars(i);
            //                }
            //                catch (Exception e)
            //                {
            //                    Console.WriteLine("NUMERO!!! ");
            //                }
            //            }


            //For triggering the second function
            //Console.WriteLine(Minimi(2, 3));

            //For triggering the third function
            //Console.WriteLine(RequestNumber(10, 12));
            //Console.ReadKey();
        }
    }
}
