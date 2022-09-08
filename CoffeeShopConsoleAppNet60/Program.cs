using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Have some Covfefe");

        List<Coffee> orderList = new List<Coffee>()
        {
            new Cortado(3),
            new BlackCoffee(4),
            new Latte(5),
            new Cortado(),
            new BlackCoffee(),
            new Latte()
        };

        Console.WriteLine("Printing the orderList");

        foreach(Coffee coffeeItem in orderList)
        {

            Console.WriteLine(coffeeItem.ToString());
        }

        Console.ReadLine();
    }
}