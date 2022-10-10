using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class IdentifiableObject
    {
        private readonly List<string> _identifier;

        public IdentifiableObject(string[] idents)
        {
            _identifier = new List<string> {  };
           foreach (var ident in idents)
                _identifier.Add(ident);
            
        }

        public bool AreYou(string id)
        {
            return _identifier.Contains(id.ToLower());
        }

        public string FirstId
        {
            get { return _identifier.First(); }
        }

        public void AddIdentifier(string id)
        {
            if (_identifier.Contains(id))
                return;
            _identifier.Add(id.ToLower());
        }
    }
}
