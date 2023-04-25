using System;
using System.Globalization;
using SemestriProject.Aids.Methods;
using SemestriProject.Aids.Regions;

namespace SemestriProject.Aids.Extensions {

    public static class Doubles {

        public static double Add(this double x, double y) => Safe.Run(() => x + y, double.NaN);

        public static double Divide(this double x, double y) => Safe.Run(() => x / y, double.NaN);

        public static double Opposite(this double x) => Subtract(0, x);

        public static double Multiply(this double x, double y) => Safe.Run(() => x * y, double.NaN);

        public static double Power(this double x, double y)
            => Safe.Run(() => Math.Pow(x, y), double.NaN);

        public static double Inverse(this double x) => Divide(1, x);

        public static double Sqrt(this double x) => Safe.Run(() => Math.Sqrt(x), double.NaN);

        public static double Subtract(this double x, double y) => Safe.Run(() => x - y, double.NaN);

        public static double Square(this double x) => Multiply(x, x);

        public static double Delta(this double d) => Math.Abs(d / 1E7);

        public static double ToDouble(object o) {
            ToDouble(o, out double d);
            return d;
        }

        public static bool TryParse(string s, out double d) {
            return double.TryParse(s, NumberStyles.Any,UseCulture.Invariant, out d);
        }

        public static bool ToDouble(object o, out double d)
        {
            d = double.NaN;
            var r = true;
            var s = o as string;
            if (s != null) return TryParse(s, out d);
            if (o is double) d = (double)o;
            else if (o is float) d = Convert.ToDouble((float)o);
            else if (o is long) d = Convert.ToDouble((long)o);
            else if (o is int) d = Convert.ToDouble((int)o);
            else if (o is short) d = Convert.ToDouble((short)o);
            else if (o is sbyte) d = Convert.ToDouble((sbyte)o);
            else if (o is ulong) d = Convert.ToDouble((ulong)o);
            else if (o is uint) d = Convert.ToDouble((uint)o);
            else if (o is ushort) d = Convert.ToDouble((ushort)o);
            else if (o is byte) d = Convert.ToDouble((byte)o);
            else if (o is decimal) d = Convert.ToDouble((decimal)o);
            else r = false;
            return r;
        }

    }

}
