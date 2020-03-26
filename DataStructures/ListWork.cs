using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class ListWork
    {

        //ListWork()
        //{
        //    List<int> lstInt = new List<int>() { 1, 2, 4, 3, 4 };
        //    lstInt.Add(23);
        //    lstInt.Add(234);

        //    List<string> lstString = new List<string>() { "saravanan", "Sindhu", "Muthu" };
        //    lstString.Add("Maya");
        //    lstString.Add("Ruthran");
        //    lstString.Add("Prabakaran");

        //}

        /// <summary>
        /// Remove Duplicate using HasSet Data Structure
        /// </summary>
        /// <param name="lstItems"></param>
        /// <returns></returns>
        public static List<string> RemoveDupsHasSet(List<string> lstItems)
        {
            List<string> lstOutput = new List<string>();
            var hasDups = new HashSet<string>();
            for (int i = 0; i < lstItems.Count; i++)
            {
                if (!hasDups.Contains(lstItems[i]))
                {
                    lstOutput.Add(lstItems[i]);
                    hasDups.Add(lstItems[i]);
                }
            }
            return lstOutput;
        }
        /// <summary>
        /// Remove Dups using For- Loop
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static List<string> RemoveDuplicatesIterative(List<string> items)
        {
            var result = new List<string>();
            //"x", "x", "y", "y", "y", "z" 
            //"0", "1", "2", "3", "4", "5" 
            for (int i = 0; i < items.Count; i++)
            {
                // Assume not duplicate.
                bool duplicate = false;
                for (int z = 0; z < i; z++)
                {
                    if (items[z].Equals(items[i]))
                    {
                        // This is a duplicate.
                        duplicate = true;
                        break;
                    }
                }
                // If not duplicate, add to result.
                if (!duplicate)
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public static List<T> RemoveDupsByGenericMethod<T>(List<T> lstInput)
        {
            List<T> result = new List<T>();
            HashSet<T> hasSet = new HashSet<T>();
            for (int i = 0; i < lstInput.Count; i++)
            {
                if (!hasSet.Contains(lstInput[i]))
                {
                    result.Add(lstInput[i]);
                    hasSet.Add(lstInput[i]);
                }
            }
            return result;
        }

    }
}
