using System.Text;

namespace OOPAdventure
{
    public class Room : IInventory
    {
        public string Name { get; set; } = Text.Language.DefaultRoomName;
        public string Description { get; set; } = Text.Language.DefaultRoomDescription;
        private readonly IInventory _items = new Inventory();
        public Dictionary<Directions, int> Neighbors { get; set; } = new()
        {
            {Directions.North, -1 },
            {Directions.South, -1 },
            {Directions.East, -1 },
            {Directions.West, -1 },
            {Directions.None, -1 },

        };
        public bool Visited { get; set; }

        public int Total => throw new NotImplementedException();

        public string[] InventoryList => throw new NotImplementedException();

        public override string ToString()
        {
            var sb = new StringBuilder();

            if(Visited)
                sb.Append(string.Format(Text.Language.RoomOld, Name));
            else 
                sb.Append(string.Format(Text.Language.RoomNew, Name));  

            var names = Enum.GetNames(typeof(Directions));

            var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select
                              p.ToLower()).ToArray();

            var description = string.Format(Description, Text.Language.JoinWordList(directions, Text.Language.And));

            sb.Append(description);

            return sb.ToString();
        }

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
