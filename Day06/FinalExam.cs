using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class FinalExam : Exam
    {
        public FinalExam() { }
        public FinalExam(Subject sub, DateTime time,  int num_que) : base(time, sub, num_que) { }
        public override string ShowExam(Question q)
        {

            if (q.Choose != 0) return $"{q.DespQ(q)}\n{q.Yourinput(q)}";

            else return $"{q.DespQ(q)}\n{q.Yourinput(q)}";
        }



    }
}
