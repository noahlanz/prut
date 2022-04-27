using Noah.PrutProject;

Console.WriteLine("************************************************");
Console.WriteLine("Prut Program");
Console.WriteLine("************************************************");

var soundFile = "sounds/reverbing_fart.wav";

Console.WriteLine("This is the sound file: " + soundFile);
var fp = new FartPlayer(soundFile);

Console.WriteLine("Press [Space] to play sound.");
Console.WriteLine("Press [Esc] to quit.");

while (true) {
    var key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.Escape) {
        Console.WriteLine("User pressed [Esc]. Breaking...");
        break;
    }
    if (key.Key == ConsoleKey.Spacebar) {
        Console.WriteLine("Playing a sound: " + soundFile);
        fp.Play();
    }
}
