namespace OOPAdventure
{
    public abstract class Item
    {
        public virtual string Name { get; set; }
        public bool SingleUse { get; protected set; }
        public bool CanTake { get; protected set; } = true;
        public virtual void Use(string source)
        {
            throw new NotImplementedException();
        }
    }
}