using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StartSequence();
            }
            catch (Exception a)
            {

            }
            finally
            {
                Console.WriteLine("Program is complete");
            }
        }

        static void StartSequence()
        {

            // console welcoming  user to name 
            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Please enter a number greater than zero");

            // user inputs number 
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            int[] userArray = new int[number];
            //   Populate(userArray);
            // GetSum(userArray);


        }
        /* static int[] Populate(int[] userArray)
         {

         }

         static int GetSum(int[] sumArray)
         {

         }
         */

    }
}