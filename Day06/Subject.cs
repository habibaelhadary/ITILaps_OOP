using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Subject
    {
        public string NameSub { get; set; }
        
        public Subject()
        {
            this.NameSub = "Math";
        }
        public Subject(string name) { 
           this. NameSub = name;
        }
    }
}
