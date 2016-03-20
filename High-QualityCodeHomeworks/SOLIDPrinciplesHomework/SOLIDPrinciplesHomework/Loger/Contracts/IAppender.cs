namespace Loger.Contracts
{
    using System;
    using System.Globalization;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        ILayout Layout { get; }

        void Append(string message, ReportLevel reportLevel, DateTime date);
    }
}
