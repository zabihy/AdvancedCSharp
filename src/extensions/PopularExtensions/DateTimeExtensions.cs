using System;
using System.Collections.Generic;
using System.Text;

namespace PopularExtensions
{
    public static class DateTimeExtensions
    {
        public static string GetJalaliDate(this DateTime gregorianDate)
        {
            System.Globalization.PersianCalendar persianCal = new System.Globalization.PersianCalendar();

            string FarsiDateConverted = persianCal.GetYear(gregorianDate).ToString("0000") + "/" +
                         persianCal.GetMonth(gregorianDate).ToString("00") + "/" +
                         persianCal.GetDayOfMonth(gregorianDate).ToString("00");

            return FarsiDateConverted;
        }

        public static string GetJalaliMonth(this DateTime gregorianDate)
        {
            System.Globalization.PersianCalendar persianCal = new System.Globalization.PersianCalendar();
            int monthNo = persianCal.GetMonth(gregorianDate);
            switch (monthNo)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                default:
                    return "اسفند";

            }
        }

        public static string GetJalaliYear(this DateTime gregorianDate)
        {
            System.Globalization.PersianCalendar persianCal = new System.Globalization.PersianCalendar();
            int year = persianCal.GetYear(gregorianDate);
            return year.ToString();
        }

        public static int GetJalaliDay(this DateTime gregorianDate)
        {
            System.Globalization.PersianCalendar persianCal = new System.Globalization.PersianCalendar();
            return persianCal.GetDayOfMonth(gregorianDate);
        }

        public static string GetJalaliDayOfWeek(this DateTime gregorianDate)
        {
            System.Globalization.PersianCalendar persianCal = new System.Globalization.PersianCalendar();

            DayOfWeek dayOfWeek = persianCal.GetDayOfWeek(gregorianDate);

            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                default:
                    return "جمعه";
            }
        }
    }

}
