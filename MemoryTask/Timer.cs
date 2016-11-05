using System;
using System.Diagnostics;

namespace MemoryTask
{
    public class Timer : IDisposable
    {
        private readonly Stopwatch _stopwatch;
        public IDisposable Continue() => Start();
        public void Dispose() => _stopwatch.Stop();
        public long ElapsedMilliseconds => _stopwatch.ElapsedMilliseconds;

        public Timer()
        {
            _stopwatch = new Stopwatch();
        }

        public IDisposable Start()
        {
            _stopwatch.Start();
            return this;
        }
    }
}