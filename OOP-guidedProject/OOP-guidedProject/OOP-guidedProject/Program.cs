using OOPAdventure;


var language = new English();

Console.WriteLine(language.ChooseYourName);

var name = Console.ReadLine();

if (name == string.Empty)
    name = "No Name";

var player = new Player(name);

Console.WriteLine($"Welcome {player.Name} to your OOP Adventure!");