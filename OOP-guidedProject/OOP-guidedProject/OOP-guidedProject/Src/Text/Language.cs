namespace OOPAdventure
{
    public abstract class Language
    {
        public string Welcome { get; protected set; } = "";
        public string ChooseYourName { get; protected set; } = "";
        public string DefualtName { get; protected set; } = "";
        public string DefaultRoomDescription { get; protected set; } = "";
        public string DefaultRoomName { get; protected set; } = "";

    }
}