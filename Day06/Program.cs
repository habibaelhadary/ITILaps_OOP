using Day06;

Console.WriteLine($"*****================================****\n************************************** Welcom in Exmanition System***************************");

//Console.WriteLine(" If first come in the System should enter Are you Teacher or Student ?! Please Enter T / S");
Console.WriteLine(" first the Teacher put the Exam  ");


    //char person = char.Parse(Console.ReadLine());
    //if (person == 'T')
    //{
    Console.WriteLine($"What want put type Exam \n \t 1.Final Exam \n \t 2.Practical Exam \n please Enter(1 or 2)");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine($"Enter your Subject want: ");
    string Subj = Console.ReadLine();
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Enter data of day Want: {please write as example(2023/09/01) }");
    string data = Console.ReadLine();
    Console.WriteLine("Enter Time Want:{please write as example(04:30:00) }");
    data += " " + Console.ReadLine();
    DateTime d = DateTime.Parse(data);
    //DateTime d = DateTime.Now;
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Enter num of ques Want: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------------------------------------------------------------");
    Subject s = new Subject(Subj);
    Exam exam = new PracticalExam();

    if (x == 2)
    { exam = new PracticalExam(s, d, num); }
    else
    {
        exam = new FinalExam(s, d, num);
    }

    Question[] question = new Question[exam.NumQue];
    Answers[] ans = new Answers[4];
    for (int i = 0; i < question.Length; i++)
    {
        Console.WriteLine($"what want type Question put in Question{i + 1}\n\t1.TureorFalse \n\t2.Choose one\n\t3.Mult Choose");
        int typ = int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine($"Enter Header of question({i + 1})");
        string headr = Console.ReadLine();
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine($"Enter Mark of question({i + 1})");
        int mark = int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine($"Enter body of question({i + 1})");
        string body = Console.ReadLine();
        Console.WriteLine("-----------------------------------------------------------------------------");

        Console.WriteLine($"Enter Answers of question({i + 1})");
        Answers[] arr = new Answers[4];
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{j + 1}.");
            string ss = Console.ReadLine();
            arr[j] = new Answers(ss);

        }
        Console.WriteLine("-----------------------------------------------------------------------------");
        //Console.WriteLine("pleas Enter Correct Answer: (1 or 2 or 3 or 4)");
        //int c=int.Parse( Console.ReadLine());
        //Console.WriteLine("-----------------------------------------------------------------------------");

        if (typ == 1)
        {
            Console.WriteLine("pleas Enter Correct Answer: (1 or 2 or 3 or 4)");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------");
            question[i] = new TrueorFalse(headr, body, mark, arr, c);
            question[i].ca = question[i].Choose;
        }
        else if (typ == 2)
        {
            Console.WriteLine("pleas Enter Correct Answer: (1 or 2 or 3 or 4)");
            int cd = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------");
            question[i] = new OneC(headr, body, mark, arr, cd);
            question[i].ca = question[i].Choose;
        }
        else if (typ == 3)
        {
            Console.WriteLine("pleas Enter Correct Answer: (1 or 2 or 3 or 4) if you want finish enter 0");
            int[] ch = new int[] { 0, 0, 0, 0 };

            for (int j = 0; j < 4; j++)
            {
                ch[j] = int.Parse(Console.ReadLine());

                if (ch[j] == 0)
                    break;
            }
            question[i] = new Question();

            question[i] = new AllC(headr, body, mark, arr, ch);
            Console.WriteLine(question);

            question[i].setc(ch);
            Console.WriteLine("-----------------------------------------------------------------------------");

        }
        else { Console.WriteLine("Faild"); }
        //question[i].ca = question[i].Choose;
        Console.WriteLine("*************************Now Show Qestion By Answer ***************************");
        Console.WriteLine(exam.ShowExam(question[i]));
        Console.WriteLine("==============================================================================");
        //Console.WriteLine("If countine put Exam (Y or N)");
    }

   
Console.WriteLine("*************************second the Exam praper for every students ***************************");

Console.WriteLine("Now IF any student exist want enter the Exam (Y or N)");
char p = char.Parse(Console.ReadLine());
Console.WriteLine($"What want put type Exam \n \t 1.Final Exam \n \t 2.Practical Exam \n please Enter(1 or 2)");
int R = int.Parse(Console.ReadLine());
if (p == 'Y')
{  Question qq=new Question();
    for (int i = 0; i < question.Length ; i++)
    {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine(question[i].DespQ(qq));
        Console.WriteLine("Please Enter your Answer");
        Console.WriteLine("pleas Enter Correct Answer: (1 or 2 or 3 or 4) If you enter Multi Choose enter 'Y or N' ");
        char M = char.Parse(Console.ReadLine());
        if (M == 'N')
        {
            int one = int.Parse(Console.ReadLine());
            question[i].Choose = one;
        }
        else
        {
            int[] inp= new int[4] {0,0,0,0};
            Console.WriteLine("When Finsh enter 0");
            for (int j = 0; j < 4; j++)
            {
                inp[j] = int.Parse(Console.ReadLine());

                if (inp[j] == 0)
                    break;
            }
            question[i].CH=inp;
        }

    }
   


if (R == 2)
    {
        exam = new PracticalExam(s, d, num);
        Console.WriteLine("*************************Now Show Qestion By Correct Answer ***************************");
        for (int i = 0;i < question.Length ; i++)
        {
            
            Console.WriteLine(exam.ShowExam(question[i]));
            Console.WriteLine("==============================================================================");
        }
    }
    else
    {
        exam = new FinalExam(s, d, num);
        Console.WriteLine("*************************Now Show Qestion By your Answer ***************************");
        for (int i = 0; i < question.Length; i++)
        {
            Console.WriteLine(exam.ShowExam(question[i]));
            Console.WriteLine("==============================================================================");
        }
  
    }

}

//}


