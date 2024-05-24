using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Day4
{
    internal class employ :IComparable
    {
        private string id;
        private int se_lvel;
        private decimal salary;
        private hire_data hiredate;
        private string gender;
        private static int counter;
        public employ() { } 
        public employ(string id, int se_lvel, decimal salary, hire_data hiredate, string Gender) {
            this.id = id;    
            this.se_lvel= se_lvel;
            this.salary=salary;
            this.hiredate = hiredate;
            this.gender = Gender;
        }
        public string ID { get { return id; } set { id = value; } }
        public int Se_lvel { get { return se_lvel;} set { se_lvel = value; } }
        public decimal Salary { get { return salary; } set { salary = value; } }
        public hire_data Hiredate { get {  return hiredate; } set {  hiredate = value; } }  
        public string Gender { get { return gender; }set { gender = value; } }
        public static int get_coun()
        {
            return counter;
        }
        public string print()
        {

            return $"\n id:{id}\t hiredate: {hiredate.ToString()}\t secuir:{se_lvel}\tSalary: {salary:C} \t Gender: {gender}";


        }
        public int CompareTo(object emp)
        {  employ em= (employ)emp;
            //hire_data h=(hire_data)emp;
           if (this.hiredate.get_year() < em.hiredate.get_year() || this.hiredate.get_month() < em.hiredate.get_month() || this.hiredate.get_day() < em.hiredate.get_day())
            {
                return -1;
            }
            if (this.hiredate.get_year() > em.hiredate.get_year() || this.hiredate.get_month() > em.hiredate.get_month() || this.hiredate.get_day() > em.hiredate.get_day())
                return 1;
            return 0;
        }

    }
}
