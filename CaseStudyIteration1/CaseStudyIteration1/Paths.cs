using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class Paths : GameObject
    {
        private Location _destination;
        private bool _isPathLocked;

        public Paths(string[] ids, string name, string desc, Location Dest) : base(ids, name, desc)
        {
            _destination = Dest;
            _isPathLocked = false;
        }

        public Location Dest
        {
            get { return _destination; }
        }

        public bool IsPathLocked
        {
            get 
            { 
                return _isPathLocked; 
            }

            set
            { 
                _isPathLocked = value; 
            }
        }

        public override string FullDescription
        {
            get 
            { 
                return $"Moving in {base.FullDescription}"; 
            }
        }

    }
}
