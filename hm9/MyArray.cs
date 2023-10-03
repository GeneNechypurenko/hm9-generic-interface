using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace hm9
{
    internal class MyArray : ICalc, IOutput
    {
        public int Size { get; set; }
        private int[] _arr;
        public MyArray(int size)
        {
            _arr = new int[size];
            Size = size;
        }
        public int this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }
        public static MyArray operator +(MyArray a, MyArray b)
        {
            MyArray result = new MyArray(a.Size);

            for (int i = 0; i < a.Size; ++i)
            {
                result[i] = (dynamic)a[i] + b[i];
            }

            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Size; ++i)
            {
                sb.Append($"index[{i}]: {this[i]}\n");
            }

            return sb.ToString();
        }
        public void ReSize(int newSize)
        {
            int[] newArr = new int[newSize];
            Size = newSize;
            _arr = newArr;
        }
        public void Init()
        {
            for (int i = 0; i < _arr.Length; ++i)
            {
                _arr[i] = i;
            }
        }
        public void InitWithValue(int value)
        {
            for (int i = 0; i < _arr.Length; ++i)
            {
                _arr[i] = value;
            }
        }
        public void InitWithRand(int min, int max)
        {
            Random rand = new Random();

            for (int i = 0; i < _arr.Length; ++i)
            {
                _arr[i] = rand.Next(min, max);
            }
        }
        public int Less(int valueToCompare)
        {
            int count = 0;

            foreach (int item in _arr)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }
        public int Greater(int valueToCompare)
        {
            int count = 0;

            foreach (int item in _arr)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public void ShowEven()
        {
            foreach (int item in _arr)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"Even = {item}");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            foreach (int item in _arr)
            {
                if (item % 2 == 1)
                {
                    Console.WriteLine($"Odd = {item}");
                }
            }
            Console.WriteLine();
        }
    }
}