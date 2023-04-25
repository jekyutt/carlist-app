namespace SemestriProject.Aids.Formats {

    public static class Format {

        //internal enum how {

        //    None,
        //    First,
        //    Second,
        //    Both,

        //}

        //internal static string list => Word.List;

        //internal static string unspecified => Word.Unspecified.ToLower();

        //internal static string none => Word.None.ToLower();

        //internal static string nullValue => Word.Null.ToLower();

        //internal static string commaFormat => "{0}, {1}";

        //internal static string etcFormat => "{0} ...";

        //internal static string elementFormat => "{0}<{1}>[{2}] = {{{3}}}";

        //internal static string tripleFormat => "{0}{1}{2}";

        //internal static string dupleFormat => "{0}{1} {2}";

        //internal static string listFormat => "[{0}]";

        //public static string CommaBetween(string first, string second) {
        //    var x = getSwitch(first, second);

        //    return x switch {
        //        how.None => string.Empty,
        //        how.First => first,
        //        how.Second => second,
        //        how.Both => string.Format(commaFormat, first, second),
        //        _ => throw new ArgumentOutOfRangeException()
        //    };
        //}

        //internal static how getSwitch(string s1, string s2) {
        //    var x = hasValue(s1);
        //    var y = hasValue(s2);

        //    if (x && y) return how.Both;
        //    if (x) return how.First;
        //    if (y) return how.Second;

        //    return how.None;
        //}

        //internal static bool hasValue(string s) => !string.IsNullOrWhiteSpace(s);

        //public static string More(string s) 
        //    => string.IsNullOrWhiteSpace(s) ? "..." : string.Format(etcFormat, s);
 
        //public static string Element(string elementType, int idx, string value, string type = null) {
        //    if (string.IsNullOrEmpty(type)) type = list;
        //    if (string.IsNullOrEmpty(value)) value = nullValue;
        //    if (string.IsNullOrEmpty(elementType)) elementType = unspecified;
        //    if (string.IsNullOrEmpty(value)) value = string.Empty;

        //    return string.Format(elementFormat, type, elementType, idx, value);
        //}

        //public static string List(IEnumerable l, int lenght = 50) {
        //    var s = string.Empty;

        //    if (l is null) return string.Format(listFormat, none);

        //    foreach (var e in l) {
        //        var s1 = e.ToString();
        //        s = CommaBetween(s, s1);

        //        if (s.Length <= lenght) continue;
        //        s = s.Substring(0, lenght);
        //        s = More(s);

        //        break;
        //    }

        //    return hasValue(s)? string.Format(listFormat, s): string.Format(listFormat, none);
        //}

        //public static string Get(char separator = ',') => Character.IsDot(separator) ? tripleFormat : dupleFormat;

    }

}
