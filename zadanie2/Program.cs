int liczba = 0;
string liczbaTmp;
do
{
    Console.Write("Podaj liczbe: ");
    liczbaTmp = Console.ReadLine();
    liczba = int.Parse(liczbaTmp);
}
while (liczba <= 0);
Console.Write("Sukces!");