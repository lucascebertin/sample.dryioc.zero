using DryIocZero;
using Test.Services;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Container();
            var a = (IService)c.ResolveGeneratedOrGetDefault(typeof(IService));
            a.SvcTest();
        }
    }
}
