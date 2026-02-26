using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{
    public class Product
    {
        //properties never carries the footprint, and fields do, they store data
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
