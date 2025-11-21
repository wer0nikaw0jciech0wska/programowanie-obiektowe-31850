class Zwierze
{
    public virtual void DajGlos() => Console.WriteLine("Zwierzę wydaje dźwięk");
}
class Pies : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Hau hau!");
}
class Kot : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Miau!");
}
class Kura : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Kokoko!");
}
class Kaczka : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Kwa kwa!");
}
class Krowa : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Moooooo!");
}
class Program
{
    static void Main()
    {
        Zwierze[] zwierzeta = { new Pies(), new Kot(), new Kura(), new Kaczka(), new Krowa() };
        foreach (var zw in zwierzeta)
        {
            zw.DajGlos();
        }
    }
}