using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloLog
{
    public class FactoryLogLevel
    {
                
        public static LogEventLevel GetLogLevel() 
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 6);
            return (LogEventLevel)number; 
        }
    }
}
