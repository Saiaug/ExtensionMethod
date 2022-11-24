using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string str;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Extensions.Tocurrency(str);


        }

        

         


    }

    public static class Extensions
    {
        public static string Tocurrency(this string dollar)
        {
            if (Regex.IsMatch(dollar, @"^\d+$"))
            {
                
                Console.WriteLine($"current currency is: ${dollar}");
                Console.ReadKey();
               
                

                return dollar;


            }
            
                else
            {
                throw new InvalidOperationException("Invalid number");
            }
                
            




        }
    }
}
