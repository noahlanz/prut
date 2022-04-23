using Noah.PrutProject;

Console.WriteLine("************************************************");
Console.WriteLine("Prut Program");
Console.WriteLine("************************************************");

var soundFile = "C:\\Users\\noah\\Development\\prut\\sounds\\reverbing_fart.wav";

Console.WriteLine("Playing sound at: " + soundFile);
new FartPlayer(soundFile).Play();

Console.WriteLine("Done.");
Console.WriteLine("Press [Enter] to quit.");
Console.ReadLine();
