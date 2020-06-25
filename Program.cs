using System;

namespace Bill_Share
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diners asking their bill for the night
            Console.WriteLine("What is our bill");
            //Waiter telling diners thier bill

            double bill = Convert.ToInt32(Console.ReadLine());

            //waiter asking diners how many of them are paying
            Console.WriteLine("How many of you are sharing the bill");
            //Waiter asking how many of them are paying
            int diners = Convert.ToInt32(Console.ReadLine());

            //Make the cut and tell diners their shares
            double eachShare = bill/diners;
            Console.WriteLine("Each Diner Will pay {0}", eachShare);
            //handling dividing by zero exception
            /*try
            {  
                diners = 0;
                eachShare = bill/diners;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero", ex.Message);
            }
            */
        }

    }
}