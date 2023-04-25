using System;
using System.Globalization;
using SemestriProject.Aids.Constants;
using SemestriProject.Aids.Regions;

namespace SemestriProject.Aids.Values {

    public static class Converting {

        public static bool ToDecimal(string s, out decimal d)
            => decimal.TryParse(s, NumberStyles.Any, UseCulture.Invariant, out d);

        public static bool ToDecimal(object o, out decimal v) {
            v = decimal.Zero;
            var r = true;

            if (o is string str) return ToDecimal(str, out v);
            if (o is decimal m) v = m;
            else if (o is double d) v = Convert.ToDecimal(d);
            else if (o is float f) v = Convert.ToDecimal(f);
            else if (o is long l) v = Convert.ToDecimal(l);
            else if (o is int i) v = Convert.ToDecimal(i);
            else if (o is short s) v = Convert.ToDecimal(s);
            else if (o is sbyte sb) v = Convert.ToDecimal(sb);
            else if (o is ulong ul) v = Convert.ToDecimal(ul);
            else if (o is uint u) v = Convert.ToDecimal(u);
            else if (o is ushort us) v = Convert.ToDecimal(us);
            else if (o is byte b) v = Convert.ToDecimal(b);
            else r = false;

            return r;
        }

        public static decimal ToDecimal(object o) {
            ToDecimal(o, out var d);

            return d;
        }

        public static string ToString(this decimal a) => a.ToString(UseCulture.Invariant);

        public static double ToYears(this TimeSpan a) => a.TotalDays / Astronomical.DaysPerYear;

        public static double ToMonths(this TimeSpan a) => a.TotalDays / Astronomical.DaysPerMonth;

        public static double ToDays(this TimeSpan a) => a.TotalDays;

        public static double ToHours(this TimeSpan a) => a.TotalHours;

        public static double ToMinutes(this TimeSpan a) => a.TotalMinutes;

        public static double ToSeconds(this TimeSpan a) => a.TotalSeconds;

    }

}
