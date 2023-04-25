using System;
using System.Globalization;
using SemestriProject.Aids.Regions;

namespace SemestriProject.Aids.Extensions {
    public static class Integers {
        public static int ToInteger(object o)
        {
            ToInteger(o, out var i);
            return i;
        }
        private static bool tryParse(string s, out int i) {
            var b = int.TryParse(s, NumberStyles.Any, UseCulture.Invariant, out i);
            if (!b) i = int.MaxValue;

            return b;
        }

        private static bool tryConvert<T>(T x, out int i) {
            i = int.MaxValue;

            try {
                i = Convert.ToInt32(x);

                return true;
            }
            catch { return false; }
        }

        public static bool ToInteger(object o, out int i) {
            i = int.MaxValue;

            return o switch {
                string s => tryParse(s, out i),
                sbyte i8 => tryConvert(i8, out i),
                short i16 => tryConvert(i16, out i),
                int i32 => tryConvert(i32, out i),
                byte u8 => tryConvert(u8, out i),
                ushort u16 => tryConvert(u16, out i),
                uint u32 => tryConvert(u32, out i),
                _ => false
            };
        }
    }
}
