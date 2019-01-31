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

            // Initiate the try block
            try
            {
                // Greet the user then assign UserInput variable to whatever the user enters
                Console.WriteLine("Greetings User! \n Please Enter your Name!");
                UserInput(Console.ReadLine());
                
            }

            // Should the user somehow fail to enter their name, execute the catch 
            catch
            {
                Console.WriteLine("Please Enter a Valid Name and Try Again");
                Console.WriteLine("Press Any Key To Exit The Program");
                Console.ReadKey(true);
            }

        }

        // Here, we are creating an argument for this method to return the value of UserInput previously defined in the other method
        // Because this method is static, we only want it to run once and be complete.
        static void UserInput(string UserName)

        {
            // Display the users name with a greeting
            Console.WriteLine("Hello " + UserName);
            Console.ReadKey(true);

        }
    }


}

