namespace Loger.Appenders
{
    using System;

    using Loger.Contracts;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; private set; }

        public abstract void Append(string message, ReportLevel reportLevel, DateTime date);

    }
}
