
using System;
using System.Linq;

namespace SemestriProject.Aids.Values {

    public static class AreTypes {

        public static bool Null(params object[] objects) {
            if (objects is null) return true;

            return !objects.Any() || objects.All(o => o is null);
        }

        public static bool DateTime(params object[] values) {
            return isTypeOf(values, IsType.DateTime);
        }

        public static bool String(params object[] values) {
            return isTypeOf(values, IsType.String);
        }

        public static bool Bool(params object[] values) => isTypeOf(values, IsType.Bool);

        public static bool Long(params object[] values) => isTypeOf(values, IsType.Long);

        public static bool Int(params object[] values) => isTypeOf(values, IsType.Int);

        public static bool Short(params object[] values) => isTypeOf(values, IsType.Short);

        public static bool SByte(params object[] values) => isTypeOf(values, IsType.SByte);

        public static bool ULong(params object[] values) => isTypeOf(values, IsType.ULong);

        public static bool UInt(params object[] values) => isTypeOf(values, IsType.UInt);

        public static bool UShort(params object[] values) => isTypeOf(values, IsType.UShort);

        public static bool Byte(params object[] values) => isTypeOf(values, IsType.Byte);

        public static bool Double(params object[] values) => isTypeOf(values, IsType.Double);

        public static bool Float(params object[] values) => isTypeOf(values, IsType.Float);

        public static bool Decimal(params object[] values) => isTypeOf(values, IsType.Decimal);

        public static bool AnyDouble(params object[] values) => isTypeOf(values, IsType.AnyDouble);

        public static bool AnyDecimal(params object[] values) => isTypeOf(values, IsType.AnyDecimal);

        public static bool TimeSpan(params object[] values) => isTypeOf(values, IsType.TimeSpan);

        public static bool AnyInt(params object[] values) => isTypeOf(values, IsType.AnyInt);

        public static bool AnyLong(params object[] values) => isTypeOf(values, IsType.AnyLong);

        private static bool isTypeOf(object[] values, Func<object, bool> isTypeOf) {
            if (values is null) return false;

            return values.Any() && values.All(isTypeOf);
        }

    }

}
