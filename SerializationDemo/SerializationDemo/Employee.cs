using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [NonSerialized] //cant apply non serializable to property, need fields for that
        //public int Salary { get; set; }
        int sal;
        public int Salary
        {
            get
            {
                return sal;
            }
            set
            {
                sal = value;
            }
        }
    }
}
