using SemestriProject.Aids.Methods;

namespace SemestriProject.Aids.Extensions {

    public static class Decimals {

        public static decimal Add(this decimal x, decimal y) => Safe.Run(() => x + y, decimal.MaxValue);

        public static decimal Divide(this decimal x, decimal y) => Safe.Run(() => x / y, decimal.MaxValue);

        public static decimal Subtract(this decimal x, decimal y) => Safe.Run(() => x - y, decimal.MaxValue);

        public static decimal Multiply(this decimal x, decimal y) => Safe.Run(() => x * y, decimal.MaxValue);

        public static decimal Opposite(this decimal x) => Subtract(decimal.Zero, x);

        public static decimal Inverse(this decimal x) => Divide(decimal.One, x);

        public static decimal Square(this decimal x) => Multiply(x, x);

    }

}
