namespace OOPAdventure
{
    public interface IInventory
    {
        int Total { get; }
        void Add(Item item);
        bool Contains(string itemName);
        Item? Find(string itemName);
        Item? Find(string itemName, bool remove);
        void Remove(Item item);
        Item? Take(string itemName);
        void Use(string itemName, string source);

        public string[] InventoryList { get; }
    }
}