using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SemestriProject.Aids.Formats.Dates {

    public static class DateTime {

        public static ReadOnlyCollection<string> All {
            get {
                var s = new List<string>();
                s.AddRange(Date.All);
                s.AddRange(Time.All);

                foreach (var d in Date.All) {
                    foreach (var t in Time.All) {
                        s.Add(string.Format(Dot, d, t));
                        s.Add(string.Format(Space, d, t));
                        s.Add(string.Format(Invariant, d, t));
                    }
                }

                return new ReadOnlyCollection<string>(s);
            }
        }

        public static string Dot => "{0}.{1}";

        public static string Long => "yyyy-MM-dd HH:mm:ss";

        public static string Invariant => "{0}T{1}";

        public static string Short => "yyyy-MM-dd HH:mm";

        public static string Space => "{0} {1}";

        public static bool IsDateTime(string pattern) {
            if (Time.IsTime(pattern)) return false;

            return !Date.IsDate(pattern) && IsCorrect(pattern);
        }

        public static bool IsCorrect(string pattern)
            => All.Contains(pattern);

    }

}