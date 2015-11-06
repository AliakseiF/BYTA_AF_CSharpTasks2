using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceComparison
{
    class HashTablevsDictionary
    {
        public void CompareExecutionTime(long a, long b)
        {
            if (a < b)
                Console.WriteLine("\nHashtable is faster");
            else if (a > b)
                Console.WriteLine("\nDictionary is faster");
            else if (a == b)
                Console.WriteLine("\nHashtable and Dictionary have the same speed");
            else
                Console.WriteLine("\nError");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }

        public long AddHashtable()
        {
            Hashtable hashtable = new Hashtable();
            Random rnd = new Random();
            int value;
            int count = 1000000;
            Console.WriteLine("adding {0} elements to HT", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                hashtable.Add(i+1,value);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Hashtable add : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long AddDictionary()
        {
            Dictionary<int,int> dictionary = new Dictionary<int,int>();
            Random rnd = new Random();
            int value;
            int count = 1000000;
            Console.WriteLine("adding {0} elements to D", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                dictionary.Add(i+1, value);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Dictionary add : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long DelHashtable()
        {
            Hashtable hashtable = new Hashtable();
            Random rnd = new Random();
            int value;
            int count = 1000000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                hashtable.Add(i + 1, value);
            }
            Console.WriteLine("deleting {0} elements from HT", count);
            var watch2 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                hashtable.Remove(i+1);
            }
            watch2.Stop();
            var elapsedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("Hashtable delete : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long DelDictionary()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Random rnd = new Random();
            int value;
            int count = 1000000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                dictionary.Add(i + 1, value);
            }
            Console.WriteLine("deleting {0} elements from D", count);
            var watch2 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                dictionary.Remove(i + 1);
            }
            watch2.Stop();
            var elapsedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("Dictionary delete : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long FindHashtable()
        {
            Hashtable hashtable = new Hashtable();
            Random rnd = new Random();
            int value;
            int count = 1000000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                hashtable.Add(i + 1, value);
            }
            Console.WriteLine("searching {0} elements in HT", count);
            var watch2 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                var x = hashtable[i+1] ;
            }
            watch2.Stop();
            var elapsedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("Hashtable search : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long FindDictionary()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Random rnd = new Random();
            int value;
            int count = 1000000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                dictionary.Add(i + 1, value);
            }
            Console.WriteLine("searching {0} elements in D", count);
            var watch2 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                var x = dictionary[(i + 1)];
            }
            watch2.Stop();
            var elapsedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("Dictionary search : " + elapsedMs + " ms");
            return elapsedMs;
        }
    }
}
