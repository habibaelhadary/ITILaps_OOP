using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day3
{
     class emp
    {/*3.	Employees are identified by an ID, security level, salary, hire date and Gender.*/
        private string id;
        private int se_lvel;
        private decimal salary;
        private hire_data hiredate;
        private string Gender;
        //8.	Define all the Necessary Constructors for the Structure
        public emp(string _id , int _se_lvel ,decimal _salary ,hire_data _hire_Data,string _Gender) {
            id = _id;
            se_lvel = _se_lvel;
            salary = _salary;
            hiredate = _hire_Data;
            Gender = _Gender;


        }
        //Implement All the Necessary Member Functions on the Structure(Getters, Setters)
        public void setId(string _id)
        {
            id= _id;
        }
        public void setsl(int sl)
        {
            se_lvel = sl;
        }
        public void setsal(decimal _salary)
        {
            salary = _salary;
        }
        public void setGender(string _Gender)
        {
            Gender = _Gender;
        }
        public void sethd(hire_data _hire_Data)
        {
            hiredate = _hire_Data;
        }
        public string getid() { return id; }
        public decimal getsl()
        {
            return salary;
        }
        public string getgen()
        {
            return Gender;
        }
        public hire_data geth() { return hiredate; }
        public int getslv()
        {
            return se_lvel;
        }

        //public void datahire(int[] _hiredata) {
        //    DateTime d= new DateTime(_hiredata[0], _hiredata[1], _hiredata[2]);
        //    Console.WriteLine(d);
        //}
        //5.	We want to provide the Employee structure with the standard capabilities to
        //represent Employee data in a string Form(override ToString()), display employee salary in a currency format.
        //[use String.Format Function, do you need additional using Directive]
        public string print()
        {

            return $"\n id:{id}\n {hiredate.ToString()}\n secuir:{se_lvel}\nSalary: {salary:C} \n Gender: {Gender}";
            

        }


    }
}
