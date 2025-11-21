class Zwierze
{
    public void Jedz() => Console.WriteLine("Zwierzę je");
}
class Pies : Zwierze
{
    public void Szczekaj() => Console.WriteLine("Hau hau!");
}
class Kot : Zwierze
{
    public void Miaucz() => Console.WriteLine("Miau miau!");
}