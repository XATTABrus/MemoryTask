using System;
using System.Diagnostics;

namespace MemoryTask
{
    public class Timer : Stopwatch, IDisposable
    {
        public void Dispose()
        {
            Stop();
        }

        public Timer StartTimer()
        {
            Start();
            return this;
        }

        public Timer RestartTimer()
        {
            Restart();
            return this;
        }
    }
}