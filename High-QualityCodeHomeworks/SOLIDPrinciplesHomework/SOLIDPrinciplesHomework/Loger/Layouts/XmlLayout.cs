namespace Loger.Layouts
{
    using System;

    using Loger.Contracts;
    public class XmlLayout : ILayout
    {
        public string Format(string message, ReportLevel reportLevel, DateTime date)
        {
            return
                string.Format("<log>\n    <date>{0}</date>\n    <level>{1}</level>\n" + "    <message>{2}</message>\n</log>" , date, reportLevel,message);
        }
    }
}
