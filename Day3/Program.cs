using ClassLibrary1;

namespace Day3
{
    internal class Program
    {
        private static object hi;

        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("=================================");
            int[] arr = { 1, 2, 3 };
            Console.WriteLine("Befor calling Method");
            foreach (int i in arr)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.GetHashCode);
            Test(ref arr);
            Console.WriteLine();
            Console.WriteLine("After calling Method");
            foreach (int i in arr)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.GetHashCode);
            Console.WriteLine("=================================");

            Console.WriteLine("Using ref");
            Console.WriteLine("=================================");
            //int[] array = { 1, 2, 3 };
            //Console.WriteLine("Befor calling Method");
            //foreach (int i in arr)
            //{
            //    Console.Write($" {i} ");
            //}
            //Console.WriteLine(arr.GetHashCode);
            //Test(ref arr);
            //Console.WriteLine();
            //Console.WriteLine("After calling Method");
            //foreach (int i in arr)
            //{
            //    Console.Write($" {i} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(arr   .GetHashCode);
            //Console.WriteLine("=================================");
            #endregion
            #region task2
            //6.Create an array of Employees with size three(Employee[] EmpArr;)
            //emp[] employ = new emp[2];
            //hire_data da;
            //for (int i = 0; i < employ.Length; i++)
            //{
            //    Console.WriteLine($"employee{i + 1}");
            //    Console.WriteLine($"===========================================");
            //    Console.WriteLine("enter your id");
            //    string id = Console.ReadLine();
            //    Console.WriteLine("enter your security level");
            //    int sl = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter your salary");
            //    decimal salary = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("enter  data");

            //    Console.WriteLine(" First enter your day");
            //    int day = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter your month");
            //    int mont = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter your year");
            //    int year = int.Parse(Console.ReadLine());
            //    da = new hire_data(day, mont, year);


            //    Console.WriteLine("enter your Gender ");
            //    string g = Console.ReadLine();
            //    employ[i] = new emp(id, sl, salary, da, g);
            //    Console.WriteLine($"===========================================");

            //}
            //for (int i = 0; i < employ.Length; i++)
            //{
            //    Console.WriteLine($"employee{i + 1}: {employ[i].print()}");
            //}
            #endregion
        }

        #region Taskone

        static void Test( ref int[] arr)
        {
            arr= [1,2,3];
            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;

            }
        }
        #endregion
    }
}
