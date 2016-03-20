namespace Loger.Appenders
{
    using System;

    using Loger.Contracts;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime date)
        {
            if (reportLevel >= this.ReportLevel)
            {
                var formatedMessage = this.Layout.Format(message, reportLevel, date);
                Console.WriteLine(formatedMessage);
            }

        }
    }
}
