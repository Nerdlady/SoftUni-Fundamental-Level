namespace Loger.Appenders
{
    using System;
    using System.IO;

    using Loger.Contracts;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void Append(string message, ReportLevel reportLevel, DateTime date)
        {
            if (reportLevel >= this.ReportLevel)
            {
                var formatedMessage = this.Layout.Format(message, reportLevel, date);
                System.IO.File.AppendAllText(this.File, formatedMessage);
            }
        }
    }
}
