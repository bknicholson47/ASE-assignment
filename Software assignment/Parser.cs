using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_assignment
{
    public class Parser
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
                    if (commands.Length < 4|commands.Length > 4)
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                        break;
                    }
                    int cx;
                    int cy;
                    int cr;
                    if (!int.TryParse(commands[1], out cx)| !int.TryParse(commands[2], out cy) | !int.TryParse(commands[3], out cr))
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                        break;
                    }
                    Circle c = new Circle(cx, cy, cr);
                    if(!noDraw) c.draw(bmG, pen.getPen(), pen.getFill());
                    break;
                case "triangle":
                    if (commands.Length < 7 | commands.Length > 7)
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'triangle int int int int int int'";
                        break;
                    }
                    int tx1;
                    int ty1;
                    int tx2;
                    int ty2;
                    int tx3;
                    int ty3;
                    if (!int.TryParse(commands[1], out tx1) | !int.TryParse(commands[2], out ty1) | !int.TryParse(commands[3], out tx2) | !int.TryParse(commands[4], out ty2) | !int.TryParse(commands[5], out tx3) | !int.TryParse(commands[6], out ty3))
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'triangle int int int int int int'";
                        break;
                    }
                    Triangle d = new Triangle(tx1, ty1, tx2, ty2, tx3, ty3);
                    if (!noDraw) d.draw(bmG, pen.getPen(), pen.getFill());
                    break;
                case "rectangle":
                    if (commands.Length < 5 | commands.Length > 5)
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'rectangle int int int int'";
                        break;
                    }
                    int rx;
                    int ry;
                    int rw;
                    int rh;
                    if (!int.TryParse(commands[1], out rx) | !int.TryParse(commands[2], out ry) | !int.TryParse(commands[3], out rw) | !int.TryParse(commands[4], out rh))
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'rectangle int int int int'";
                        break;
                    }
                    Rectangle e = new Rectangle(rx, ry, rw, rh);
                    if (!noDraw) e.draw(bmG, pen.getPen(), pen.getFill());
                    break;
                case "moveto":
                    if (commands.Length < 3 | commands.Length > 3)
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'moveto int int'";
                        break;
                    }
                    int mx;
                    int my;
                    if (!int.TryParse(commands[1], out mx) | !int.TryParse(commands[2], out my))
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'moveto int int'";
                        break;
                    }
                    if (!noDraw) pen.moveTo(mx, my);
                    break;
                case "drawto":
                    if (commands.Length < 3 | commands.Length > 3)
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'moveto int int'";
                        break;
                    }
                    int dx;
                    int dy;
                    if (!int.TryParse(commands[1], out dx) | !int.TryParse(commands[2], out dy))
                    {
                        output = output + "\nInvalid input '" + command + "', valid syntax is 'moveto int int'";
                        break;
                    }
                    if (!noDraw) pen.drawTo(bmG, dx, dy);
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
