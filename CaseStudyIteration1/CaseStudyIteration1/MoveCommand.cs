using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(ids : new string[] {"move", "go", "head", "leave"})
        {
            
        }

        public override string Execute(Player p, string[] text)
        {
            string error = "Error in move input.";
            string _moveDir;

            switch (text.Length)
            {
                case 1:
                    return "Move where?";

                case 2:
                    _moveDir = text[1].ToLower();
                    break;

                case 3:
                    _moveDir = text[2].ToLower();
                    break;

                default:
                    return error;
            }

            GameObject _path = p.Location.Locate(_moveDir);

            if (_path != null)
            {
                if (_path.GetType() != typeof(Paths))
                    return "Could Not Find The Path Called" + _path.Name;
                p.Move((Paths)_path);
                return p.Name + " has moved " + _path.FirstId + " via the " + _path.Name + " to " + p.Location.Name + "\n" + p.Location.FullDescription + ".\n";
            }
            else
            {
                return error;
            }

        }
    }
}
