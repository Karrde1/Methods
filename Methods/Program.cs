/* Author: Gregory Gauthier
 * Date: 1/25/2019
 * Comments: This Program Will Demonstrate Methods
 */

using System;

namespace Methods
{
    class Program
    {
         static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Greetings User! \n Please Enter your Name!");
                UserInput(Console.ReadLine());
                
            }

            catch
            {
                Console.WriteLine("Please Enter a Valid Name and Try Again");
                Console.WriteLine("Press Any Key To Exit The Program");
                Console.ReadKey(true);
            }

        }

        static void UserInput(string UserName)

        {
            Console.WriteLine("Hello " + UserName);
            Console.ReadKey(true);

        }
    }


}

