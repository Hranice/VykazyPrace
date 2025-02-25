using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VykazyPrace.AppLogging
{
    public static class AppLogger
    {
        public static ILogger Logger { get; private set; }

        static AppLogger()
        {
            Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.SQLite("logs/logs.db", restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();
        }

        public static void Information(string message)
        {
            Logger.Information(message);
        }

        public static void Error(string message, Exception ex)
        {
            Logger.Error(ex, message);

            ShowErrorPopup(message, ex);
        }

        private static void ShowErrorPopup(string message, Exception ex)
        {
            string errorMessage = $"{message}\n\n{ex.Message}";

            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
