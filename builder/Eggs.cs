using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Eggs :Product
    {
        public Eggs(string name, double count, string unitOfMeasure) : base( name,  count, unitOfMeasure) { }
    }
}
