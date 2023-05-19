using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesandBST
{
    internal class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            for (int i = 0; i < linkedList.Count; i++)
            {
                KeyValue<K, V> item = linkedList.ElementAt(i);
                if (item.key.Equals(key))
                {
                    item.value = value; // Update the value if the key already exists
                    return;
                }
            }
            KeyValue<K, V> newItem = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(newItem);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach(KeyValue<K, V> item in linkedList)
            {
                if(item.key.Equals(key))
                {
                    
                    foundItem = item;
                    break;
                }
            }
            if(!EqualityComparer<KeyValue<K, V>>.Default.Equals(foundItem, default(KeyValue<K, V>)))
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if(linkedList==null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

    }
    public struct KeyValue<K, V>
    {
        public K key{get; set;}
        public V value { get; set;}
    }
}
