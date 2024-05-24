using ClassLibrary1;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region one
            Console.WriteLine("enter num of emp ");
            int num = int.Parse(Console.ReadLine());
            employ[] emp = new employ[num];
            hire_data da= new hire_data();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"employee{i + 1}");
                Console.WriteLine($"===========================================");
                Console.WriteLine("enter your id");
                string id = Console.ReadLine();
                Console.WriteLine("enter your security level");
                int sl = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your salary");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("enter  data");

                Console.WriteLine(" First enter your day");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your month");
                int mont = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your year");
                int year = int.Parse(Console.ReadLine());
                da = new hire_data(day, mont, year);
                Console.WriteLine("enter your Gender ");
                string g = Console.ReadLine();
                emp[i] = new employ(id, sl, salary, da, g);
                Console.WriteLine($"===========================================");

            }
           Array.Sort(emp);
            Console.WriteLine($"===========================================");
            
            //Console.WriteLine(Array.Sort(emp,da.comper));
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"employee{i + 1}: {emp[i].print()}");
            }
            
            #endregion
            #region second
            //Math math = new Math();

            #endregion

            #region static
            //Console.WriteLine("Enter first num");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second num");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Summtion = {Math.sum(num1, num2)}");
            //Console.WriteLine($"Sub = {Math.sub(num1, num2)}");
            //Console.WriteLine($"Multiply = {Math.mul(num1, num2)};");
            //Console.WriteLine($"Divide = {Math.div((double)num1, (double)num2)}");


            #endregion
        }
    }
}
