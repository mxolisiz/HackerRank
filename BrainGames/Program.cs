using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        private static readonly ConcurrentStack<string> ConcurrentStack = new ConcurrentStack<string>();
        private static readonly EventWaitHandle SomethingInTheConcurrentStack =
            new EventWaitHandle(false, EventResetMode.ManualReset);

        private static void Method(string arg)
            => ConcurrentStack.Push(arg);

        private static void AnotherMethod(Action<string> action)
        {
            while (true)
            {
                SomethingInTheConcurrentStack.Reset();
                Thread.Sleep(5000);
                TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1);
                double secondsSinceEpoch = timeSpan.TotalSeconds;
                action(secondsSinceEpoch.ToString(CultureInfo.InvariantCulture));
                SomethingInTheConcurrentStack.Set();
            }
        }

        private static void Main(string[] args)
        {
            Task.Factory.StartNew(() => AnotherMethod(Method));
            while (true)
            {
                SomethingInTheConcurrentStack.WaitOne();
                if(ConcurrentStack.TryPop(out string popped))
                    Console.Out.WriteLine(popped);
            }
        }

    }
}
