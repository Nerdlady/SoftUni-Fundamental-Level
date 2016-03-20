namespace Loger.Loggers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Loger.Contracts;

    public class Logger : ILogger
    {
        public IList<IAppender> Appenders { get; private set; }

        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public void Info(string message)
        {
            this.Log(message,ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.Log(message,ReportLevel.Warning);
        }

        public void Error(string message)
        {
            this.Log(message,ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.Log(message,ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.Log(message,ReportLevel.Fatal);
        }

        private void Log(string message, ReportLevel reportLevel)
        {
            var date = DateTime.Now;
            foreach (var appender in this.Appenders)
            {
                appender.Append(message,reportLevel, date);
            }
        }
    }
}
