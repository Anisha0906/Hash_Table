using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
     class Program
    {
        static void Main(string[] args)
        {
            HashTableBuilder hashTable = new HashTableBuilder();

            Console.WriteLine($"Frequency of word is {hashTable.FindFrequencyOfWord()}");
            Console.ReadLine();
        }
    }
}
