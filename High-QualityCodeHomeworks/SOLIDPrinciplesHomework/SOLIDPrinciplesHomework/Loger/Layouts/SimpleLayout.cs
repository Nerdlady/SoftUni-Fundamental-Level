namespace Loger.Layouts
{
    using System;

    using Loger.Contracts;

    public class SimpleLayout : ILayout
    {
        public string Format(string message, ReportLevel reportLevel, DateTime date)
        {
            return string.Format("{0} - {1} - {2}", date, reportLevel, message);
        }
    }
}
