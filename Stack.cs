using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack(5);
            Console.WriteLine(stack1.Pop()); ;
            stack1.Push(12);
            stack1.Push(4);
            stack1.Push(9);
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());

        }
    }

    class Stack
    {
        int [] stackArray;
        int indis;
        public Stack(int length)
        {
            stackArray = new int[length];
            indis = 0;
        }

        bool CheckFull()
        {
            if (indis == stackArray.Length)
                return true;
            return false;
        }

        bool CheckEmpty()
        {
            if (indis == 0)
                return true;
            return false;

        }

        public void Push(int data)
        {
            if(!CheckFull())
            {
                stackArray[indis] = data;
                indis++;
            }
        }

        public int Pop()
        {
            int firstOut = 0;
            if(!CheckEmpty())
            {
                indis--;
                firstOut = stackArray[indis];
                stackArray[indis] = 0;
            }
            return firstOut;
        }

    }
}
