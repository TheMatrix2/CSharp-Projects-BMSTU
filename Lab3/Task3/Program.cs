using Task3.parent;
using Task3.child;

class Program
{
    static int Main()
    {
        Currency cur = new Currency(150.0);
        CurrencyRUB cur_rub1 = new CurrencyRUB(cur);
        cur_rub1.print();
        CurrencyUSD cur_usd = cur_rub1;
        cur_usd.print();
        CurrencyEUR cur_eur = cur_usd;
        cur_eur.print();
        CurrencyRUB cur_rub2 = cur_eur;
        cur_rub2.print();

        CurrencyRUB cur_rub3 = new CurrencyRUB(cur_usd);
        
        return 0;
    }
}