using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
     class HashTableBuilder
    {
        public string Sentence { get; set; } = "To be or not to be";
        public string WordToCheck { get; set; } = "be";
        public int FindFrequencyOfWord()
        {
            string[] words = Sentence.Split(' ');
            MyMappingNode<string, int> map = new MyMappingNode<string, int>(10);
            foreach (string word in words)
            {
                if (map.GetValue(word) == 0)
                    map.AddValue(word, 1);
                else
                {
                    var freq = map.GetValue(word) + 1;
                    map.SetValue(word, freq);
                }
            }
            int count = map.GetValue(WordToCheck);
            return count;
        }
    }
}
