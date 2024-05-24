using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class OneC:Question
    {
        public int CA { get; set; }
        public OneC()
        {
            this.Head = "Qestion 2";
            this.Mark = 5;
            this.Body = "2 *2 ? ";
            this.Aswers = new Answers[] { new("1.(3)"), new("2.(4)"), new("3.(20)"), new("4.(50)") };
            this.Choose = 2;
            this.CA = 2;
        }
        public OneC(string Head, string Body, int Mark, Answers [] Aswers, int Choose) : base(Head, Body, Mark, Aswers, Choose)
        {

        }
   
        public override string Yourinput(Question q)
        {
            return $"****Your Answer :{Choose}.{Aswers[Choose - 1]}****";
        }
    }
}
