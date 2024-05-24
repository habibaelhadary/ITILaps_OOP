namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("----Simple Calculator");
            Console.Write("enter num1: ");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("enter num2: ");
            num2=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Operation Avaliable : '+', '-','*','/' ");
            Console.WriteLine("enter operation = ");
           char Op=(char)Console.Read();
            switch (Op)
                {case '+': Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case '-': Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case '*': Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                if (num2 == 0) { Console.WriteLine("Valid"); }
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            default: Console.WriteLine("not ava");
                break; }


        }
    }
}
