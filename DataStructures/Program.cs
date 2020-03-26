using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = new string[4];
            array[0] = "Socrates";
            array[1] = "Plato";
            array[2] = "Maya";
            array[3] = "Maya";

            string[] dummy = new string[array.Length];

            int idx = 0;
            // Use for-loop on array.
            for (int i = array.Length - 1; i > 0; i--)
            {
                // Get element, and print index and element value.
                string element = array[i];
                dummy[idx] = array[i];
                idx++;

                Console.WriteLine("INDEX: {0}, VALUE: {1}", i, element);
            }

            //O365PremiumTenants obj = new O365PremiumTenants();
            //string jsonResult = obj.GetJsonValue();
            List<string> input = new List<string>() { "x", "x", "y", "y", "y", "z" };
            ListWork.RemoveDupsHasSet(input);

            ListWork.RemoveDuplicatesIterative(input);


            Problems.ReverseArrayWithList();
            Problems.SmallerNumbersThanCurrent(new int[] { 8 });
            int[] a = Problems.ReverseArray(new int[] { 4, 3, 2, 1 });
            foreach (int itm in a)
            {
                Console.WriteLine(itm);
            }
            Console.ReadLine();

            PizaBox objPiza = new PizaBox();
            objPiza.LargeBox = 1;
            objPiza.MediumBox = 1;
            objPiza.SmallBox = 1;



        }

        public PizaBox GetPizaBoxes(int slice)
        {
            PizaBox piza = new PizaBox();
            return piza;
        }
    }
    public enum PizaBoxCount
    {
        LargeBoxCount = 15,
        MediumBoxCount = 7,
        SmallBoxCount = 5
    }
    public class PizaBox
    {
        public int LargeBox { get; set; }
        public int MediumBox { get; set; }

        public int SmallBox { get; set; }
    }


}