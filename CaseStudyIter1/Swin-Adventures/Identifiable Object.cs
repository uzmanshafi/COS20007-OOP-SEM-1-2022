using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIter1
{
    public class Identifiable_Object
    {
        private readonly List<string> _identifier;

        public Identifiable_Object(string[] idents) 
        {
            _identifier = new List<string> { idents[0] };
        }

        public bool AreYou(string id)
        {
            return _identifier.Contains(id);
        }

        public string FirstId
        {
            get { return _identifier[0]; }
        }

        public void AddIdentifier(string id)
        {
            _identifier.Add(id.ToLower());
        }

    }
}
