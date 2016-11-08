using System;
using System.Diagnostics;

namespace MemoryTask
{
    public class Timer : Stopwatch, IDisposable
    {
        public void Dispose() => Stop();

        public new Timer Start()
        {
            base.Start();
            return this;
        }

        public new Timer Restart()
        {
            base.Restart();
            return this;
        }
    }
}