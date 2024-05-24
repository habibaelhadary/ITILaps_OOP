namespace Day2_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //long sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Entr num{i + 1}: ");
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;


            //}

            //Console.WriteLine($"summition = {sum}");
            #endregion
            Console.WriteLine("--------------*********************___________________");
            #region task2
            //long summ = 0;
            //int numm;
            //do
            //{
            //    Console.WriteLine("Enter your num : ");
            //    numm = int.Parse(Console.ReadLine());
            //    summ += numm;
            //    Console.WriteLine(summ);
            //} while (numm != 0 & summ < 100);
            #endregion
            Console.WriteLine("--------------*********************___________________");
            #region task3 The Avg Of Subject in 2d Array
            //Console.WriteLine("Please Enter num of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter num of colums: ");
            //int cols = int.Parse(Console.ReadLine());
            //int[,] arr = new int[rows, cols];
            //double[] avg = new double[cols];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.WriteLine($"Please Enter num of element({i + 1}, {j + 1})");
            //        int sub = int.Parse(Console.ReadLine());
            //        arr[i, j] = sub;
            //    }
            //}
            //Console.WriteLine("now Print your Avarage of colums");
            //Console.WriteLine("======================================================");

            //for (int k = 0; k < cols; k++)
            //{
            //    long sum = 0;
            //    for (int j = 0; j < rows; j++)
            //    {
            //        sum += arr[j, k];
            //        Console.Write($"    {arr[j, k]}\t");


            //    }

            //    avg[k] = sum / cols;
            //    Console.WriteLine($"Avarage of colu{k + 1} = {avg[k]}");
            //    Console.WriteLine();



            //}
            //Console.WriteLine("======================================================");

            #endregion
            Console.WriteLine("--------------*********************___________________");
            #region task4longest distance 
            //Console.Write("Enter number of Size array want: ");
            //int num = int.Parse(Console.ReadLine());
            //int[] array = new int[num];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"Enter your elment {i + 1}= ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Enter your elment want know long distance : ");
            //int want = int.Parse(Console.ReadLine());
            //int ind = Array.IndexOf(array, want);
            ////Console.WriteLine(ind);
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    if (array[i] == want)
            //    {
            //        Console.WriteLine($"Longest distance = {(i - ind)}");
            //        break;
            //    }
            //}
            #endregion
            Console.WriteLine("--------------*********************___________________");
            #region task5 reverse
            Console.WriteLine("Enter your text ");
            string s = Console.ReadLine();
            string[] str = s.Split();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write($"{str[i]} ");
                }
                #endregion

            }
    }
}
