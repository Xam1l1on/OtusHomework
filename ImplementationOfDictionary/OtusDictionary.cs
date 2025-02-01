using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfDictionary
{
    internal class OtusDictionary
    {
        private int[] _buckets;
        private string[]? _entry;
        private int capacity;
        private int count;
        public OtusDictionary()
        {
            capacity = 32;
            _buckets = new int[capacity];
            _entry = new string[capacity];
            Array.Fill(_entry, null);
            count = 0;
        }
        public void Add(int key, string value)
        {
            if(value == null) throw new ArgumentNullException("Значение не может быть \"null\"");
            if (count >= capacity) Resize();

            int index = FindIndex(key);

            if (_entry[index] != null) throw new InvalidOperationException("Такой ключ уже существует.");

            _buckets[index] = key;
            _entry[index] = value;
            count++;
        }

        private int FindIndex(int key)
        {
            int index = Math.Abs(key) % capacity;

            while (_entry[index] != null && _buckets[index] != key)
            {
                index = (index + 1) % capacity;
            }

            return index;
        }

        private void Resize()
        {
            int newCapacity = capacity * 2;
            int[] newBuckets = new int[newCapacity];
            string[] newEntries = new string[newCapacity];
            Array.Fill(newEntries, null);

            for (int i = 0; i < capacity; i++)
            {
                if (_entry[i] != null)
                {
                    int newIndex = Math.Abs(_buckets[i]) % newCapacity;

                    while (newEntries[newIndex] != null)
                    {
                        newIndex = (newIndex + 1) % newCapacity;
                    }

                    newBuckets[newIndex] = _buckets[i];
                    newEntries[newIndex] = _entry[i];
                }
            }

            _buckets = newBuckets;
            _entry = newEntries;
            capacity = newCapacity;
        }

        public string Get(int key)
        {
            int index = FindIndex(key);
            return _entry[index] ?? "Значение не найдено";
        }
    }
}
