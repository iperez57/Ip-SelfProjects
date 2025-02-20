namespace OOPAdventure
{
    public class Player : Character, IInventory
    {
        private readonly IInventory _inventory;
  
        public Player(string name) : base(name) 
        {
            _inventory = new Inventory();
        }

        public int Total => throw new NotImplementedException();

        public string[] InventoryList => _inventory.InventoryList;

        public void Add(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(string itemName)
        {
            throw new NotImplementedException();
        }

        public Item? Find(string itemName)
        {
            throw new NotImplementedException();
        }

        public Item? Find(string itemName, bool remove)
        {
            throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public Item? Take(string itemName)
        {
            throw new NotImplementedException();
        }

        public void Use(string itemName, string source)
        {
            throw new NotImplementedException();
        }
    }
}