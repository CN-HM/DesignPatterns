using DesignPatterns.BuilderPattern.Buildeies;
using DesignPatterns.BuilderPattern.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern;

public class Client
{
    static void Main(string[] args)
    {
        // 客户找到电脑城老板说要买电脑，这里要装两台电脑
        // 创建指挥者和构造者

        var build1 = new ConcreteBuilder1();
        var build2 = new ConcreteBuilder2();
        var director = new Director();

        // 老板叫员工去组装第一台电脑
        director.Construct(build1);

        // 组装完，组装人员搬来组装好的电脑
        Computer computer1 = build1.GetComputer();
        computer1.Show();

        // 老板叫员工去组装第二台电脑
        director.Construct(build2);

        Computer computer2 = build2.GetComputer();
        computer2.Show();

        Console.Read();
    }
}

