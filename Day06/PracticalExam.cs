using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class PracticalExam: Exam
    {
        public PracticalExam()
        {
            
        }
        public PracticalExam(Subject sub, DateTime time, int num_que) : base(time, sub, num_que) { }
        public override string ShowExam(Question q)
        {
           if (q.Choose!=0)return $"***********{sub}******************\n{time}\n{q.DespQ(q)}\n{q.Yourinput(q)}\n{q.correct()}";

          else return $"***********{sub}******************\n{time}\n{q.DespQ(q)}\n{q.Yourinput(q)}\n{q.cor()}";
             
        }
    }
}
