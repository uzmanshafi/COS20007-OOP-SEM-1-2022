using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyIteration1
{
    public class CommandProcessor : Command
    {
        private List<Command> GameCommands;

        public CommandProcessor() : base(new string[] {"command"})
        {
            GameCommands = new List<Command>();
            GameCommands.Add(new LookCommand());
            GameCommands.Add(new MoveCommand());
        }

        public override string Execute(Player p, string[] text)
        {
            foreach(Command cmd in GameCommands)
            {
                if(cmd.AreYou(text[0]))
                {
                    return cmd.Execute(p, text);
                }
            }
            return "the command that was entered was not invalid.";
        }
    }
}
