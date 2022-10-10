using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _currentLocation;

        public Player(string name, string desc) : base(new string[] { "me" , "inventory"} , name , desc)
        {
            _inventory = new Inventory();
           
        }

        public GameObject Locate(string ids)
        {   
            if (this.AreYou(ids))
            {
                return this;
            }
            return _inventory.Fetch(ids);

            if (_currentLocation != null)
            {
                return _currentLocation.Locate(ids);
            }
            else
            {
            return null;
            }
        }


        public override string FullDescription
        {
            get 
            {
                return $"You are {this.Name} {base.FullDescription}\nYou are carrying:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get 
            { 
                return _inventory; 
            }
        }

        public Location Location
        {
            get 
            { 
                return _currentLocation; 
            }

            set 
            { 
                _currentLocation = value; 
            }
        }

        public void Move(Paths path)
        {
            if(path.Dest != null)
            {
                _currentLocation = path.Dest;
            }
        }

    }
}
