using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory;

public class Client
{
    static void Main(string[] args)
    {
        // 实例化长沙工厂
        Factory.AbstractFactory changShaFactory = new Factory.ChangShaFactory();

        var changShaApplePie = changShaFactory.CreateApplePie();

        changShaApplePie.Print();
    }
}
