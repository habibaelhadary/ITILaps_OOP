using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Answers
    {
        string text;

        public Answers()
        {
            
        }

        public Answers(string text)
        {
            this.text = text;
        }
        public string Text { get { return text ; } set { this.text = text; } }
        //public string Correctanswer { get; set; }   

        public override string ToString()
        {
            return $".{this.text}";
        }
    }
}
