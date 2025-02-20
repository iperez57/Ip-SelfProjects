namespace OOPAdventure
{
    public class Backpack : Action
    {
        private readonly IInventory _intentory;

        public Backpack(IInventory inventory)
        {
            _intentory = inventory;
        }

        public override string Name => Text.Language.Backpack;

        public override void Execute(string[] args)
        {
            var items = _intentory.InventoryList;

            if(items.Length == 0)
            {
                Console.WriteLine(Text.Language.BackpackError);

                return;
            }
            var list = Text.Language.JoinWordList(items, Text.Language.And);

            Console.WriteLine(Text.Language.BackpackDescription, list);
        }
    }
}