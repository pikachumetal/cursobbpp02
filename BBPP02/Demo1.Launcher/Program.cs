using Demo1.Services;
using System;
using System.Linq;

namespace Demo1.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new ProductService();
            Console.WriteLine("Products:" + svc.GetAll().Count());
            Console.ReadKey();
        }
    }
}
