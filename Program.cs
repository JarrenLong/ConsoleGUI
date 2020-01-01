using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongTech.Core
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleGUI GUI = new ConsoleGUI();

      GUI.PrintMiddle("CCS LABS GUI DEMO");

      GUI.WaitKey();

      GUI.CLS();
      GUI.SetSize(160, 40);

      GUI.PrintLeft("Writing on the Left");
      GUI.PrintRight("Writing on the Right");
      GUI.PrintMiddle("Writing in the Middle of the Line");
      GUI.PrintReverse("This text is reversed");
      GUI.PrintHorizontalLeft("Left AND Down");
      GUI.PrintHorizontalRight("Right AND Down");

      GUI.WaitKey("Press any key to exit...");

      GUI.CLS();
      GUI.SetSize(40, 10);

      GUI.PrintLeft("Writing on the Left");
      GUI.PrintRight("Writing on the Right");
      GUI.PrintMiddle("Writing in the Middle of the Line");
      GUI.PrintReverse("This text is reversed");
      GUI.PrintHorizontalLeft("Left AND Down");
      GUI.PrintHorizontalRight("Right AND Down");

      GUI.WaitKey("Press any key to exit...");
    }
  }
}
