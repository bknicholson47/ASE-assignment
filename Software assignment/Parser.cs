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
                    Circle c = new Circle(int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]));
                    if(!noDraw) c.draw(bmG, pen.getPen(), pen.getFill());
                    break;
                case "triangle":
                    Triangle d = new Triangle(int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]), int.Parse(commands[4]), int.Parse(commands[5]), int.Parse(commands[6]));
                    if (!noDraw) d.draw(bmG, pen.getPen(), pen.getFill());
                    break;
                case "rectangle":
                    Rectangle e = new Rectangle(int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]), int.Parse(commands[4]));
                    if (!noDraw) e.draw(bmG, pen.getPen(), pen.getFill());
                    break;
                case "positionpen":
                    if (!noDraw) pen.moveTo(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "drawto":
                    if (!noDraw) pen.drawTo(bmG, int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "pencolor":
                    if (!noDraw) pen.setColor(commands[1]);
                    break;
                case "reset":
                    if (!noDraw) pen.moveTo(0, 0);
                    break;
                case "clear":
                    if (!noDraw) bmG.Clear(Color.White);
                    break;
                case "fill":
                    if (commands.Length < 2 | commands.Length > 2) {
                        output = output + "\nInvalid input '"+command+"', valid syntax is 'fill [on|off]'";
                        break;
                    }
                    switch (commands[1])
                    {
                        case "on":
                            pen.setFill(true);
                            break;
                        case "off":
                            pen.setFill(false);
                            break;
                        default:
                            output = output + "\n" + commands[1] + " not recognised, valid options are [on|off]";
                            break;
                    }
                    break;
                case "run":
                    String[] runCommands = prog.Split('\n');
                    for (global::System.Int32 j = 0; j < runCommands.Length; j++)
                    {
                        output = output + ParseCommand(runCommands[j], "", false);
                    }
                    break;
                case "syntax":
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
