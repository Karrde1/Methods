/* Author: Gregory Gauthier
 * Date: 1/25/2019
 * Comments: This Program Will Demonstrate Methods
 */

using System;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Greetings User! \n Please Enter your Name!");
            Console.ReadKey(true);
            Console.WriteLine("Please Enter Your Name");

            try
            {
                string UserInput = Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Please Enter a Valid Name and Try Again");
                Console.WriteLine("Press Any Key To Exit The Program");
                Console.ReadKey(true);
            }

        }

        }
    }

private void UserReturn()
{
    Console.WriteLine("Hello" + UserInput.ToString());

}