using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceComparison
{
    public class ArrayListvsLinkedList
    {
        public void CompareExecutionTime(long a, long b)
        {
            if (a < b)
                Console.WriteLine("\nArrayList is faster");
            else if (a > b)
                Console.WriteLine("\nLinkedList is faster");
            else if (a == b)
                Console.WriteLine("\nArrayList and LinkedList have the same speed");
            else
                Console.WriteLine("\nError");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }

        public long AddArrayList()
        {
            ArrayList arrayList = new ArrayList();
            Random rnd = new Random();
            int value;
            int count = 10000000;
            Console.WriteLine("adding {0} elements to AL", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                arrayList.Add(value);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("ArrayList add : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long AddLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Random rnd = new Random();
            int value;
            int count = 10000000;
            Console.WriteLine("adding {0} elements to LL", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                linkedList.AddLast(value);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("LinkedList add : " + elapsedMs + " ms");
            return elapsedMs;
        }
        
        public long DelArrayList()
        {
            ArrayList arrayList2 = new ArrayList();
            Random rnd = new Random();
            int value;
            int count = 100000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                arrayList2.Add(value);
            }
            Console.WriteLine("deleting {0} elements from AL", count);
            var watch2 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                arrayList2.RemoveAt(1);
            }
            watch2.Stop();
            var elapsedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("ArrayList delete : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long DelLinkedList()
        {
            LinkedList<int> linkedList2 = new LinkedList<int>();
            Random rnd = new Random();
            int value;
            int count = 100000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                linkedList2.AddLast(value);
            }
            Console.WriteLine("deleting {0} elements from LL", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                linkedList2.RemoveFirst();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("LinkedList delete : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long FindArrayList()
        {
            ArrayList arrayList = new ArrayList();
            Random rnd = new Random();
            int value;
            int count = 50000;
            for (int i = 0; i <= count; i++)
            {
                value = rnd.Next(9999);
                arrayList.Add(value);
            }
            Console.WriteLine("searching {0} elements in AL", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                arrayList.GetRange(i,1);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("ArrayList search : " + elapsedMs + " ms");
            return elapsedMs;
        }

        public long FindLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Random rnd = new Random();
            int value;
            int count = 50000;
            for (int i = 0; i < count; i++)
            {
                value = rnd.Next(9999);
                linkedList.AddLast(value);
            }
            Console.WriteLine("searching {0} elements in LL", count);
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                linkedList.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("LinkedList search : " + elapsedMs + " ms");
            return elapsedMs;
        }
    }
}
