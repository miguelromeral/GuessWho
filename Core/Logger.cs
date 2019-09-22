using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Logger : ILogger
    {
        public override void WriteToLog(string text)
        {
            Console.WriteLine(text);
        }
    }
}
