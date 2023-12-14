// Comment

//rakendus küsib kasutaja nime
//rakendus tervitab nimepidi

Console.WriteLine("Enter you name:");
//string - sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + " " + userName + "!");

//string interpolation
Console.WriteLine($"Hello, {userName}!");
