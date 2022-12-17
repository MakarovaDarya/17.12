using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test1");
            account num1 = new account(type: TypeAccount.Actual, balance: 70);
            account num2 = new account(type: TypeAccount.Savings, balance: 5);
            num2.Transfer(num1, 10);
            Console.WriteLine(num1);
            Console.WriteLine(num1[0]);
            Console.WriteLine(num2);
            Console.WriteLine(num2[0]);
            Console.WriteLine("Test2");
            Build zdan = new Build();
            for (int i = 0; i <= 10; i++)
            {
                zdan[i] = new Building(height : 27 + i, CStoryes: 9 + i, CEntrance : 1 + i, CFlats : 50 + i);
                Console.WriteLine(zdan[i]);
            }

        }
    }
}
