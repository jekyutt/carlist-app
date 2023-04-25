namespace SemestriProject.Aids.Constants {

    public static class Astronomical {

        public static double HoursPerDay => 24.0;

        public static double MinutesPerHour => 60.0;
        public static double SecondsPerMinute => 60.0;

        public static double SecondsPerHour => MinutesPerHour * SecondsPerMinute;

        public static double SecondsPerDay => HoursPerDay * SecondsPerHour;

        public static double DaysPerWeek => 7.0;

        public static double SecondsPerWeek => DaysPerWeek * SecondsPerDay;

        public static double WeeksPerFortnight => 2.0;

        public static double DaysPerMonth => 30.4375;

        public static double SecondsPerMonth => DaysPerMonth * SecondsPerDay;

        public static double DaysPerYear => 365.25;

        public static double SecondsPerYear => DaysPerYear * SecondsPerDay;

        public static double YearsPerDecade => 10.0;

        public static double YearsPerCentury => 10.0 * YearsPerDecade;

        public static double YearsPerMillennium => 10.0 * YearsPerCentury;

        public static double SecondsPerFortnight => WeeksPerFortnight * SecondsPerWeek;

        public static double SecondsPerDecade => YearsPerDecade * SecondsPerYear;

        public static double SecondsPerCentury => YearsPerCentury * SecondsPerYear;

        public static double SecondsPerMillennium => YearsPerMillennium * SecondsPerYear;

    }

}
