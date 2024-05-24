using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class TrueorFalse:Question

    {
       
        public TrueorFalse()
        {
            this.Head = "Qestion 1";
            this.Mark = 5;
            this.Body = "2 *2 = 4 ? ";
            this.Aswers = new Answers[] {new("1.TRUE"),new("2.False"),new(""),new("")};
            this.Choose = 1;

        }

        public TrueorFalse(string Head, string Body, int Mark, Answers [] Aswers,int Choose) :base(Head, Body, Mark, Aswers,Choose)
        {
            
        }
     

        public override string Yourinput(Question q)
        {
            return $"****Your Answer :{Choose}.{Aswers[Choose-1]}****";
        }
    
    }
}
