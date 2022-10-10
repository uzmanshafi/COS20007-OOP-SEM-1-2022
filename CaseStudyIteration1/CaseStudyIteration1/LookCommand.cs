using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class LookCommand : Command
    {
        public LookCommand() : base(ids: new string[] {"look"})
        {
            
        }

        public override string Execute(Player p, string[] text)
        {
            if (!new[] { 3, 5 }.Contains(text.Length))
            {
                return "I don't know how to look like that\n";
            }

            if (text[0] != "look")
            {
                return "Error in look input\n";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?\n";
            }

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?\n";
                }
            }

            if (text.Length == 3)
            {
                string itemToFind = text[2];
                return LookAtIn(itemToFind, p as IHaveInventory);
            }

            if (text.Length == 5)
            {
                string itemToFind = text[2];
                string placeToLookIn = text[4];
                IHaveInventory container = FetchContainer(p, placeToLookIn);
                if (container is null)
                {
                    return $"I cannot find the {placeToLookIn}\n";
                }
                return LookAtIn(itemToFind, container);
            }

            return "Works";
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            if (p != null)
                return p.Locate(containerId) as IHaveInventory;
            return null;
        }

        private string LookAtIn(string thingID, IHaveInventory container)
        {
            if (container.Locate(thingID) != null)
                return container.Locate(thingID).FullDescription;

            return "Could not find " + thingID + ".";
        }

    }
}
