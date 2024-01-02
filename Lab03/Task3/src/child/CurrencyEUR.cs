using Task3.parent;

namespace Task3.child;

class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value) {}
    
    public CurrencyEUR(Currency def)
    {
        this.value = def.value;
    }

    public static implicit operator CurrencyEUR(CurrencyRUB rub)
    {
        double val = rub.value / 80;
        return new CurrencyEUR(val);
    }
    
    public static implicit operator CurrencyEUR(CurrencyUSD usd)
    {
        double val = usd.value * 0.75;
        return new CurrencyEUR(val);
    }

    public override void print()
    {
        Console.WriteLine($"{value} eur");
    }
}