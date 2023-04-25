using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SemestriProject.Aids.Formats.Dates {

    public static class Date {

        private static string[] allDayFirst { get; } = {
            "dd.MM.yyyy",
            "dd.M.yyyy",
            "d.MM.yyyy",
            "d.M.yyyy",
            "dd.MM.yy",
            "dd.M.yy",
            "d.MM.yy",
            "d.M.yy",
            "dd/MM/yyyy",
            "dd/M/yyyy",
            "d/MM/yyyy",
            "d/M/yyyy",
            "dd/MM/yy",
            "dd/M/yy",
            "d/MM/yy",
            "d/M/yy",
            "dd-MM-yyyy",
            "dd-M-yyyy",
            "d-MM-yyyy",
            "d-M-yyyy",
            "dd-MM-yy",
            "dd-M-yy",
            "d-MM-yy",
            "d-M-yy",
        };

        private static string[] allMonthFirst { get; } = {
            "yyyy.MM.dd",
            "yyyy.MM.d",
            "yyyy.M.dd",
            "yyyy.M.d",
            "yy.MM.dd",
            "yy.MM.d",
            "yy.M.dd",
            "yy.M.d",
            "yyyy/MM/dd",
            "yyyy/MM/d",
            "yyyy/M/dd",
            "yyyy/M/d",
            "yy/MM/dd",
            "yy/MM/d",
            "yy/M/dd",
            "yy/M/d",
            "yyyy-MM-dd",
            "yyyy-MM-d",
            "yyyy-M-dd",
            "yyyy-M-d",
            "yy-MM-dd",
            "yy-MM-d",
            "yy-M-dd",
            "yy-M-d",
        };

        public static string Long => "yyyy-MM-dd";

        public static string Short => Long;

        public static string DayFirst => "dd-MM-yyyy";

        public static string MonthFirst => "yyyy-MM-dd";

        public static ReadOnlyCollection<string> AllDayFirst
            => new ReadOnlyCollection<string>(allDayFirst);

        public static ReadOnlyCollection<string> AllMonthFirst
            => new ReadOnlyCollection<string>(allMonthFirst);

        public static ReadOnlyCollection<string> All {
            get {
                var r = new List<string>();
                r.AddRange(allMonthFirst);
                r.AddRange(allDayFirst);

                return new ReadOnlyCollection<string>(r);
            }
        }

        public static bool IsDate(string pattern) => All.Contains(pattern);

    }

}
