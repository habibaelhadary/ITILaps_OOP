
namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 array des
            //int[] arr = [100, -100, 10000, -10000, 2, 0, 444];
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //Console.WriteLine("First Solution");
            //Console.WriteLine($"===========================================");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"===========================================");
            //Console.WriteLine("Second Solution");
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"===========================================");
            #endregion
            #region Task2 reve
            //Console.WriteLine("Enter your number want fraction: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"frac num: {fra(num)}");

            #endregion
            #region task3

            Console.WriteLine(Convert.ToInt16("100"));
            Console.WriteLine(Convert.ToInt16(null));
            
            //Console.WriteLine(int.Parse("")); //thows FormatException
            Console.WriteLine(int.Parse("100"));  // throws FormatException
            Console.WriteLine(int.Parse(null));//thows FormatException
            #endregion
            #region 3Dpoint
            //Console.WriteLine("Enter your number 1 ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your number 2 ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your number 3 ");
            //int num3 = int.Parse(Console.ReadLine());

            //_3Dpoint dpoint = new _3Dpoint(num1, num2, num3);
            //Console.WriteLine(dpoint.ToString());
            //string str = (string)dpoint;
            //Console.WriteLine(str);

            #endregion
            #region last
            //Console.WriteLine("Enter your seconds ");
            //int num1 = int.Parse(Console.ReadLine());

            //Duration d1 = new Duration(num1);
            //Console.WriteLine(d1.ToString());
            //Console.WriteLine("==============================");
            //Console.WriteLine("Enter your seconds ");
            //int num2 = int.Parse(Console.ReadLine());
            //Duration d2 = new Duration(num2);
            //Console.WriteLine(d2.ToString());
            //Console.WriteLine("==============================");
            //Duration d3;
            //    d3=d1+d2;
            //Console.WriteLine($"D3=D1+D2 : {d3}");
            // d3 = d1 + 7800;
            //Console.WriteLine($"D3=D1 + 7800: {d3}");
            //d3 = d1 + 7800;
            //Console.WriteLine($"D3=D1 + 7800: {d3}");
            //d3 = 666 + d3;
            //Console.WriteLine($"D3=666+D3: {d3}");
            //d3 = d1++;
            //Console.WriteLine($"D1++:  {d3}");
            //d3 =--d2;
            //Console.WriteLine($"D2: {d3}");
            //Console.WriteLine($"If ( D1>D2): {d1 > d2}");

            //Console.WriteLine($"If D1 < D2: {d1 < d2}");
            //DateTime Obj = (DateTime)d1;
            //Console.WriteLine(Obj);
            #endregion
        }
        public static long fra(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            
            return num * fra(num - 1);
        }
    }
}
