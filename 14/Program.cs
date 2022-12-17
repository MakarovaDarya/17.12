using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14.1 ");
            account account = new account(TypeAccount.Actual, 10005);
            account.Withdraw(523);
            account.DumpToScreen();
            Console.WriteLine();

            Console.WriteLine("14.2 ");
            MemberInfo typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (object attrObj in attrs)
            {
                if (attrObj is DeveloperInfo2Attribute attr)
                {
                    Console.WriteLine($"Разработчик класса \"Building\"  -- {attr.NameDeveloper}");
                    Console.WriteLine($"Организация  -- {attr.NameOrganization}");
                }
            }
        }
    }
}
