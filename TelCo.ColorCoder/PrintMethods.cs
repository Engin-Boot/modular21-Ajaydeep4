using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    public class PrintOnConsole : IPrint
    {
        public void PrintLine(string line)
        {
            Console.WriteLine(line);
        }
    }
    public class PrintOnConsoleTest : IPrint
    {
        public int timesPrintOnConsoleCalled = 0;
        public void PrintLine(string line)
        {
            timesPrintOnConsoleCalled++;
        }
    }
}
