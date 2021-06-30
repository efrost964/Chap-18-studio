using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap_19_studio
{
    class MenuItem
    {
        public string NameOfItem { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }  = DateTime.Today;


        public MenuItem(string name, string desc, string category, double price)
        {
            NameOfItem = name;
            Description = desc;
            Category = category;
            Price = price;
        }
        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this)
            {
                return true;
            }
            if (toBeCompared == null)
            {
                return false;
            }
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }
            MenuItem m = toBeCompared as MenuItem;
            return m.NameOfItem.ToLower() == NameOfItem.ToLower();
        }

    }
}
