using System;

namespace Warehouse
{
    public class Warehouse
    {

        public string Name { get; set; }

        int Budget { get; set; }

        public Dictionary<Item, int> CurrentItems { get; set; }

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
                Console.WriteLine($"{item.Value} {item.Key.Name}s.");
            };
        }

        private void addItem(Item item, int amount, int price){
            var total = amount * price;
            if (Budget > total)
            {
                CurrentItems[item] += amount;
                Budget -= total;
                Console.WriteLine($"You purchased {amount} {item}s. It cost you {total}.");
                Console.WriteLine($"Your remaining budget is {Budget}");
            }
        }
    }
}