using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Drawing;

namespace LongTech.Core
{
  public class ConsoleGUI
  {
    int winX, winH, bufX, bufH;

    public ConsoleGUI()
    {
      winX = Console.WindowWidth;
      winH = Console.WindowHeight;
      bufX = Console.BufferWidth;
      bufH = Console.BufferHeight;
    }

    /// <summary>
    /// Resizes the console window
    /// </summary>
    /// <param name="charW">The width of the window in displayed characters</param>
    /// <param name="charH">The height of the window in displayed characters</param>
    public void SetSize(int charW, int charH)
    {
      int wAR = winX / bufX;
      int hAR = bufH / winH;

      Console.BufferHeight = wAR * charW;
      //Console.SetBufferSize(wAR * charW, hAR * charH);
      Console.SetWindowSize(charW, charH);
    }

    /// <summary>
    /// Returns a string that will be centered on the current console screen.
    /// </summary>
    /// <param name="txt">
    /// String: The text to center
    /// </param>
    internal void PrintMiddle(string txt, bool NewLine = true)
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.SetCursorPosition((Console.WindowWidth - txt.Length) / 2, Console.CursorTop);
      if (NewLine)
      {
        Console.WriteLine(txt);
      }
      else
      {
        Console.Write(txt);
      }
    }

    internal void PrintLeft(string txt, bool NewLine = true)
    {
      Console.ResetColor();
      Console.SetCursorPosition(0, Console.CursorTop);
      if (NewLine)
      {
        Console.WriteLine(txt);
      }
      else
      {
        Console.Write(txt);
      }
    }

    internal void PrintRight(string txt, bool NewLine = true)
    {
      Console.ResetColor();
      Console.SetCursorPosition((Console.WindowWidth - txt.Length), Console.CursorTop);
      if (NewLine)
      {
        Console.WriteLine(txt);
      }
      else
      {
        Console.Write(txt);
      }
    }

    /// <summary>
    /// Reverses the text and prints at the current cursor position
    /// </summary>
    /// <param name="txt"></param>
    /// <param name="NewLine"></param>
    internal void PrintReverse(string txt, bool NewLine = true)
    {
      Console.ResetColor();
      char[] nText = new char[txt.Length];
      int idx = 1; // fixes zero initialised arrays

      foreach (char c in txt.ToCharArray())
      {
        nText[(txt.Length) - idx] = c; // Zero initialised arrays !!
        idx++;
      }

      if (NewLine)
      {
        Console.WriteLine(nText);
      }
      else
      {
        Console.Write(nText);
      }
    }

    internal void PrintHorizontalLeft(string txt)
    {
      Console.ResetColor();
      int x = Console.CursorLeft;
      int y = Console.CursorTop;


      foreach (char c in txt.ToCharArray())
      {
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.Write(c.ToString());

      }

      Console.SetCursorPosition(x, y);
    }

    internal void PrintHorizontalRight(string txt)
    {
      Console.ResetColor();
      int x = Console.CursorLeft;
      int y = Console.CursorTop;


      foreach (char c in txt.ToCharArray())
      {
        Console.SetCursorPosition(Console.WindowWidth - 1, Console.CursorTop);
        Console.Write(c.ToString());

      }

      Console.SetCursorPosition(x, y);
    }

    public void CLS()
    {
      Console.ResetColor();
      Console.Clear();

    }

    public void WaitKey(string txt = "Press Any Key to continue")
    {
      Console.ResetColor();
      Console.WriteLine(Environment.NewLine);
      Console.Write(txt);
      Console.ReadKey();
    }
  }
}
