using System;
using System.Windows.Forms;


namespace _03.AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticks = 10;
            int interval = 1000;

            Action<int> action = TimerMethod;
            AsyncTimer timer = new AsyncTimer(action, ticks, interval);
            timer.Execute();
        }

        private static void TimerMethod(int i)
        {
            Console.WriteLine("I ticked {0} times" ,i + 1);
        }
    }
}
