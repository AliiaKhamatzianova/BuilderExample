using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class WheatBreadBuilder : BreadBuilder
    {
        public override void CreateBread()
        {
            Bread = new Bread();

            this.AddIngredient(new Flour("Wheat Flor", 100, "gr"));

            this.AddIngredient(new Water("Water", 100, "ml"));

            this.AddIngredient(new Yeast("Yeast", 10, "gr"));

            this.AddIngredient(new Salt("Salt", 10, "gr"));

            this.AddIngredient(new Eggs("Eggs", 2, "ct"));

        }
    }
}
