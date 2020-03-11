using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DictionaryWork
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        public void CreateDictionary()
        {
            dict.Add(1, "sara");
            dict.Add(2, "sindhu");
            dict.Add(3, "ruthu");
            dict.Add(4, "sasi");
        }
        public void UpdateDectionary(Dictionary<int, string> dict)
        {
            dict[2] = "mani";
            dict[3] = "raja";
        }
        public void DeleteItemInDectionary(Dictionary<int, string> dict)
        {
            dict.Remove(4);
        }
        //public string CheckKeyExist(int key)
        //{
        //    string output = string.Empty;
        //    if (dict.TryGetValue(key, out output))
        //        return output;         

        //}
        public void PrintAllKeys(Dictionary<int, string> dict)
        {
            foreach (var items in dict)
            {
                Console.WriteLine("Key {0},Value {1}", items.Key, items.Value);
            }
        }
    }
}
