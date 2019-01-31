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
                string UserInput = Console.ReadLine();
                HelloUser();
            }

            catch
            {
                Console.WriteLine("Please Enter a Valid Name and Try Again");
                Console.WriteLine("Press Any Key To Exit The Program");
                Console.ReadKey(true);
            }

        }

        private void HelloUser(string UserInput)

        {
            string UserName = UserInput;
            Console.WriteLine("Hello" + UserName);
            Console.ReadKey(true);

        }
    }


}

