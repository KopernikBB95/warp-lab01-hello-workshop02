Console.WriteLine("Witaj w warsztacie programisty!");
Console.Write("Dzisiaj jest: ");
Console.WriteLine(DateTime.Today.ToString("d"));
Console.WriteLine("Podaj swoje imie:");
string imie = Console.ReadLine()!;
Console.WriteLine($"Powodzenia {imie}!");