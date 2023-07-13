using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgeInYearsAnMonths
{
    public class CalculateAge
    {
        public DateTime _DOB { get; set; }
        public CalculateAge(DateTime DOB)
        {
            _DOB = DOB;
        }

        public string CalculateAgeFunc()
        {
            // Calculate the age in (years,month,days) formate based on the current date
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime curdate = DateTime.Now.ToLocalTime();

            TimeSpan span = curdate - _DOB;

            // because we start at year 1 for the Gregorian 
            // calendar, we must subtract a year here.

            int years = (zeroTime + span).Year - 1;
            int months = (zeroTime + span).Month - 1;
            int days = (zeroTime + span).Day;

            string age = $"{years} Years, {months} Months, {days} Days";
            return age;
        }
    }
}
