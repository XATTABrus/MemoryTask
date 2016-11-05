using System;
using System.Threading;

namespace MemoryTask
{
    static class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            using (timer.Start())
            {
                Thread.Sleep(120);
            }
            Console.WriteLine(timer.ElapsedMilliseconds);

            using (timer.Continue())
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
