using System;

namespace CoffeeApp.Services
{
    public class MenuService
    {
        public string GetOption()
        {
            Console.WriteLine("Simple Coffee Ordering App");
            Console.WriteLine("1. Order Coffee");
            Console.WriteLine("2. Order Cappucinno");
            Console.WriteLine("3. Order Latte");
            Console.WriteLine("To turn off the program type: 'off'");

            return Console.ReadLine();
        }
    }
}
