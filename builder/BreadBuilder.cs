using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public abstract class BreadBuilder
    {
        public Bread Bread { get; protected set; }

        public abstract void CreateBread();

        public void AddIngredient(Product product)
        {
            Bread.ingredients.Add(product);
        }
    }
}
