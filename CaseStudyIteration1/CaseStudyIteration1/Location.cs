using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory inventory;
        private List<Paths> _paths;
        public Location(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            inventory = new Inventory();
            _paths = new List<Paths>();
        }

        public Inventory Inventory { get { return inventory; } }

        public GameObject Locate(string ids)
        {
            if(AreYou(ids))
            {
                return this;
            }

            foreach(Paths path in _paths)
            {
                if (path.AreYou(ids))
                    return path;
            }

            return Inventory.Fetch(ids);
        }

        public List<Paths> Paths
        { 
            get 
            {
                return _paths; 
            } 
        }

        public string PathsList
        {
            get
            {
                string list = string.Empty + "/n.";

                if (_paths.Count == 1)
                {
                    return "\nThere is an exit " + _paths[0].FirstId + ".\n";
                }

                list = list + "There are exits for ";

                for(int i = 0; i < _paths.Count; i++)
                {
                    if (i == _paths.Count - 1)
                    {
                        list = list + "and" + _paths[i].FirstId + ".\n";
                    }
                    else
                    {
                        list = list + _paths[i].FirstId + ", ";
                    }
                }

                return list;
            }
        }

        public bool HasPath(string dir)
        {
            foreach(Paths paths in _paths)
            {
                if(paths.FirstId.ToLower() == dir.ToLower())
                {
                    return true;
                }

            }
            return false;
        }

        public void AddPath(Paths path)
        {
            _paths.Add(path);
        }



        public override string FullDescription
        {
            get
            {
                return "The player is in " + base.Name + ": \nItems nearby : \n" + Inventory.ItemList;
            }
        }

    }
}
