using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BPTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Birthdate:");
            String GetNextBirthDay = Console.ReadLine();

            if (GetNextBirthDay == null)
            {
                Console.WriteLine("Birth Date value is  Null.." + GetNextBirthDay);
            }
            else if (GetNextBirthDay == String.Empty)
            {
                Console.WriteLine("Birth Date value is  Empty.." + GetNextBirthDay);
            }
            else if (GetNextBirthDay.Length < 8)
            {
                Console.WriteLine("Birth Date formate is not valid.." + GetNextBirthDay);
            }

            //string GetNextBirthDay = "1999-7-30"; // Replace with the birthdate in "yyyy-MM-dd" format

            // Possible null reference argument.
            else
            {
                GetNextBirthDay = NextBithdDate.ValidateDateTimeFormat(GetNextBirthDay);
            }


            if (Regex.IsMatch(GetNextBirthDay, @"^\d{4}-(0?[1-9]|1[012])-(0?[1-9]|[12][0-9]|3[01])$"))
            {

                DateTime birthdate = DateTime.ParseExact(GetNextBirthDay, "yyyy-MM-dd", null);
                DateTime nextNextBirthday = NextBithdDate.GetNextNextBirthday(birthdate);


                Console.WriteLine("Your Next Birthday: " + nextNextBirthday.ToString("MMMM dd, yyyy"));
            }
            else
            {
                Console.WriteLine("Invalid birthdate format.");
            }


        }
    }
}