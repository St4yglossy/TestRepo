using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            int attempts = 0;

            //Password Prompt
            Console.WriteLine("Please enter the password");
            string password = Console.ReadLine();

            for (; password != "5678";)
            {
                attempts++;

                if (attempts >= 3)
                {
                    Console.WriteLine("You have reached the maximum attempts to log in!");
                    //display after 3 attempts have been made
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Wrong Password. Please try again ");

                Console.WriteLine("Please enter the password");
                password = Console.ReadLine();

            }//end of password loop


            //start of Vacation app 

            string keepGoing = "y";
            while (keepGoing == "y" && password == "5678")
            {

                //Welcome message for app
                Console.WriteLine("Thank you for using the Vacation Budget Planning App");
                Console.WriteLine();

                //asking User name and user enter name
                Console.WriteLine("Please enter your name?");
                //User enters name
                string askname = Console.ReadLine();
                Console.WriteLine();
                //Greeting user
                Console.WriteLine($"Hello {askname} where would you like to travel? Please enter (1) Mexico or (2) Jamaica");

                //Switch statement for either Mexico or Jamaica 
                int traveldest = Convert.ToInt16(Console.ReadLine());

                switch (traveldest)
                {
                    case 1: //for mexico
                        Console.WriteLine("Great, Mexico  sounds like an amazing trip!");

                        Console.WriteLine("*****************************");

                        //days spent in destination 
                        Console.WriteLine("How Many days would you like to spend on the trip?");
                        int days = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine($"You have enter {days} days that you would like to spend in Mexico");
                        Console.WriteLine("How Much Money do you plan to spend on the trip ?");
                        double money2 = Convert.ToDouble(Console.ReadLine());
                        double tSpend2 = money2 / days;
                        Console.WriteLine($"Hey {askname},you are going to Mexico for {days} days with {money2:C} spending money. You can spend {tSpend2:C} a day");
                        Console.ReadLine();

                        //calculate total hours on the trip 
                        const int hoursInDay = 24;
                        int hours = (hoursInDay * days);
                        int minutes = (1440 * days);
                        Console.WriteLine($"The total amount of time you will spend on your trip in minutes is {minutes} minutes. The total number of Hours you will spend on your trip is {hours} hours");


                        //convert USD to Peso 
                        const double pesoExchangeRate = 23.87;
                        double peso = money2 * pesoExchangeRate;
                        Console.WriteLine($"Given {money2:c} in US dollars you will have {peso:C} in peso to spend");


                        //amount to spend per day in Peso
                        Console.WriteLine($"The amount you will have in Peso per day to spend is {(peso / days):C}");
                        Console.ReadLine();

                        Console.WriteLine("Enjoy your trip");
                        break;

                    case 2: //for jamaica 
                        Console.WriteLine("Great, Jamaica is an amazing trip");

                        Console.WriteLine("*****************************");

                        //days spent in destination 
                        Console.WriteLine("How Many days would you like to spend on the trip?");
                        days = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine($"You have enter {days} days that you would like to spend in Jamaica");
                        Console.WriteLine("How Much Money do you plan to spend on the trip ?");
                        money2 = Convert.ToDouble(Console.ReadLine());
                        tSpend2 = money2 / days;
                        Console.WriteLine($"Hey {askname},you are going to Jamaica for {days} days with {money2:C} spending money. You can spend {tSpend2:C} a day");
                        // Console.ReadLine();

                        //calculate total hours on the trip 
                        hours = (hoursInDay * days);
                        minutes = (1440 * days);
                        Console.WriteLine($"The total amount of time you will spend on your trip in minutes is {minutes} minutes. The total number of Hours you will spend on your trip is {hours} hours");


                        //convert USD to Jamician Dollars
                        const double jamExchangeRate = 145.49;
                        double jDollars = money2 * jamExchangeRate;
                        Console.WriteLine($"Given {money2:C} in US dollars you will have {jDollars:C} in jamician dollars to spend");


                        //amount to spend per day in Jamician Dollars
                        Console.WriteLine($"The amount you will have in Jamician Dollars per day to spend is {(jDollars / days):C}");
                        Console.ReadLine();

                        Console.WriteLine("Enjoy your trip");
                        break;

                    default:
                        Console.WriteLine("You can only select from Mexico or Jamaica. Please try again");
                        break;

                }// end of switch 

                Console.WriteLine();
                Console.WriteLine("Would you like to select another trip? Enter y for Yes and n for No");
                keepGoing = Console.ReadLine().ToLower();

            }//end of vacation while 







        }
    }
}

