using Task3.parent;

namespace Task3.child;

class CurrencyUSD : Currency
{
    public CurrencyUSD(Currency def)
    {
        this.value = def.value;
    }
    
    public CurrencyUSD(double value) : base(value) {}
    
    public static implicit operator CurrencyUSD(CurrencyRUB rub)
    {
        double val = rub.value / 60;
        return new CurrencyUSD(val);
    }
    
    public static implicit operator CurrencyUSD(CurrencyEUR eur)
    {
        double val = eur.value / 0.75;
        return new CurrencyUSD(val);
    }
    
    public override void print()
    {
        Console.WriteLine($"{value} usd");
    }
}