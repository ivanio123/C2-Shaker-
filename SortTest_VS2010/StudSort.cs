using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if VALUE_IS_DOUBLE
	using ValueType = System.Double;
#else
#if VALUE_IS_SHORT
	using ValueType = System.Int16;
#else
#if VALUE_IS_LONG
	using ValueType = System.Int64;
#else
using ValueType = System.Int32;
#endif
#endif
#endif

namespace SortTest
{
    class StudSort
    {
        // You may add more method(s) here, if needed 
        // (f.e., for recursive quicksort or recursive mergesort)

        public static ValueType[] Sort(ValueType[] data) // DON'T CHANGE this line!!!
        {
            ValueType border = 0;
            int left = 0;
            int right = data.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        border = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = border;
                        border = i;
                    }
                }
                right = (int)border;
                if (left >= right)
                {
                    break;
                }
                for (int i = right; i > left; i--)
                {
                    if (data[i - 1] > data[i])
                    {
                        border = data[i];
                        data[i] = data[i - 1];
                        data[i - 1] = border;
                        border = i;
                    }
                }
                left = (int)border;
            }
            return data;
        }
    }
}
