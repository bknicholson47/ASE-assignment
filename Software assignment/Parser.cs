using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Software_assignment
{
    public class Parser
    {
        Graphics bmG;
        userPen pen;
        int loopCounter;
        int loopDepth;
        bool loopStatus;
        int ifCounter;
        bool ifStatus = true;
        bool currentIfStatus;
        int stepdelay = 0;
        List<KeyValuePair<string, int>> Methods = new List<KeyValuePair<string, int>>();
        List<KeyValuePair<string, int>> Variables = new List<KeyValuePair<string, int>>();
        string[] commandNames = { 
            "circle",
            "triangle",
            "rectangle",
            "moveto",
            "drawto",
            "pencolor",
            "reset",
            "clear",
            "fill",
            "run",
            "syntax",
            "loop",
            "endloop",
            "var",
            "varprint",
            "if",
            "endif",
            "method",
            "endmethod"
        };

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
            Console.WriteLine (command + ". ifdepth: " + ifCounter.ToString());
            String[] commands = command.Split (' ');
            if (ifStatus)
            {
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
                        if (!int.TryParse(commands[1], out cx))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[1]).Key != commands[1])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            cx = Variables.Find(kvp => kvp.Key == commands[1]).Value;
                        }
                        if (!int.TryParse(commands[2], out cy))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[2]).Key != commands[2])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            cy = Variables.Find(kvp => kvp.Key == commands[2]).Value;
                        }
                        if (!int.TryParse(commands[3], out cr))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[3]).Key != commands[3])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            cr = Variables.Find(kvp => kvp.Key == commands[3]).Value;
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
                        if (!int.TryParse(commands[1], out tx1))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[1]).Key != commands[1])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            tx1 = Variables.Find(kvp => kvp.Key == commands[1]).Value;
                        }
                        if (!int.TryParse(commands[2], out ty1))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[2]).Key != commands[2])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            ty1 = Variables.Find(kvp => kvp.Key == commands[2]).Value;
                        }
                        if (!int.TryParse(commands[3], out tx2))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[3]).Key != commands[3])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            tx2 = Variables.Find(kvp => kvp.Key == commands[3]).Value;
                        }
                        if (!int.TryParse(commands[4], out ty2))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[4]).Key != commands[4])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            ty2 = Variables.Find(kvp => kvp.Key == commands[4]).Value;
                        }
                        if (!int.TryParse(commands[5], out tx3))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[5]).Key != commands[5])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            tx3 = Variables.Find(kvp => kvp.Key == commands[5]).Value;
                        }
                        if (!int.TryParse(commands[6], out ty3))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[6]).Key != commands[6])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            ty3 = Variables.Find(kvp => kvp.Key == commands[6]).Value;
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
                        if (!int.TryParse(commands[1], out rx))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[1]).Key != commands[1])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            rx = Variables.Find(kvp => kvp.Key == commands[1]).Value;
                        }
                        if (!int.TryParse(commands[2], out ry))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[2]).Key != commands[2])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            ry = Variables.Find(kvp => kvp.Key == commands[2]).Value;
                        }
                        if (!int.TryParse(commands[3], out rw))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[3]).Key != commands[3])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            rw = Variables.Find(kvp => kvp.Key == commands[3]).Value;
                        }
                        if (!int.TryParse(commands[4], out rh))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[4]).Key != commands[4])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            rh = Variables.Find(kvp => kvp.Key == commands[4]).Value;
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
                        if (!int.TryParse(commands[1], out mx))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[1]).Key != commands[1])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            mx = Variables.Find(kvp => kvp.Key == commands[1]).Value;
                        }
                        if (!int.TryParse(commands[2], out my))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[2]).Key != commands[2])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            my = Variables.Find(kvp => kvp.Key == commands[2]).Value;
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
                        if (!int.TryParse(commands[1], out dx))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[1]).Key != commands[1])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            dx = Variables.Find(kvp => kvp.Key == commands[1]).Value;
                        }
                        if (!int.TryParse(commands[2], out dy))
                        {
                            if (Variables.Find(kvp => kvp.Key == commands[2]).Key != commands[2])
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                break;
                            }
                            dy = Variables.Find(kvp => kvp.Key == commands[2]).Value;
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
                            if (stepdelay>0)
                            {
                                Thread.Sleep(stepdelay);
                                Thread.Yield();
                            }
                            output = output + ParseCommand(runCommands[j], "", false);
                            if (loopStatus) { loopDepth++; }
                            if (!loopStatus) {
                                j = j - loopDepth; 
                                loopDepth = 0;
                                loopCounter = loopCounter - 1;
                                if (loopCounter>0)
                                {
                                    loopDepth = 1;
                                    loopStatus = true;
                                }
                            }

                            Form1.pictureBox1.Image = Form1.myBitmap;
                        }
                        break;
                    case "syntax":
                        String[] syntaxCommands = prog.Split('\n');
                        for (global::System.Int32 j = 0; j < syntaxCommands.Length; j++)
                        {
                            output = output + ParseCommand(syntaxCommands[j], "", true);
                        }
                        break;
                    case "loop":
                        if (commands.Length > 2)
                        {
                            output = output + "\nInvalid input '" + command + "', valid syntax is 'loop | loop int'";
                            break;
                        }
                        int lc = 1;
                        if (commands.Length > 1)
                        {
                            if (!int.TryParse(commands[1], out lc))
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'loop | loop int'";
                                break;
                            }
                            loopCounter = lc;
                        }
                        loopStatus = true;
                        break;
                    case "endloop":
                        loopStatus = false;
                        break;
                    case "var":
                        int vi;
                        int mi;
                        if (commands.Length < 4 | commands.Length == 5 | commands.Length > 6)
                        {
                            output = output + "\nInvalid input '" + command + "', valid syntax is 'var string = int | var string = string +-*/%^ int'";
                            break;
                        }
                        if (commandNames.Contains(commands[1]))
                        {
                            output = output + "\nInvalid input '" + command + "', Do not use command names as variable names.";
                            break;
                        }
                        if (commands.Length == 4) //var string = int
                        {
                            if (commands[2] != "=")
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'var string = int | var string = string +-*/%^ int'";
                                break;
                            }
                            if (!int.TryParse(commands[3], out vi))
                            {
                                if (Variables.Find(kvp => kvp.Key == commands[3]).Key != commands[3])
                                {
                                    output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                    break;
                                }
                                vi = Variables.Find(kvp => kvp.Key == commands[3]).Value;
                            }
                            if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                            {
                                Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                            }
                            Variables.Add(new KeyValuePair<string,int>(commands[1] , vi));
                        }
                        if (commands.Length == 6) //var string = string +-*/%^ int
                        {
                            if (commands[2] != "=")
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'var string = int | var string = string +-*/%^ int'";
                                break;
                            }
                            if (Variables.Find(kvp => kvp.Key == commands[3]).Key != commands[3])
                            {
                                output = output + "\nInvalid input '" + command + ", " + commands[3] + " is Null.";
                                break;
                            }
                            if (!int.TryParse(commands[5], out mi))
                            {
                                if (Variables.Find(kvp => kvp.Key == commands[5]).Key != commands[5])
                                {
                                    output = output + "\nInvalid input '" + command + "', valid syntax is 'circle int int int'";
                                    break;
                                }
                                mi = Variables.Find(kvp => kvp.Key == commands[5]).Value;
                            }
                            switch (commands[4])
                            {
                                case "+":
                                    vi = Variables.Find(kvp => kvp.Key == commands[3]).Value + mi;
                                    if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                                    {
                                        Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                                    }
                                    Variables.Add(new KeyValuePair<string, int>(commands[1], vi));
                                    break;
                                case "-":
                                    vi = Variables.Find(kvp => kvp.Key == commands[3]).Value - mi;
                                    if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                                    {
                                        Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                                    }
                                    Variables.Add(new KeyValuePair<string, int>(commands[1], vi));
                                    break;
                                case "*":
                                    vi = Variables.Find(kvp => kvp.Key == commands[3]).Value * mi;
                                    if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                                    {
                                        Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                                    }
                                    Variables.Add(new KeyValuePair<string, int>(commands[1], vi));
                                    break;
                                case "/":
                                    vi = Variables.Find(kvp => kvp.Key == commands[3]).Value / mi;
                                    if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                                    {
                                        Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                                    }
                                    Variables.Add(new KeyValuePair<string, int>(commands[1], vi));
                                    break;
                                case "%":
                                    vi = Variables.Find(kvp => kvp.Key == commands[3]).Value % mi;
                                    if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                                    {
                                        Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                                    }
                                    Variables.Add(new KeyValuePair<string, int>(commands[1], vi));
                                    break;
                                case "^":
                                    vi = Convert.ToInt32(Math.Pow(Variables.Find(kvp => kvp.Key == commands[3]).Value, mi));
                                    if (Variables.Find(kvp => kvp.Key == commands[1]).Key == commands[1])
                                    {
                                        Variables.Remove(Variables.Find(kvp => kvp.Key == commands[1]));
                                    }
                                    Variables.Add(new KeyValuePair<string, int>(commands[1], vi));
                                    break;
                                default:
                                    output = output + "\nInvalid input '" + command + "', valid syntax is 'var string = int | var string = string +-*/%^ int'";
                                    break;
                            }
                        }
                    
                        break;
                    case "varprint":
                        output = "\nVariable '" + commands[1] + "' = " + Variables.Find(kvp => kvp.Key == commands[1]).Value.ToString();
                        break;
                    case "if":
                        int ifa;
                        int ifb;
                        if (commands.Length > 4 | commands.Length < 4)
                        {
                            output = output + "\nInvalid input '" + command + "', valid syntax is 'if int {>, <, ==, !=} int'";
                        }
                        if (Variables.Find(kvp => kvp.Key == commands[1]).Key != commands[1])
                        {
                            if (!int.TryParse(commands[1], out ifa))
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'if int {>, <, ==, !=} int'";
                                break;
                            }
                        }
                        else
                        {
                            ifa = Variables.Find(kvp => kvp.Key == commands[1]).Value;
                        }
                        if (Variables.Find(kvp => kvp.Key == commands[3]).Key != commands[3])
                        {
                            if (!int.TryParse(commands[3], out ifb))
                            {
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'if int {>, <, ==, !=} int'";
                                break;
                            }
                        }
                        else
                        {
                            ifb = Variables.Find(kvp => kvp.Key == commands[3]).Value;
                        }
                        switch (commands[2])
                        {
                            case ">":
                                if (ifa > ifb)
                                {

                                    ifCounter++;
                                }
                                else
                                {
                                    ifStatus = false;
                                    ifCounter++;
                                }
                                break;
                            case "<":
                                if (ifa < ifb)
                                {

                                    ifCounter++;
                                }
                                else
                                {
                                    ifStatus = false;
                                    ifCounter++;
                                }
                                break;
                            case "==":
                                if (ifa == ifb)
                                {

                                    ifCounter++;
                                }
                                else
                                {
                                    ifStatus = false;
                                    ifCounter++;
                                }
                                break;
                            case "!=":
                                if (ifa != ifb)
                                {

                                    ifCounter++;
                                }
                                else
                                {
                                    ifStatus = false;
                                    ifCounter++;
                                }
                                break;
                            default:
                                output = output + "\nInvalid input '" + command + "', valid syntax is 'if int {>, <, ==, !=} int'";
                                break;
                        }
                        break;
                    case "endif":
                        ifCounter--;
                        if (ifCounter < 0)
                        {
                            ifCounter = 0;
                            output = output + "\n" + "No relevant if Declared.";
                        }
                        if (ifCounter == 0)
                        {
                            ifStatus = true;
                        }
                        break;
                    case "method":
                        break;
                    case "endmethod":
                        break;
                    case "stepdelay":
                        if (!int.TryParse(commands[1], out stepdelay))
                        {
                            output = output + "\nInvalid input '" + command + "', valid syntax is 'stepdelay int'";
                            break;
                        }
                        break;
                    case "":
                        break;
                    default:
                        output = output + "\n" + command + " not recognised";
                        break;
                }
            }
            else
            {
                switch (commands[0].ToLower())
                {
                    case "circle":
                        break;
                    case "triangle":
                        break;
                    case "rectangle":
                        break;
                    case "moveto":
                        break;
                    case "drawto":
                        break;
                    case "pencolor":
                        break;
                    case "reset":
                        break;
                    case "clear":
                        break;
                    case "fill":
                        break;
                    case "run":
                        break;
                    case "syntax":
                        break;
                    case "loop":
                        break;
                    case "endloop":
                        break;
                    case "var":
                        break;
                    case "varprint":
                        break;
                    case "if":
                        ifCounter++;
                        break;
                    case "endif":
                        ifCounter--;
                        if (ifCounter<0)
                        {
                            ifCounter = 0;
                            output = output + "\n" + "No relevant if Declared.";
                        }
                        if (ifCounter == 0)
                        {
                            ifStatus = true;
                        }
                        break;
                    case "method":
                        break;
                    case "endmethod":
                        break;
                    case "stepdelay":
                        break;
                    case "":
                        break;
                    default:
                        output = output + "\n" + command + " not recognised";
                        break;
                }
            }
            return output;
        }
    }
}
