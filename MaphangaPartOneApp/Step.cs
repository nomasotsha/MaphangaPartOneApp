using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaphangaPartOneApp
{
    internal class Step
    {
        private string description;

        public Step()
        {

        }
        public Step(string description)
        {
            this.description = description;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
