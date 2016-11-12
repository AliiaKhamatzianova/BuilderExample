using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Baker
    {
        public Bread BakeBread(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();

            return breadBuilder.Bread;
        }
    }
}
