using System;
using SemestriProject.Aids.Extensions;

namespace SemestriProject.Aids.Values {

    public static class Calculating {

        public static object Add(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).Add((bool) y);
            if (AreTypes.String(x, y)) return Strings.Add((string) x, (string) y);
            if (AreTypes.DateTime(x, y)) return ((DateTime) x).AddSafe((DateTime) y);
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).Add(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y))
                return Doubles.ToDouble(x).Add(Doubles.ToDouble(y));

            return null;
        }

        public static object Subtract(object x, object y) {
            if (AreTypes.DateTime(x, y)) return ((DateTime) x).SubtractSafe((DateTime) y);
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).Subtract(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y))
                return Doubles.ToDouble(x).Subtract(Doubles.ToDouble(y));

            return null;
        }

        public static object Multiply(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).Multiply((bool) y);
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).Multiply(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y))
                return Doubles.ToDouble(x).Multiply(Doubles.ToDouble(y));

            return null;
        }

        public static object Divide(object x, object y) {
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).Divide(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y))
                return Doubles.ToDouble(x).Divide(Doubles.ToDouble(y));

            return null;
        }

        public static object Power(object x, object y) {
            if (AreTypes.AnyDouble(x, y))
                return Doubles.ToDouble(x).Power(Doubles.ToDouble(y));

            return null;
        }

        public static object Inverse(object x) {
            if (AreTypes.AnyDecimal(x)) return Converting.ToDecimal(x).Inverse();
            if (AreTypes.AnyDouble(x)) return Doubles.ToDouble(x).Inverse();

            return null;
        }

        public static object Opposite(object x) {
            if (AreTypes.AnyDecimal(x)) return Converting.ToDecimal(x).Opposite();
            if (AreTypes.AnyDouble(x)) return Doubles.ToDouble(x).Opposite();

            return null;
        }

        public static object Square(object x) {
            if (AreTypes.AnyDouble(x)) return Doubles.ToDouble(x).Square();

            return null;
        }

        public static object Sqrt(object x) {
            if (AreTypes.AnyDouble(x)) return Doubles.ToDouble(x).Sqrt();

            return null;
        }


        public static object And(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).And((bool) y);

            return null;
        }

        public static object Or(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).Or((bool) y);

            return null;
        }

        public static object Xor(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).Xor((bool) y);

            return null;
        }

        public static object Not(object x) {
            if (AreTypes.Bool(x)) return ((bool) x).Not();

            return null;
        }

        public static object IsEqual(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).IsEqual((bool) y);
            if (AreTypes.String(x, y)) return ((string) x).IsEqual((string) y);
            if (AreTypes.DateTime(x, y)) return ((DateTime) x).IsEqual((DateTime) y);
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).IsEqual(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y)) return Doubles.ToDouble(x).IsEqual(Doubles.ToDouble(y));

            return null;
        }

        public static object IsGreater(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).IsGreater((bool) y);
            if (AreTypes.String(x, y)) return ((string) x).IsGreater((string) y);
            if (AreTypes.DateTime(x, y)) return ((DateTime) x).IsGreater((DateTime) y);
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).IsGreater(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y)) return Doubles.ToDouble(x).IsGreater(Doubles.ToDouble(y));

            return null;
        }

        public static object IsLess(object x, object y) {
            if (AreTypes.Bool(x, y)) return ((bool) x).IsLess((bool) y);
            if (AreTypes.String(x, y)) return ((string) x).IsLess((string) y);
            if (AreTypes.DateTime(x, y)) return ((DateTime) x).IsLess((DateTime) y);
            if (AreTypes.AnyDecimal(x, y)) return Converting.ToDecimal(x).IsLess(Converting.ToDecimal(y));
            if (AreTypes.AnyDouble(x, y)) return Doubles.ToDouble(x).IsLess(Doubles.ToDouble(y));

            return null;
        }

        public static object GetSecond(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetSecond();
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).Seconds;
            return null;
        }
        public static object GetMinute(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetMinute();
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).Minutes;
            return null;
        }
        public static object GetHour(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetHour();
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).Hours;
            return null;
        }
        public static object GetDay(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetDay();
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).Days;
            return null;
        }
        public static object GetMonth(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetMonth();
            return null;
        }
        public static object GetYear(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetYear();
            return null;
        }

        public static object GetInterval(object x, object y)
        {
            if (AreTypes.DateTime(x, y)) return ((DateTime)x).GetInterval((DateTime)y).Ticks;
            return null;
        }
        public static object GetAge(object x)
        {
            if (IsType.DateTime(x)) return ((DateTime)x).GetAge();
            return null;
        }

        public static object ToSeconds(object x)
        {
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).ToSeconds();
            if (IsType.DateTime(x)) return new TimeSpan(((DateTime)x).Ticks).ToSeconds();
            return null;
        }
        public static object ToMinutes(object x)
        {
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).ToMinutes();
            if (IsType.DateTime(x)) return new TimeSpan(((DateTime) x).Ticks).ToMinutes();
            return null;
        }
        public static object ToHours(object x)
        {
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).ToHours();
            if (IsType.DateTime(x)) return new TimeSpan(((DateTime)x).Ticks).ToHours();
            return null;
        }
        public static object ToDays(object x)
        {
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).ToDays();
            if (IsType.DateTime(x)) return new TimeSpan(((DateTime)x).Ticks).ToDays();
            return null;
        }
        public static object ToMonths(object x)
        {
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).ToMonths();
            if (IsType.DateTime(x)) return new TimeSpan(((DateTime)x).Ticks).ToMonths();
            return null;
        }
        public static object ToYears(object x)
        {
            if (IsType.TimeSpan(x)) return ((TimeSpan)x).ToYears();
            if (IsType.DateTime(x)) return new TimeSpan(((DateTime)x).Ticks).ToYears();
            return null;
        }

        public static object AddSeconds(object x, object y)
        {
            if (!IsType.AnyDouble(y)) return null;
            if (IsType.DateTime(x)) return ((DateTime)x).AddSecondsSafe(Doubles.ToDouble(y));
            return null;
        }
        public static object AddMinutes(object x, object y)
        {
            if (!IsType.AnyDouble(y)) return null;
            if (IsType.DateTime(x)) return ((DateTime)x).AddMinutesSafe(Doubles.ToDouble(y));
            return null;
        }
        public static object AddHours(object x, object y)
        {
            if (!IsType.AnyDouble(y)) return null;
            if (IsType.DateTime(x)) return ((DateTime)x).AddHoursSafe(Doubles.ToDouble(y));
            return null;
        }
        public static object AddDays(object x, object y)
        {
            if (!IsType.AnyDouble(y)) return null;
            if (IsType.DateTime(x)) return ((DateTime)x).AddDaysSafe(Doubles.ToDouble(y));
            return null;
        }
        public static object AddMonths(object x, object y)
        {
            if (!IsType.AnyInt(y)) return null;
            if (IsType.DateTime(x)) return ((DateTime)x).AddMonthsSafe(Integers.ToInteger(y));
            return null;
        }
        public static object AddYears(object x, object y)
        {
            if (!IsType.AnyInt(y)) return null;
            if (IsType.DateTime(x)) return ((DateTime)x).AddYearsSafe(Integers.ToInteger(y));
            return null;
        }
        public static object GetLength(object x)
        {
            if (IsType.String(x)) return Strings.GetLength((string)x);
            return null;
        }
        public static object ToUpper(object x)
        {
            if (IsType.String(x)) return Strings.ToUpper((string)x);
            return null;
        }
        public static object ToLower(object x)
        {
            if (IsType.String(x)) return Strings.ToLower((string)x);
            return null;
        }
        public static object Trim(object x)
        {
            if (IsType.String(x)) return Strings.Trim((string)x);
            return null;
        }
        public static object Substring(object x, object y)
        {
            if (IsType.String(x) && IsType.AnyInt(y)) return Strings.Substring((string)x, Integers.ToInteger(y));
            return null;
        }
        public static object Substring(object x, object y, object z)
        {
            if (!IsType.String(x) || !AreTypes.AnyInt(y, z)) return null;
            var r = Strings.Substring((string) x, Integers.ToInteger(y), Integers.ToInteger(z));
            return r;
        }
        public static object Contains(object x, object y)
        {
            if (AreTypes.String(x, y)) return Strings.Contains((string)x, (string)y);
            return null;
        }
        public static object EndsWith(object x, object y)
        {
            if (AreTypes.String(x, y)) return Strings.EndsWith((string)x, (string)y);
            return null;
        }
        public static object StartsWith(object x, object y)
        {
            if (AreTypes.String(x, y)) return Strings.StartsWith((string)x, (string)y);
            return null;
        }

    }

}