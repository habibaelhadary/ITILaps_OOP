using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal  class Question
    {

        public string Head { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public int[] caa;
        public Answers[] Aswers { get; set; }
        public int[] Caa { get {return caa; } set {value=caa ; } }

        public int Choose { get; set; }
        public int ca;
        public int CA { get { return ca; } set { value = ca; } }
        public void setc(int []c)
        {
            this.caa = c;
        }
        public int [] CH { get; set; }
        public Question()
        {
            
        }
        public Question(string Head,string Body,int Mark,Answers []Aswers,int choice)
        {
           this.Head = Head;
            this.Body = Body;
            this.Mark = Mark;
            this.Aswers = Aswers;
            this.Choose = choice;

            
        }
        public Question(string Head, string Body, int Mark, Answers[] Aswers, int[] CH)
        {
            this.Head = Head;
            this.Mark = Mark;
            this.Body = Body;
            this.Aswers = Aswers;
            this.CH = CH;
        }
        
      
        public  string DespQ(Question q)
        {
            return $"{Head}\t \t Marks:{Mark}\n{Body}\n\t1.{Aswers[0]}\n\t2.{Aswers[1]}\n\t3.{Aswers[2]}\n\t4.{Aswers[3]}\n";
        }
        public virtual string Yourinput (Question q)
        {
            return $"{Choose}";
        }
        public virtual string cor()
        {
            string c = "";
            for (int i = 0; i < 4; i++)

            { 
               
                if (caa[i] != 0)
                    c += $"{caa[i]}.{Aswers[caa[i] - 1]}\n";

            }
           

            return $"The correct answer: {c}";
        }
        public string correct() {
            return $"The correct answer: {Choose}";
        }
        
    }
}
