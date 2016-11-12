using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Baker baker = new Baker();

            Bread ryeBread = baker.BakeBread(new RyeBreadBuilder());

            System.Console.WriteLine(ryeBread);

            Bread wheatBread = baker.BakeBread(new WheatBreadBuilder());

            System.Console.WriteLine(wheatBread);


        }
    }
}
