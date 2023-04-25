namespace SemestriProject.Aids.Constants {
    public static class Character {
        public static char Comma => ',';
        public static char Dot => '.';
        public static char Space => ' ';
        public static char Eol => '\n';
        public static char Tab => '\t';
        public static char Zero => '0';
        public static object Underscore => '_';
        public static bool IsDot(char c) => c.Equals(Dot);
        public static bool IsComma(char c) => c.Equals(Comma);
        public static bool IsLetter(char c) => char.IsLetter(c); 
        public static bool IsNumber(char c) => char.IsNumber(c); 
        public static bool IsSpace(char c) => c.Equals(Space);
    }
}

