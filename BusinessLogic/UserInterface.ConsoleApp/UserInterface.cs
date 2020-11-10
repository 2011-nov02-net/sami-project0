using System;
using System.Collections.Generic;
using BusinessLogic;


namespace UserInterface.ConsoleApp
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Flowerworks! Please enter your first name");
            
            Console.WriteLine("Please enter your name:");
            string cusName= Console.ReadLine();
           //makes customer list need to move out of main
            List<string> CustomerNameList = new List<string>();
            CustomerNameList.Add(cusName);
            CustomerNameList.ForEach(Console.WriteLine);

            //print dictionary test
            Dictionary<string,string> store = new Dictionary<string, string>
            {
                { "Flowerworks - Dallas", "0001" },
                { "Flowerworks - Fort Worth", "0002" },
                { "Flowerworks - Addison", "0003" }
            };
            foreach (var kvp in store)
                Console.WriteLine("Store location is: {0} The store number is: {1}", kvp.Key, kvp.Value);


        }

    }
}
