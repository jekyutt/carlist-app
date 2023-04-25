
namespace SemestriProject.Aids.RegExp {
    public static class RegExpForEnglish {
        public static string Capitals => @"^[A-Z]+[A-Z]*$";
        public static string Text => @"^[A-Z]+[a-zA-Z""'\s-]*$";
        public static string CapitalsAndNumbers => @"^[A-Z]+[A-Z,0-9]*$";
    }
}

