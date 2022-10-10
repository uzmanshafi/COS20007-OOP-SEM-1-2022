using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public abstract class GameObject : IdentifiableObject
    {
        private string _description;
        private string _name;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string ShortDescription
        {
            get 
            {
                return $"{_name} ({FirstId})";
            }
        }

        public virtual string FullDescription
        {
            get 
            {
                return _description;
            }
        }
    }
}
