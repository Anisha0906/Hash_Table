using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMappingNode<K,V>
    {
       
            private readonly int size;
            private readonly LinkedList<KeyValue<K, V>>[] items;

            public MyMappingNode(int size)
            {
                this.size = size;
                this.items = new LinkedList<KeyValue<K, V>>[size];
            }

            protected int GetPositionInArray(K key)
            {
                return Math.Abs(key.GetHashCode() % size);
            }
            protected LinkedList<KeyValue<K, V>> LinkedListBuilder(int position)
            {
                var linkedList = items[position];
                if (linkedList == null)
                {
                    linkedList = new LinkedList<KeyValue<K, V>>();
                    items[position] = linkedList;
                }
                return linkedList;
            }
            public void AddValue(K key, V value)
            {
                int position = GetPositionInArray(key);
                var linkedList = LinkedListBuilder(position);
                var item = new KeyValue<K, V>() { Key = key, Value = value };
                linkedList.AddLast(item);
            }
            public V GetValue(K key)
            {
                int position = GetPositionInArray(key);
                var linkedList = LinkedListBuilder(position);
                foreach (var item in linkedList)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
                return default(V);
            }

            public void SetValue(K key, V value)
            {
                int position = GetPositionInArray(key);
                var linkedList = LinkedListBuilder(position);
                KeyValue<K, V> temp = new KeyValue<K, V>();
                foreach (var item in linkedList)
                {
                    if (item.Key.Equals(key))
                        temp = item;
                }
                temp.Value = value;
            }

        }
    }

