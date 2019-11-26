using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCRUD
{
    public class IntArray
    {
        private int[] arr;
        public IntArray()
        {
            arr = new int[4];
        }

        int count = 0;
        public void Add(int element)
        {
            
            int index = count;
            if(index == arr.Length)
            {
                Array.Resize(ref arr, arr.Length*2); 
            }
            arr[index] = element;
           
            count++;
        }

       
        public int Element(int index)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                throw new IndexOutOfRangeException("wrong index");
            }
            return arr[index];
        }
        public int Count()
        {
            return arr.Length;
        }

        public void SetElement(int index, int element)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                throw new IndexOutOfRangeException("wrong index");
            }
            arr[index] = element;
        }

        public bool Contains(int element)
        {
            foreach (int elem in arr)
            {
                if (elem == element)
                    return true;
            }
            return false;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                    return i;
            }
            return -1;
        }

        public void Insert(int index, int element)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                throw new IndexOutOfRangeException("wrong index");
            }
            for (int i = arr.Length - 1; i > index; i--)
                arr[i] = arr[i - 1];
            arr[index] = element;


        }

        public void Clear()
        {
            int[] temp = new int[0];
            arr = temp;
        }

        public void Remove(int element)
        {
            int position = this.IndexOf(element);
            if (position == -1)
                throw new Exception("Element not found");
            for (int i = position; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                throw new IndexOutOfRangeException("wrong index");
            }
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];

            }
            Array.Resize(ref arr, arr.Length - 1);

        }

    }

   
}
