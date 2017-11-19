using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsBindSample
{
    public class Class
    {
        public string name { get; set; }
        public int age { get; set; }
        public List<Sudent> students { get; set; }
    }

    public class Sudent
    {
        public int dad { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
