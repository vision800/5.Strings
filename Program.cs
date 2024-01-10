using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This will write on the same line");
            Console.WriteLine("This will \n write on the second line");
            Console.WriteLine("This will \" will print out quoted mark");

            string firstName = "Vision";
            string lastName = "Netshokotshoko";

            //concatitate strings
            Console.WriteLine(firstName + " " + lastName);

            //string length
                Console.WriteLine(lastName.Length);

            //STRING TO UPPERS CASE
                Console.WriteLine(firstName.ToUpper());
            //STRING TO UPPERS CASE
            Console.WriteLine(firstName.ToLower());

            //check char avalability in a string
            Console.WriteLine(lastName.Contains("ko"));

            //Access char with an index
            Console.WriteLine(firstName[0]);
            //get the index of the char
            Console.WriteLine(lastName.IndexOf("t"));
            //get the substring
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName.Substring(1,2));

        }
    }
}
