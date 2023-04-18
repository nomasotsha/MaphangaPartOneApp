using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaphangaPartOneApp
{
    internal class Ingredient
    {
        private string name;
        private int qty;
        private string unitOfMeasure;

        public Ingredient(string name, int qty, string unitOfMeasure)
        {
            Name = name;
            Qty = qty;
            UnitOfMeasure = unitOfMeasure;
        
        }
        public Ingredient()
        {
            Name = " ";
            Qty = 0;
            UnitOfMeasure = " ";

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public string UnitOfMeasure
        {
            get { return unitOfMeasure; }
            set { unitOfMeasure = value; }
        }
    }
}
