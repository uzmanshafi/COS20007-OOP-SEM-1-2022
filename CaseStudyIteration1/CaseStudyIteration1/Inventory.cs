using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {

            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return true;
                }
                
            }
            return false;
        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            return null;
        }

        public Item Take(string id)
        {
            Item itm = Fetch(id);
            if (itm != null)
            {
                _items.Remove(itm);
                return itm;
            }
            return null;
        }

        

        public string ItemList
        {
            get
            {
                string list = string.Empty;
                foreach (Item item in _items)
                {
                    list += $"\t{item.ShortDescription}\n";
                }
                return list;
            }
        }
    }
}
