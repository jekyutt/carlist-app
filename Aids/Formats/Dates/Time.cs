
using System.Collections.ObjectModel;

namespace SemestriProject.Aids.Formats.Dates {

    public static class Time {

        private static string[] allFormats { get; } = {
            "H.m.s",
            "H:m:s",
            "HH.mm.ss",
            "HH:mm:ss",
            "HH.mm.s",
            "HH:mm:s",
            "HH.m.ss",
            "HH:m:ss",
            "H.mm.ss",
            "H:mm:ss",
            "HH.m.s",
            "HH:m:s",
            "H.m.ss",
            "H:m:ss",
            "H.mm.s",
            "H:mm:s",
            "H.mm",
            "H:mm",
            "HH.m",
            "HH:m",
            "HH.mm",
            "HH:mm",
            "H.m",
            "H:m",
            "H:m.s",
            "HH:mm.ss",
            "HH:mm.s",
            "HH:m.ss",
            "H:mm.ss",
            "HH:m.s",
            "H:m.ss",
            "H:mm.s"
        };

        public static string Long => "HH:mm:ss";

        public static string Short => "HH:mm";

        public static string Separators => ". Tt";

        public static ReadOnlyCollection<string> All 
            => new ReadOnlyCollection<string>(allFormats);

        public static bool IsTime(string pattern) => All.Contains(pattern); 

    }

}
