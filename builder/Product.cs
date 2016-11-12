using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public abstract class Product
    {
        public string Name{ get; set; }
        public double Count { get; set; }
        public string UnitOfMeasure { get; set; }

        public Product(string name, double count, string unitOfMeasure)
        {
            this.Name = name;
            this.Count = count;
            this.UnitOfMeasure = unitOfMeasure;
        }
    }
}
