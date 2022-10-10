using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;
        public Bag(string[] ids, string name, string desc) : base (ids, name, desc)
        {
            _inventory = new Inventory();
            
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get 
            {
                return $"In The {this.Name} , player has : \n\t" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
    }
}
