using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.InterviewQuestions
{
    public class DynamicArray
    {
        private int[] arr;
        private int _capacity;
        private int length;
        public DynamicArray(int capacity)
        {
            _capacity = capacity;
            arr = new int[capacity];
            length = 0;
        }

        public int Get(int i)
        {
            return arr[i];
        }
        public void set(int i, int n)
        {
            arr[i]= n;
        }

        public void pushback(int n)
        {
            if (length == _capacity)
            {
                resize();
            }
            arr[length] = n;
            length++;
        }

        public int popback()
        {
            if(length>0)
            {
                length--;
            }
            return arr[length];
        }

        public void resize()
        {
            _capacity = _capacity * 2;
            int[] newArra = new int[_capacity];
            for(int i = 0; i < arr.Length; i++)
            {
                newArra[i] = arr[i];
            }
            arr = newArra;
        }

        public int getSize()
        {
            return length;
        }

        public int getCapacity()
        {
            return _capacity;
        }
    }

    public class DynamicArrayProgram
    {
        public static void Main(string[] args)
        {
            DynamicArray dynamicArray = new DynamicArray(5);
            dynamicArray.getCapacity();
            dynamicArray.pushback(5);
            dynamicArray.popback();
            dynamicArray.resize();
            dynamicArray.pushback(5);
            dynamicArray.set(5,5);
        }
    }
}
