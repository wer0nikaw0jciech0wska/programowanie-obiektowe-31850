class KontoBankowe
{
    private double saldo;
    public void Wplata(double kwota) { saldo += kwota; }
    public double PobierzSaldo() { return saldo; }
    public void Wyplata(double kwota)
    {
        if (kwota>saldo)
        {
            Console.WriteLine("Niewystarczajace srodki na koncie. ");
        }
        else
        {
            saldo -= kwota;
            Console.WriteLine("Wyplacono pomyslnie. ");
        }
    }
}
