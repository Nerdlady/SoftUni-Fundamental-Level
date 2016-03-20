namespace LoggerTest
{
    using System;

    using Loger;
    using Loger.Appenders;
    using Loger.Layouts;
    using Loger.Loggers;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Layout");

            var simpleLayout = new SimpleLayout(); 
            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "../../log.txt";

            consoleAppender.ReportLevel = ReportLevel.Error;
            fileAppender.ReportLevel = ReportLevel.Warning;

            var logger = new Logger(consoleAppender,fileAppender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

            Console.WriteLine();
            Console.WriteLine("Xml Layout");

            var xmlLayout = new XmlLayout();
            var consoleAppenderForXmlLayout = new ConsoleAppender(xmlLayout);
            var loggerForXmlLayout = new Logger(consoleAppenderForXmlLayout);

            loggerForXmlLayout.Fatal("mscorlib.dll does not respond");
            loggerForXmlLayout.Critical("No connection string found in App.config");

        }
    }
}
 