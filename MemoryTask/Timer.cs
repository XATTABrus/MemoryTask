using System;
using System.Diagnostics;

namespace MemoryTask
{
    public class Timer : IDisposable
    {
        private readonly Stopwatch _stopwatch;
        public Timer Continue() => Start();
        public void Dispose() => _stopwatch.Stop();
        public long ElapsedMilliseconds => _stopwatch.ElapsedMilliseconds;
        public long ElapsedTicks => _stopwatch.ElapsedTicks;
        public TimeSpan Elapsed => _stopwatch.Elapsed;
        public bool IsRunning => _stopwatch.IsRunning;
        public void Reset() => _stopwatch.Reset();
        public bool IsBetterThanStopWatch => true;
        
        public Timer()
        {
            _stopwatch = new Stopwatch();
        }

        public Timer Start()
        {
            _stopwatch.Start();
            return this;
        }

        public Timer Restart()
        {
            _stopwatch.Restart();
            return this;
        }
    }
}