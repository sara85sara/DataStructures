using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;

namespace DataStructures
{
    class StringCollectionWorks
    {
        public void Create()
        {
            StringCollection sc = new StringCollection();
            sc.Add("sara");
            sc.Add("Sindhu");
            sc.Add("Ruthran");
        }
        public void Display(StringCollection sc)
        {
            foreach (var name in sc)
            {
                Console.WriteLine(name);
            }
        }
        public string[] AddRange(StringCollection sc)
        {
            string[] names = new string[] { "Maya", "Raja", "Tyson", "Ali" };
            sc.AddRange(names);
            return names;
        }
        public bool IsElementExist(string name)
        {
            bool IsElementExist = false;
            StringCollection sc = new StringCollection();
            sc.Add("sara");
            sc.Add("Sindhu");
            sc.Add("Ruthran");
            sc.Insert(4, "maya");// adding an item by Insert method.
            int result = sc.IndexOf(name);
            if (result > 0)
                IsElementExist = true;
            return IsElementExist;

        }
    }
}
