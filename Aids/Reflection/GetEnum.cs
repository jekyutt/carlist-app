using System;
using SemestriProject.Aids.Methods;

namespace SemestriProject.Aids.Reflection {

    public static class GetEnum {

        public static int Count<T>() => Count(typeof(T));

        public static T Value<T>(int i)
            => Safe.Run(() => (T) Value(typeof(T), i), default);

        public static int Count(Type type)
            => Safe.Run(() => Enum.GetValues(type).Length, -1);

        public static object Value(Type type, int i)
            => Safe.Run(() => {
                var v = Enum.GetValues(type);

                return v.GetValue(i);
            }, null);

    }

}



