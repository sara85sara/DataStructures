using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace DataStructures
{
    public class StackWork
    {
        Stack<int> stk = null;

        public StackWork()
        {
            stk = new Stack<int>();
            stk.Push(100000);
            stk.Push(10000);
            stk.Push(1000);
            stk.Push(100);
            stk.Push(10);
            stk.Push(1);

        }
        public void ShowStackElements()
        {
            foreach (int item in stk)
            {
                Console.WriteLine(item);
            }
        }
        public void Add(int input)
        {
            stk.Push(input);
        }
        public void Remove()
        {
            stk.Pop();
        }


    }
}
