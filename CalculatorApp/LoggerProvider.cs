using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CalculatorApp
{
    public static class LoggerProvider
    {
        private static readonly ILoggerFactory loggerFactory = Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter("Microsoft", LogLevel.Warning)
                .AddFilter("System", LogLevel.Warning)
                .AddFilter("CalculatorApp", LogLevel.Debug)
                .AddConsole();

        });

        public static ILogger<T> CreateLogger<T>() =>
            loggerFactory.CreateLogger<T>();
    }
}
