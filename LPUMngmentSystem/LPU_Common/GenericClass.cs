using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPU_Common
{
    /// <summary>
    /// Custom generic class created for Demo purpose
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClass<T>
    {
        
        /// <summary>
        /// Custom Generic Method
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        public void SwapMe(ref T obj1,ref T obj2)
        {
            T temp;
            temp=obj1;
            obj1 = obj2;
            obj2 = temp;
        }
    }
}