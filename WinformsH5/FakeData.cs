using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsH5.Model;

namespace WinformsH5;

public static class FakeData
{
    public static List<Product> products = new List<Product>()
    {
        new Product("Fanta",0.5,99),
        new Product("Cola",0.6,70),
        new Product("Lays",2.2,50),
        new Product("RedBull",3,60),
        new Product("Favelli",1.5,40),
        new Product("Alpen Gold Max Fun",2.9,0),
        new Product("Bizim Tarla Pomidor",1.8,10)
    };
}
