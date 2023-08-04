using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BPTest
{
    public class NextBithdDate
    {
        public static DateTime GetNextNextBirthday(DateTime birthdate)
        {
            DateTime nextNextBirthday;
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthdate.Month, birthdate.Day);

            if (nextBirthday <= today)
            {
                nextNextBirthday = nextBirthday.AddYears(1);
            }
            else
            {
                nextNextBirthday = nextBirthday.AddYears(1);
            }
            return nextNextBirthday;
        }

        public static string ValidateDateTimeFormat(String GetNextBirthDay)
        {
            String[] BirthDayMothYear = GetNextBirthDay.Split('-');
            if (BirthDayMothYear[1].Length == 1)
            {
                BirthDayMothYear[1] = "0" + BirthDayMothYear[1];
            }
            if (BirthDayMothYear[2].Length == 1)
            {
                BirthDayMothYear[2] = "0" + BirthDayMothYear[2];
            }
            /* if (BirthDay[0].Length == 2)
             {
                 BirthDay[0] = "00" + BirthDay[0];
             }*/
            return BirthDayMothYear[0] + "-" + BirthDayMothYear[1] + "-" + BirthDayMothYear[2];
        }



    }
}