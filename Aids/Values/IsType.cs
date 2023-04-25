using System;

namespace SemestriProject.Aids.Values {

    public static class IsType {

        public static bool AnyDouble(object x) => x switch {
            double _ => true,
            float _ => true,
            _ => AnyDecimal(x)
        };

        public static bool AnyDecimal(object x) => x switch {
            decimal _ => true,
            ulong _ => true,
            _ => AnyLong(x)
        };


        public static bool AnyLong(object x) => x switch {
            long _ => true,
            uint _ => true,
            _ => AnyInt(x)
        };

        public static bool AnyInt(object x) => x switch {
            short _ => true,
            sbyte _ => true,
            ushort _ => true,
            byte _ => true,
            _ => (x is int)
        };

        public static bool TimeSpan(object x) => x is TimeSpan;

        public static bool DateTime(object x) => x is DateTime;

        public static bool String(object x) => x is string;

        public static bool Bool(object x) => x is bool;

        public static bool Long(object x) => x is long;

        public static bool Int(object x) => x is int;

        public static bool Short(object x) => x is short;

        public static bool SByte(object x) => x is sbyte;

        public static bool ULong(object x) => x is ulong;

        public static bool UInt(object x) => x is uint;

        public static bool UShort(object x) => x is ushort;

        public static bool Byte(object x) => x is byte;

        public static bool Float(object x) => x is float;

        public static bool Double(object x) => x is double;

        public static bool Decimal(object x) => x is decimal;

        public static bool Null(object o) => o is null;

    }

}
