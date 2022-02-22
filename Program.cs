using System;

namespace Warehouse 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var items = new Dictionary<Item, int>();
            items.Add(new Item("Fish Bowl", 4.5), 10);
            items.Add(new Item("Frying Pan", 3), 40);
            items.Add(new Item("Feather", 0.1), 1500);
            items.Add(new Item("Fork", 2), 100);
            items.Add(new Item("Fiddle", 40), 50);

            var Jimmys = new Warehouse("Jimmy's place", 10000, items);

            Jimmys.showStock();
        }
    }
}