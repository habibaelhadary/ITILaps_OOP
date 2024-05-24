using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal abstract class Exam
    {
        protected Subject sub;
        protected DateTime time;
        
        protected int num_que;
        public Exam()
        {
            this.sub = new Subject("Math");
            this .time = DateTime.Now;
          
            this.num_que = 3;
            
        }
        public Exam(DateTime time,Subject sub,int num_que)
        {
            this.sub = sub;
            this.time = time;
           
            this.num_que = num_que;
        }
        public DateTime Time { get { return time; } set { value = time; } }
        public Subject Sub { get { return sub; } set { value = sub; } }
        public int NumQue { get { return num_que; } set {value=num_que; } }

        public abstract string ShowExam (Question q);


    }
}
