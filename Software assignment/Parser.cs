using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_assignment
{
    internal class Parser
    {
        Graphics bmG;
        userPen pen;
        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Nothing.</returns>
        public Parser(Graphics g, userPen p)
        {
            this.bmG = g;
            this.pen = p;
        }
        /// <summary>
        /// Parses the user inputted command and executes it returning nothing.
        /// </summary>
        /// <param name="command">String command from user input box.</param>
        /// <returns>Output log.</returns>
        public String ParseCommand (string command, string prog, bool noDraw)
        {
            string output = "";
            Console.WriteLine (command);
            String[] commands = command.Split (' ');
            switch (commands[0].ToLower())
            {
                case "circle":
                    Console.WriteLine("circle");
                    Circle c = new Circle(Color.Blue, int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]));
                    if(!noDraw) c.draw(bmG);
                    break;
                case "triangle":
                    Console.WriteLine("triangle");
                    Circle d = new Circle(Color.Blue, int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]));
                    if (!noDraw) d.draw(bmG);
                    break;
                case "rectangle":
                    Console.WriteLine("rectangle");
                    Circle e = new Circle(Color.Blue, int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]));
                    if (!noDraw) e.draw(bmG);
                    break;
                case "shape":
                    Console.WriteLine("shape");
                    Circle f = new Circle(Color.Blue, int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]));
                    if (!noDraw) f.draw(bmG);
                    break;
                case "positionpen":
                    pen.positionPen(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "drawto":
                    pen.drawTo(bmG, int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "pencolor":
                    pen.setColor(commands[1]);
                    break;
                case "run":
                    Console.WriteLine("run");
                    String[] runCommands = prog.Split('\n');
                    for (global::System.Int32 j = 0; j < runCommands.Length; j++)
                    {
                        output = output + ParseCommand(runCommands[j], "", false);
                    }
                    break;
                case "syntax":
                    Console.WriteLine("syntax");
                    String[] syntaxCommands = prog.Split('\n');
                    for (global::System.Int32 j = 0; j < syntaxCommands.Length; j++)
                    {
                        output = output + ParseCommand(syntaxCommands[j], "", true);
                    }
                    break;
                default:
                    output = output + "\n" + command + " not recognised";
                    break;
            }
            return output;
        }
    }
}
