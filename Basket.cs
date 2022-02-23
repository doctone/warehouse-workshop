namespace Warehouse
{
    public class Basket
    {
        List<Item> Items { get; set; }
        
        public Basket(List<Item> items)
        {
            Items = items;
        }

        public List<Item> AddItemToBasket(Item item)
        {
            Items.Add(item);
            return Items;
        }
    }
}