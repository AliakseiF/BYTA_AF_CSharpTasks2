using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListvsLinkedList al = new ArrayListvsLinkedList();
            al.CompareExecutionTime(al.AddArrayList(), al.AddLinkedList());
            al.CompareExecutionTime(al.DelArrayList(), al.DelLinkedList());
            al.CompareExecutionTime(al.FindArrayList(), al.FindLinkedList());

            HashTablevsDictionary hd = new HashTablevsDictionary();
            hd.CompareExecutionTime(hd.AddHashtable(), hd.AddDictionary());
            hd.CompareExecutionTime(hd.DelHashtable(), hd.DelDictionary());
            hd.CompareExecutionTime(hd.FindHashtable(), hd.FindDictionary());

            //TODO: Stack vs Queue
            Console.ReadLine();
        }
    }
}

