namespace Loger.Contracts
{
    using System;

    public interface ILayout
    {
        string Format(string message, ReportLevel reportLevel, DateTime date);
    }
}
