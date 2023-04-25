using System.Linq;
using SemestriProject.Aids.Methods;
using SemestriProject.Aids.Regions;

namespace SemestriProject.Aids.Extensions {

    public static class Booleans {

        internal static string[] anyTrue { get; } = {"TRUE", "T", "YES", "Y"};

        internal static string[] anyFalse { get; } = {"FALSE", "F", "NO", "N", string.Empty};

        public static bool ToBoolean(string s) {
            s = ToBooleanString(s);

            if (string.IsNullOrEmpty(s)) return false;

            return bool.TryParse(s, out var b) && b;
        }

        public static string ToBooleanString(string s) {
            if (IsTrueString(s)) return ToString(true);

            return IsFalseString(s) ? ToString(false) : s;
        }

        public static bool IsFalseString(string s)
            => Safe.Run(() => anyFalse.ToList().Contains(s.ToUpper().Trim()), false);

        public static bool IsTrueString(string s)
            => Safe.Run(() => anyTrue.ToList().Contains(s.ToUpper().Trim()), false);

        public static string ToString(bool value) => value.ToString(UseCulture.Invariant);

        public static bool Add(this bool x, bool y) => x.Or(y);

        public static bool Multiply(this bool x, bool y) => x.And(y);

        public static bool Not(this bool b) => !b;

        public static bool And(this bool x, bool y) => x && y;

        public static bool Or(this bool x, bool y) => x || y;

        public static bool Xor(this bool x, bool y) => x ^ y;

    }

}
