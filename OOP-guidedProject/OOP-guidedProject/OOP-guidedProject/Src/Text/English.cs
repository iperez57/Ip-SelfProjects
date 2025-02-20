namespace OOPAdventure
{
    public class English : Language
    {
        public English()
        {
            ChooseYourName = "Hello, what is your name?";
            DefualtName = "No Name";
            Welcome = "Welcome {0} to your OOP Adventure!";
            DefaultRoomName = "Room {0} ({1},{2})";
            DefaultRoomDescription = " You are in a room {0} with doors to the {1}.";
            ActionError = "You can't do that.";
            Go = "Go";
            GoError = "You can't go that way.";
            WhatToDo = "What do you want to do?";
            Quit = "quit";
            RoomNew = "You entered {0}";
            RoomNew = "You returned to  {0}";
            And = "and";
            Comma = ",";
            Space = " ";
            RoomDescriptions = new List<string>
            {
                "normal",
                "cold",
                "warm",
                "dark",
                "bright",
                "scary",
                "strange"
            };
            NoItem = "You don't have that";

            Backpack = "Backpack";
            BackpackError = "You don't have anything in your backpack.";
            BackpackDescription = "You have {0} in your backpack";

            Chest = "Chest";
            UnlockChest = "You unlocked the chest";
            Key = "Key";
            ChestEmpty = "The chest is empty";
            ChestFound = "You found: {0}";
            Gold = "{0} gold {1}";
            Coin = "coin";
            Coins = Coin + "s";
            Plural = "s";
            Is = "is";
            Are = "are";
            TotalItems = " There {0} {1} item{2} in the room.";
            Period = ".";
            Take = "take";
            TakeError = "There is nothing to take";
            NotTaken = "You can't take that";
            TookDescription = "You took the {0}";
            CantTakeDescription = "You can't take the {0}";
        }
    }
}