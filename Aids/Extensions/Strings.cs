using System;
using System.Globalization;
using System.Linq;
using SemestriProject.Aids.Methods;

namespace SemestriProject.Aids.Extensions {

    public static class Strings {

        public static string Format(this string s, params object[] args)
            => Safe.Run(
                () => string.Format(CultureInfo.InvariantCulture, s, args),
                s ?? string.Empty);

        public static bool IsWord(this string s)
            => Safe.Run(
                () => !string.IsNullOrWhiteSpace(s) && char.IsLetter(s[0]),
                false);

        public static string Backwards(this string s)
            => Safe.Run(
                () => {
                    var x = s.Length - 1;
                    var r = string.Empty;
                    for (var i = x; i >= 0; i--) r += s[i];

                    return r;
                }, s ?? string.Empty);

        public static string SubstringBefore(this string s, string searchStr)
            => Safe.Run(
                () => s.Substring(0,
                    s.IndexOf(searchStr, StringComparison.InvariantCulture))
                , s ?? string.Empty);

        public static string ToLowerCase(this string s)
            => Safe.Run(
                () => s.ToLower(CultureInfo.InvariantCulture)
                , s ?? string.Empty);

        public static string RemoveSpaces(this string s)
            => Safe.Run(
                () =>
                    s.Where(char.IsLetterOrDigit)
                        .Aggregate(string.Empty, (current, c) => current + c),
                s ?? string.Empty);

        public static string GetHead(this string s, char seperator = '.')
            => Safe.Run(
                () => {

                    if (string.IsNullOrWhiteSpace(s)) return string.Empty;
                    var i = s.IndexOf(seperator);

                    return i < 0 ? s : s.Substring(0, i);
                }, string.Empty);

        public static string GetTail(this string s, char seperator = '.')
            => Safe.Run(
                () => {
                    if (string.IsNullOrWhiteSpace(s)) return string.Empty;
                    var i = s.IndexOf(seperator);

                    return i < 0 ? s : s.Substring(i + 1);
                }, string.Empty);

        public static string IfNullSetEmpty(string s) => s ?? string.Empty;

        public static string Trim(string s) {
            return IfNullSetEmpty(s).Trim();
        }

        public static bool Contains(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1)) return false;
            if (string.IsNullOrEmpty(s2)) return false;
            return s1.Contains(s2);
        }

        public static int GetLength(string x)
        {
            if (!string.IsNullOrEmpty(x)) return x.Length;
            return 0;
        }

        public static string ToLower(string s) => string.IsNullOrEmpty(s) ? string.Empty : s.ToLower();

        public static string ToUpper(string s) => string.IsNullOrEmpty(s) ? string.Empty : s.ToUpper();

        public static string Substring(string s, int startIndex)
        {
            if (!string.IsNullOrEmpty(s)) return s.Substring(startIndex);
            return string.Empty;
        }

        public static string Substring(string s, int startIndex, int length)
        {
            if (!string.IsNullOrEmpty(s)) return s.Substring(startIndex, length);
            return string.Empty;
        }

        public static bool EndsWith(string x, string y)
        {
            if (string.IsNullOrEmpty(x)) return false;
            if (string.IsNullOrEmpty(y)) return false;
            return x.EndsWith(y);
        }

        public static bool StartsWith(string x, string y)
        {
            if (string.IsNullOrEmpty(x)) return false;
            if (string.IsNullOrEmpty(y)) return false;
            return x.StartsWith(y);
        }

        internal static string addStringPattern => "{0}{1}";

        public static string Add(string s1, string s2)
        { 
            s1 ??= string.Empty;
            s2 ??= string.Empty;
            return string.Format(addStringPattern, s1, s2);
        }

    }

}


