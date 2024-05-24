using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class AllC:Question
    {
        public int [] mChoose ;
        
        public int[] Mchoose { get { return mChoose; } set {value=mChoose; } }
       

        public AllC()
        {
            
            this.mChoose = new int[4]{ 0, 0, 0, 0 };
            
        }
        public AllC(string Head, string Body, int Mark, Answers[] Aswers,int[] CH) :base(Head, Body,Mark,Aswers,CH)
        {
           
        }
        public override string Yourinput(Question q)
        {
            string c = "";
            for (int i = 0; i < 4; i++)

            {
                
                if ( CH[i]!=0)
                    c += $"{CH[i]}.{Aswers[CH[i]-1]}\n";

            }
            return $"****Your Answer : \n {c}****";
        } 


    }
}
