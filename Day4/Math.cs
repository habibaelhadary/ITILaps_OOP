using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal static class Math
    {
        //int num1;
        //int num2;
        //public Math() { }
        //public Math(int num1, int num2) { 
        //    this.num1 = num1;
        //    this.num2 = num2;
        //}
        //public int sum(int A, int B)
        //{
        //    return A + B;
        //}
        //public  int sub(int A, int B)
        //{
        //    return A - B;
        //}
        //public  long mul(int A, int B)
        //{
        //    return (A * B);
        //}
        //public  double div(double A, double B)
        //{
        //    if (B == 0) return 0;
        //    else return (A / B);
        //}

        public static int sum(int A, int B)
        {
            return A + B;
        }
        public static int sub(int A, int B)
        {
            return A - B;
        }
        public static long mul(int A, int B)
        {
            return (A * B);
        }
        public static double div(double A, double B)
        {
            if (B == 0) return 0;
            else return (A / B);
        }

    }
}
