using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Home_Task_18._10.Models
{
    internal class ListInt
    {
        private int[] _arr;

        public int this[int index]
        {
            get
            {
                if (index< _arr.Length)
                {
                    return _arr[index];
                }
                return _arr[_arr.Length - 1];
                
            }
            set
            {
                if(index < _arr.Length)
                {
                    _arr[index] = value;
                }
            }
        }

        public ListInt()
        {
            _arr = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
        }
        public void AddRange(params int[] nums)
        {
            Array.Resize(ref _arr, _arr.Length +nums.Length);
        }
        public bool Contains(int num)
        {
            for (int i=0; i< _arr.Length; i++)
            {
                if (_arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int num in _arr)
            {
                sum += num;
            }
            return sum;
        }

        //public void Remove(int num)
        //{

        //}

        //public void RemoveRange(params int[] nums)
        //{

        //}

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int num in _arr)
            {
                stringBuilder.Append(num+",");
            }
            return stringBuilder.ToString();
        }
    }
}
