using System;
using SemestriProject.Aids.Methods;

namespace SemestriProject.Aids.Extensions {

    public static class Dates {

        public static DateTime AddDaysSafe(this DateTime x, double y)
            => Safe.Run(() => x.AddDays(y), DateTime.MaxValue);

        public static DateTime AddHoursSafe(this DateTime x, double y)
            => Safe.Run(() => x.AddHours(y), DateTime.MaxValue);

        public static DateTime AddMinutesSafe(this DateTime x, double y) =>
            Safe.Run(() => x.AddMinutes(y), DateTime.MaxValue);

        public static DateTime AddMonthsSafe(this DateTime x, int y)
            => Safe.Run(() => x.AddMonths(y), DateTime.MaxValue);

        public static DateTime AddSecondsSafe(this DateTime x, double y) =>
            Safe.Run(() => x.AddSeconds(y), DateTime.MaxValue);

        public static DateTime AddYearsSafe(this DateTime x, int y)
            => Safe.Run(() => x.AddYears(y), DateTime.MaxValue);

        public static DateTime AddSafe(this DateTime x, DateTime y)
            => Safe.Run(() => x.Add(TimeSpan.FromTicks(y.Ticks)), DateTime.MaxValue);

        public static DateTime SubtractSafe(this DateTime x, DateTime y)
            => Safe.Run(() => x.Add(-TimeSpan.FromTicks(y.Ticks)), DateTime.MaxValue);

        public static int GetAge(this DateTime x, DateTime? reference = null) {
            int age()
            {
                var now = reference ?? DateTime.Now;
                var a = now.Year - x.Year;
                if (now < x.AddYears(a)) a--;
                return a;
            }

            return Safe.Run(age, int.MaxValue);
        }

        public static int GetDay(this DateTime x) { return Safe.Run(() => x.Day, int.MaxValue); }

        public static int GetHour(this DateTime x) { return Safe.Run(() => x.Hour, int.MaxValue); }

        public static int GetMinute(this DateTime x) { return Safe.Run(() => x.Minute, int.MaxValue); }

        public static TimeSpan GetInterval(this DateTime x, DateTime y) { return Safe.Run(() => x.Subtract(y), TimeSpan.MaxValue); }

        public static int GetMonth(this DateTime x) { return Safe.Run(() => x.Month, int.MaxValue); }

        public static int GetSecond(this DateTime x) { return Safe.Run(() => x.Second, int.MaxValue); }

        public static int GetYear(this DateTime x) { return Safe.Run(() => x.Year, int.MaxValue); }

        public static bool IsDateOnly(DateTime x) 
            => Safe.Run(() => x.TimeOfDay == TimeSpan.Zero, false);

    }

}
