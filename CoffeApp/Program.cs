namespace CoffeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderService();
            order.ProcessOrder();
        }
    }
}
