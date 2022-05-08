using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxOfThree
{
 
        public class MaxArray<T> where T : IComparable
        {
            public T[] array;

            public MaxArray(T[] array)
            {
                this.array = array;
            }

            public static T MaxValueOfMultipleUsingGenerics<T>(params T[] array)
            {
                Array.Sort(array);
                return array[array.Length - 1];
            }


        }
    }
