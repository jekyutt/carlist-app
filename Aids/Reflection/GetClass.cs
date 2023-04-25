using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using SemestriProject.Aids.Classes;
using SemestriProject.Aids.Methods;

namespace SemestriProject.Aids.Reflection {

    public static class GetClass {

        private static string g => "get_";
        private static string s => "set_";
        private static string a => "add_";
        private static string r => "remove_";
        private static string c => ".ctor";
        private static string v => "value__";
        private static string t => "+TestClass";

        public static string Namespace(Type type) => type is null ? string.Empty : type.Namespace;

        public static List<MemberInfo> Members(Type type,
            BindingFlags f = PublicFlagsFor.All,
            bool clean = true) {
            if (type is null) return new List<MemberInfo>();
            var l = type.GetMembers(f).ToList();
            if (clean) removeSurrogates(l);

            return l;
        }

        public static List<PropertyInfo> Properties(Type type,
            BindingFlags f = PublicFlagsFor.All)
            => type?.GetProperties(f).ToList() ?? new List<PropertyInfo>();

        public static PropertyInfo Property<T>(string name)
            => Safe.Run(() => typeof(T).GetProperty(name), null);

        public static PropertyInfo Property<T>(Expression<Func<T, object>> e) {
            var n = GetMember.Name(e);

            return Safe.Run(() => typeof(T).GetProperty(n), null);
        }

        private static void removeSurrogates(IList<MemberInfo> l) {
            for (var i = l.Count; i > 0; i--) {
                var m = l[i - 1];

                if (!isSurrogate(m)) continue;
                l.RemoveAt(i - 1);
            }
        }

        private static bool isSurrogate(MemberInfo m) {
            var n = m.Name;

            if (string.IsNullOrEmpty(n)) return false;
            if (n.Contains(g)) return true;
            if (n.Contains(s)) return true;
            if (n.Contains(a)) return true;
            if (n.Contains(r)) return true;
            if (n.Contains(v)) return true;

            return n.Contains(t) || n.Contains(c);
        }

        public static List<object> ReadWritePropertyValues(object obj) {
            var l = new List<object>();

            if (obj is null) return l;

            foreach (var p in Properties(obj.GetType())) {
                if (!p.CanWrite) continue;
                addValue(p, obj, l);
            }

            return l;
        }

        private static void addValue(PropertyInfo p, object o, List<object> l) {
            var indexer = p.GetIndexParameters();

            if (indexer.Length == 0) l.Add(p.GetValue(o));
            else {
                var i = 0;

                while (true) {
                    try { l.Add(p.GetValue(o, new object[] {i++})); }
                    catch {
                        l.Add(i);

                        return;
                    }
                }
            }
        }

    }

}





