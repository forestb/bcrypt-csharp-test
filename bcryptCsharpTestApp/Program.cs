using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace bcryptCsharpTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press [enter] to generate hashed entries...");
            Console.ReadLine();

            for (int workFactor = 10; workFactor <= 15; workFactor++)
            {
                long iterationCount = 1;

                var averageTimeInMilliseconds = GetAverageMillisecondsForRuntime(iterationCount, workFactor);

                Console.WriteLine($"Executing the hash function {iterationCount} times, with a work factor of {workFactor} took {averageTimeInMilliseconds} milliseconds.");
            }
        }

        private static long GetAverageMillisecondsForRuntime(long iterationCount, int workFactor)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            for (long i = 0; i < iterationCount; i++)
            {
                var stringToHash = $"ForestB{i}";

                var hashedString = BCrypt.Net.BCrypt.HashString(stringToHash, workFactor);
                //bool wasStringMatched = BCrypt.Net.BCrypt.Verify(stringToHash, hashedString);
            }

            stopWatch.Stop();

            return stopWatch.ElapsedMilliseconds / iterationCount;
        }
    }
}
