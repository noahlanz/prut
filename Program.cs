Console.WriteLine("************************************************");
Console.WriteLine("Prut Program");
Console.WriteLine("************************************************");

Console.WriteLine("Creating media player...");
var mp = new System.Media.SoundPlayer();

Console.WriteLine("Loading sound file...");
var soundFile = "C:\\Users\\noah\\Development\\prut\\sounds\\reverbing_fart.wav";
mp.SoundLocation = soundFile;
mp.Load();

Console.WriteLine("Playing sound...");
mp.Play();

Console.WriteLine("Press [Enter] to close...");

Console.ReadLine();