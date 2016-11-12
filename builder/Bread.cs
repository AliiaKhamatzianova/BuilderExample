using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Bread
    {
        public List<Product> ingredients; 
        public Bread()
        {
            ingredients = new List<Product>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(var product in ingredients)
            {
                sb.Append(product.Name + " " + product.Count + " " + product.UnitOfMeasure +  "\n");
            }
            
            return sb.ToString();
        }
    }
}
