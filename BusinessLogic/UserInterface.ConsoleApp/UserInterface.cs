using System;
using BusinessLogic;


namespace UserInterface.ConsoleApp
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Flowerworks! Please enter your first name");
            Console.WriteLine("Please enter your first name:");
            string firstName= Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            new CustomerName(firstName, lastName);
            
        }

    }
}
