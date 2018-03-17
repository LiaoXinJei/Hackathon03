using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i =0;i<=16;i++)
            {
                for(var j =0; j <= 32; j++)
                {
                    for (var k = 0; k <= 100; k++)
                        if (i * 60 + j * 30 + k == 1000 && i + j + k == 100)
                            Console.WriteLine($"公雞數目為：{i}  母雞數目為：{j}  小雞數目為：{k}");
                }
            }
            Console.ReadLine();
        }
    }
}
