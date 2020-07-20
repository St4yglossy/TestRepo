using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Calculator App");

            ACalu();

            int result = PCalu(10,8);
            Console.WriteLine($"The Perimetrer of the room is {result}");
            Console.ReadLine();
        }

        //new method that calculates the area
        public static void ACalu()
        {
            
            Console.WriteLine("Please enter room Width");
            string userInputWidth = Console.ReadLine();
            int width = int.Parse(userInputWidth);

            Console.WriteLine("Please enter room Length");
            string userInputLength = Console.ReadLine(); ;
            int length = int.Parse(userInputLength);

            Console.WriteLine($"The area of the room is {width * length}");
            
            
        }

        //new method that calculate the perimeter
        public static int PCalu(int width, int length)
        {
           
           int result = (2 * width) * (2 * length);
            return result;
        }

        
    }
}
