using System;

namespace Warehouse
{
    public class Warehouse
    {

        string Name { get; set; }

        decimal Budget { get; set; }

        Dictionary<Item, int> CurrentItems { get; set; }

        public Warehouse(string name, int budget, Dictionary<Item, int> currentItems)
        {
            Name = name;
            Budget = budget;
            CurrentItems = currentItems;
        }

        public void showStock()
        {
            Console.WriteLine($"Current stock for {Name} warehouse:");
            foreach (var item in CurrentItems)
            {
                Console.WriteLine($"    {item.Value} {item.Key.Name}s.");
            };
        }

        public void addItem(Item item, int amount){
            var total = amount * item.Price;
            if (Budget > total)
            {   // Below line not working
                CurrentItems.ContainsKey(item) ? CurrentItems[item] += amount : CurrentItems[item] = amount;
                Budget -= total;
                Console.WriteLine($"You purchased {amount} {item}s. It cost you {total}.");
                Console.WriteLine($"Your remaining budget is {Budget}");
            }
        }
    }
}