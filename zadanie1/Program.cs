string password = "0";
while (password != "admin123")
{
    Console.Write("Podaj haslo: ");
    password = Console.ReadLine();
    if (password!= "admin123")
    {
        Console.WriteLine("Haslo niepoprawne. Sprobuj ponownie");
    }
}
Console.WriteLine("Zalogowano pomyslnie!");
