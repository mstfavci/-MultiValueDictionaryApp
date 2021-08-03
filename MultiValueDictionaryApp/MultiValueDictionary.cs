using MultiValueDictionaryApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp
{
    public class MultiValueDictionary<TKey, TValue>
    {
        private Dictionary<TKey, HashSet<TValue>> dictionary = new Dictionary<TKey, HashSet<TValue>>();

        public void Add(TKey key, TValue value)
        {
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, new HashSet<TValue>());
            if (dictionary[key].Contains(value))
                throw new MemberExistException();
            dictionary[key].Add(value);
        }

        public void RemoveMember(TKey key, TValue value)
        {
            if (!dictionary.ContainsKey(key))
                throw new KeyDoesNotExistException();
            if (!dictionary[key].Contains(value))
                throw new MemberDoesNotExistException();
            dictionary[key].Remove(value);
            if (dictionary[key].Count == 0)
                dictionary.Remove(key);
        }

        public void RemoveKey(TKey key)
        {
            if (!dictionary.ContainsKey(key))
                throw new KeyDoesNotExistException();
            dictionary.Remove(key);
        }
        public void Clear()
        {
            dictionary.Clear();
        }
        public bool KeyExists(TKey key)
        {
            return dictionary.ContainsKey(key);
        }
        public bool MemberExists(TKey key, TValue value)
        {
            if (!dictionary.ContainsKey(key))
                return false;
            return dictionary[key].Contains(value);
        }

        public Dictionary<TKey, HashSet<TValue>>.KeyCollection GetKeys()
        {
            return dictionary.Keys;
        }
        public List<TValue> GetMembers()
        {
            List<TValue> values = new List<TValue>();
            foreach (var item in dictionary)
            {
                foreach (var value in item.Value)
                {
                    values.Add(value);
                }
            }
            return values;
        }

        public Dictionary<TKey, HashSet<TValue>> Dictionary { 
            get
            {
                return dictionary;
            }
        }
    }
}
