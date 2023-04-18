using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaphangaPartOneApp
{
    internal class Recipe
    {
        private Ingredient[] arIngredient;
        private Step[] arStep;

        private Ingredient[] ArIngredient
        {
            get { return arIngredient; }
            set { arIngredient = value; }
        }
        //step property 
        private Step[] ArStep
        {
            get { return arStep; }
            set { arStep = value; }
        }
    }
}
