namespace ClassLibrary1
{
    public struct hire_data 
    { //4.	Develop a Structure to represent the Hiring Date Data Type consisting of fields to hold the day, month and Years.
        private int day;
        private int month;
        private int year;
        public hire_data()
        {

        }
        public hire_data (int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public void set_day(int _day)
        {
            day = _day;

        }
        public void set_mon(int _month)
        {
            month = _month;

        }
        public void set_year(int _year)
        {
            year = _year;

        }
        public int get_day() {
            return day;
        }
        public int get_month()
        {
            return month;
        }
        public int get_year() { return year; }
        public override  string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        //public int comper(hire_data other)
        //{
        //    return year.CompareTo(other.year) & month.CompareTo(other.month)& day.CompareTo(other.day);
        //}
        //public int get_sort(int _year,int _month,int _day)
        //{
        //    return year;
        //}


    }
}
