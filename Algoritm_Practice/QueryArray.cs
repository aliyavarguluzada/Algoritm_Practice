using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice
{
    public class QueryArray<T>
    {
        private T[] arr;
        private int arrSize;
        private const int defaultCapacity = 1_000;
        private int currentIndex;
        private bool eof;
        private bool bof;

        public T Current => arr[currentIndex];

        public QueryArray() : this(defaultCapacity)
        {

        }
        public QueryArray(int capacity)
        {
            arr = new T[capacity];
            arrSize = capacity;
            Reset();
        }

        public void Reset()
        {
            SetIndex(-1);
        }

        private void SetCurrent(int increase)
        {
            SetIndex(currentIndex + increase);

            eof = currentIndex >= arrSize - 1;
            bof = currentIndex == 0;
        }

        private void SetIndex(int index)
        {
            currentIndex = index;
        }

        public bool Next()
        {
            if (!eof)
            {
                SetCurrent(1);
                return true;
            }
            return false;
        }

        public bool Previous()
        {
            if (!bof)
            {
                SetCurrent(-1);
                return true;
            }
            return false;
        }
        public void LoadFromArray(T[] newArr)
        {
            Load(newArr);
        }
        private void Load(T[] newArr)
        {
            ArgumentNullException.ThrowIfNull(newArr);
            arr = newArr;
            arrSize = newArr.Length;
            Reset();
        }

        public static implicit operator QueryArray<T>(T[] array)
        {
            var q = new QueryArray<T>();
            q.LoadFromArray(array);
            return q;
        }
    }
}