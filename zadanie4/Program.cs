class Osoba
{
    public string Imie;
    public int Wiek;
    public void PrzedstawSie()
    {
        Console.WriteLine($"Jestem {Imie}, mam {Wiek} lat.");
    }
    public Osoba(string Imie, int Wiek)
    {
        this.Imie = Imie;
        this.Wiek = Wiek;
    }
}
class Program
{
    static void Main()
    {
        Osoba o = new Osoba("Teodor", 37);
        Osoba o1 = new Osoba("Fiona", 24);
        Osoba o2 = new Osoba("Beatrycze", 56);
        Osoba o3 = new Osoba("Herman", 45);
        o.PrzedstawSie();
        o1.PrzedstawSie();
        o2.PrzedstawSie();
        o3.PrzedstawSie();
    }
}
