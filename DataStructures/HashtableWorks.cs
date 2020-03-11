using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace DataStructures
{
    public class HashtableWorks
    {
        Hashtable ht = new Hashtable();

        public HashtableWorks()
        {
            ht.Add("1001", 'a');
            ht.Add("1002", 'b');
            ht.Add("1003", 'c');
            ht.Add("1004", 'd');
        }
        public bool IsExist(Hashtable ht)
        {
            return ht.ContainsKey("1001") ? true : false;
        }
        public void ShowAllItems(Hashtable ht)
        {
            foreach (DictionaryEntry element in ht)
            {
                Console.WriteLine("Key {0}, value {1}", element.Key, element.Value);
            }
        }
        public void PrintKeys(Hashtable ht)
        {
            ICollection keys = ht.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }
        }
        public void PrintValues(Hashtable ht)
        {
            ICollection htValues = ht.Values;
            foreach (char c in htValues)
            {
                Console.WriteLine(c);
            }
        }
        public void RemoveKeyOrValue(string keyorValue)
        {
            if (ht.ContainsKey(keyorValue) || ht.ContainsValue(keyorValue)) ht.Remove(keyorValue);
        }
    }
}
