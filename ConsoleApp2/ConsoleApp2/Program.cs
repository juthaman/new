using System;

namespace onboarding_team
{
    class namespace_cl
    {
        public void func()
        {
            string Appname;
            Console.WriteLine("Which App you want to onboard");
            Appname = Console.ReadLine();
            Console.WriteLine("You want to onboard {0}.", Appname);
        }
    }
}
namespace bar_team
{
    class namespace_cl
    {
        public void func()
        {
            string Appsupport;
            Console.WriteLine("What app you need support for");
            Appsupport = Console.ReadLine();
            Console.WriteLine("You want to support {0}.", Appsupport);
        }
    }
}
class TestClass
{
    static void Main(string[] args)
    {
        onboarding_team.namespace_cl fc = new onboarding_team.namespace_cl();
        bar_team.namespace_cl sc = new bar_team.namespace_cl();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}