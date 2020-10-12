using System.Diagnostics;

namespace PHP
{
	public static class Timer
	{
		private static Stopwatch sw;

		static Timer()
		{
			sw = new Stopwatch();
		}

		// Start new measurement
		public static void Start()
		{
			sw.Reset();
			sw.Start();
		}

		// returned elapsed time in ms
		public static long Stop()
		{
			sw.Stop();
			return sw.ElapsedMilliseconds;
		}
	}
}
