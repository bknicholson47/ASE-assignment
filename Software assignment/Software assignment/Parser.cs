using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_assignment
{
    internal class Parser
    {
        Graphics bmG;

        public Parser(Graphics g)
        {
            this.bmG = g;
        }
        public void ParseCommand (string command)
        {
            Console.WriteLine (command);
            String[] commands = command.Split (' ');
            if (commands[0] == "circle")
            {
                int i = int.Parse(commands[1]);
                int f = int.Parse(commands[2]);
                int e = int.Parse(commands[3]);
                Circle c = new Circle(Color.Blue, i, f, e);
                c.draw(bmG);
            }
        }
    }
}
