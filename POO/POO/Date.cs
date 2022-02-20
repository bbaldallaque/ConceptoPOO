namespace POO
{
    public class Date
    {
        private readonly int _year;
        private readonly int _month;
        private readonly int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = Checkday(year, month, day);
        }

        private int Checkday(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid day");
        }

        private bool IsLeapYear(int year)
        {
            //fuciona mejor y es menos complicado de implementar
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

            //funciona pero no es manera de hacerlo, codigo complicado y poco legible
            //if (year % 4 == 0) // aqui preguntamos si es multiplo de 4
            //{
            //    if (year % 100 == 0)// aqui preguntamos si es multiplo de 100
            //    {
            //        if(year % 400 == 0)   // aqui preguntamos si es multiplo de 400 
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //       return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("Invalid month");
        }

        public override string ToString()
        {
            //funciona y es mejor implementacion
            return $"{_year}/{_month:00}/{_day:00}";

            //funciona pero no es la forma correcta
           // return _year + "/" + _month + "/" + _day;   
        }
    }
}
