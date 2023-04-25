using SemestriProject.Data.AirFreight;
using System.Collections.Generic;
using System.Linq;

namespace SemestriProject.Infra.AirFreight
{
    public static class AirFreightDbInitializer
    {
        //America
        internal static AmericaData newYork = new AmericaData
        {
            Id = "EE->USA.",
            Direction = "Estonia -> New York",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData lasVegas = new AmericaData
        {
            Id = "EE->USA.LV",
            Direction = "Estonia -> Las Vegas",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData losangeles= new AmericaData
        {
            Id = "EE->USA.LA",
            Direction = "Estonia -> Los Angeles",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData chicago = new AmericaData
        {
            Id = "EE->USA.CHI",
            Direction = "Estonia -> Chicago",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData boston = new AmericaData
        {
            Id = "EE->USA.BSTN",
            Direction = "Estonia -> Boston",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo, Temperature Controlled",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData sanfrancisko = new AmericaData
        {
            Id = "EE->USA.SF",
            Direction = "Estonia -> San Francisco",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData seattle = new AmericaData
        {
            Id = "EE->USA.STTLE",
            Direction = "Estonia -> Seattle",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData kansas = new AmericaData
        {
            Id = "EE->USA.KNS",
            Direction = "Estonia -> Kansas",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData denver = new AmericaData
        {
            Id = "EE->USA.DNVR",
            Direction = "Estonia -> Denver",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData dallas = new AmericaData
        {
            Id = "EE->USA.DLLS",
            Direction = "Estonia -> Dallas",
            OrderTime = "MON 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };

        //from America
        internal static AmericaData newYorkback = new AmericaData
        {
            Id = "USA.NY->EE",
            Direction = "New York -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData lasVegasback = new AmericaData
        {
            Id = "USA.LV->EE",
            Direction = "Las Vegas -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData losangelesback = new AmericaData
        {
            Id = "USA.LA -> EE",
            Direction = "Los Angeles -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData chicagoback = new AmericaData
        {
            Id = "USA.CHI -> EE",
            Direction = "Chicago -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:000",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData bostonback = new AmericaData
        {
            Id = "USA.BSTN->EE",
            Direction = "Boston -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo, Temperature Controlled",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData sanfranciskoback = new AmericaData
        {
            Id = "USA.SF->EE",
            Direction = "San Francisco -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData seattleback = new AmericaData
        {
            Id = "USA.STTLE->EE",
            Direction = "Seattle -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        internal static AmericaData kansasback = new AmericaData
        {
            Id = "USA.KNS->EE",
            Direction = "Kansas -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData denverback = new AmericaData
        {
            Id = "USA.DNVR->EE",
            Direction = "Denver -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Airbus Beluga",
            TravelTime = "10-12 workdays"
        };
        internal static AmericaData dallasback = new AmericaData
        {
            Id = "USA.DLLS->EE",
            Direction = "Dallas -> Estonia",
            OrderTime = "WED 12:00 / FRI 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "8-11 workdays"
        };
        //Australia
        internal static AustraliaData sydney = new AustraliaData
        {
            Id = "EE->AUS.SDN",
            Direction = "Estonia -> Sydney",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData darwin = new AustraliaData
        {
            Id = "EE->AUS.DRWN",
            Direction = "Estonia -> Darwin",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData queensland = new AustraliaData
        {
            Id = "EE->AUS.QNISLND",
            Direction = "Estonia -> QueenIsland",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData tasmania = new AustraliaData
        {
            Id = "EE->AUS.TSMN",
            Direction = "Estonia -> Tasmania",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData victoria = new AustraliaData
        {
            Id = "EE->AUS.VCTR",
            Direction = "Estonia -> Victoria",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        //from Australia
        internal static AustraliaData sydneyback = new AustraliaData
        {
            Id = "AUS.SDN->EE",
            Direction = "Sydney -> Estonia",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData darwinback = new AustraliaData
        {
            Id = "AUS.DRWN->EE",
            Direction = "Darwin -> Estonia",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData queenslandback = new AustraliaData
        {
            Id = "AUS.QNISLND->EE",
            Direction = "QueenIsland -> Estonia",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData tasmaniaback = new AustraliaData
        {
            Id = "AUS.TSMN->EE",
            Direction = "Tasmania -> Estonia",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        internal static AustraliaData victoriaback = new AustraliaData
        {
            Id = "AUS.VCTR->EE",
            Direction = "Victoria -> Estonia",
            OrderTime = "MON 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "5-8 workdays"
        };
        //China
        internal static ChinaData shanghai = new ChinaData
        {
            Id = "EE->CHN.SHNGH",
            Direction = "Estonia -> Shanghai",
            OrderTime = "MON 12:00, TUE 12:00, THU 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "12-15 workdays"
        };
        internal static ChinaData beijing = new ChinaData
        {
            Id = "EE->CHN.BJNG",
            Direction = "Estonia -> Beijing",
            OrderTime = "MON 12:00, TUE 12:00, THU 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "12-15 workdays"
        };
        //fromChina
        internal static ChinaData shanghaiback = new ChinaData
        {
            Id = "CHN.SHNGH->EE",
            Direction = "Shanghai -> Estonia",
            OrderTime = "MON 12:00, TUE 12:00, THU 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "12-15 workdays"
        };
        internal static ChinaData beijingback = new ChinaData
        {
            Id = "CHN.BJNG->EE",
            Direction = "Beijing -> Estonia",
            OrderTime = "MON 12:00, TUE 12:00, THU 12:00",
            TypeOfCargo = "General Air Cargo",
            AirplaneType = "Boeing 747-400ERF",
            TravelTime = "12-15 workdays"
        };
        internal static List<AmericaData> america => new List<AmericaData>
        {
            newYork, lasVegas, losangeles, chicago, boston, sanfrancisko, seattle, kansas, denver, dallas,
            newYorkback, lasVegasback, losangelesback, chicagoback, bostonback, sanfranciskoback, seattleback, kansasback, denverback, dallasback
        };
        internal static List<AustraliaData> australia => new List<AustraliaData>
        {
            sydney, darwin, queensland, tasmania, victoria,
            sydneyback, darwinback, queenslandback, tasmaniaback, victoriaback
        };
        internal static List<ChinaData> china => new List<ChinaData>
        {
            shanghai, beijing, shanghaiback, beijingback
        };

        public static void Initialize(AirFreightDbContext db)
        {
            initializeAmerica(db);
            initializeAustralia(db);
            initializeChina(db);
        }

        private static void initializeAmerica(AirFreightDbContext db)
        {
            if (db.America.Count() != 0) return;
            db.America.AddRange(america);
            db.SaveChanges();
        }
        private static void initializeAustralia(AirFreightDbContext db)
        {
            if (db.Australia.Count() != 0) return;
            db.Australia.AddRange(australia);
            db.SaveChanges();
        }
        private static void initializeChina(AirFreightDbContext db)
        {
            if (db.China.Count() != 0) return;
            db.China.AddRange(china);
            db.SaveChanges();
        }
    }
}
