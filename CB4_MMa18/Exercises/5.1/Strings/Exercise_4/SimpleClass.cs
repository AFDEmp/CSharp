using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class SimpleClass
    {
        public int Integer { get; set; }
        public float Float { get; set; }
        public long Long { get; set; }
        public double Double { get; set; }

        public override string ToString()
        {
            return string.Format("Integer has value: {0}\nFloat has value: {1}\nLong has value: {2}\nDouble has value: {3}", Integer, Float, Long, Double);
        }
    }
}
