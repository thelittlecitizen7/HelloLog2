using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloLog
{
    public class RunLogic
    {

        public RunLogic()
        {
            var configuration = new ConfigurationBuilder()
                              .AddJsonFile("appsettings.json")
                              .Build();

            Log.Logger = new LoggerConfiguration()
              .ReadFrom.Configuration(configuration)
              .CreateLogger();

        }
        public void Run()
        {
            try
            {
                while (true)
                {
                    LogEventLevel logEventLevel = FactoryLogLevel.GetLogLevel();
                    Log.Write(logEventLevel, "Hello, world!");
                }
            }
            catch (Exception e)
            {
                Log.Error($"Error occourd {e.Message}");
                throw;
            }
        }
    }
}
