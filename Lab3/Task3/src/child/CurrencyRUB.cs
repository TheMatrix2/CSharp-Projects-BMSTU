using Task3.parent;

namespace Task3.child;

class CurrencyRUB : Currency
{
    public CurrencyRUB(Currency def)
    {
        this.value = def.value;
    }
    
    public CurrencyRUB(double value) : base(value) {}
    
    public static explicit operator CurrencyRUB(CurrencyUSD usd)
    {
        double val = usd.value * 60;
        return new CurrencyRUB(val);
    }
    
    public static implicit operator CurrencyRUB(CurrencyEUR eur)
    {
        double val = eur.value * 80;
        return new CurrencyRUB(val);
    }
    
    public override void print()
    {
        Console.WriteLine($"{value} rub");
    }
}