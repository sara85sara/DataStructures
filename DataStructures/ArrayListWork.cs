using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    static class ArrayListWork
    {
        public static void CreateArrayList()
        {
            ArrayList aList = new ArrayList();
            aList.Add("sara");
            aList.Add(4);
            aList.Add(244);
            aList.Add(0.0);
        }
        public static void DisplayArrayListItems(ArrayList items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void RemoveElementInArrayList(ArrayList item)
        {
            item.Remove(0);
            item.Remove("sara");
            item.Remove(4);
        }
        public static bool KeyExist(ArrayList lstItem)
        {
            return lstItem.Contains("sara") ? true : false;
        }
        
    }
}
