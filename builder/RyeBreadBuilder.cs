using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void CreateBread()
        {
            Bread = new Bread();

            this.AddIngredient(new Flour("Rye Flor", 100, "gr"));

            this.AddIngredient(new Water("Water", 100, "ml"));

            this.AddIngredient(new Yeast("Yeast", 10, "gr"));

            this.AddIngredient(new Salt("Salt", 10, "gr"));

            this.AddIngredient(new Eggs("Eggs", 2, "ct"));

            this.AddIngredient(new Additives("Tmin", 5, "gr"));
        }
    }
}
