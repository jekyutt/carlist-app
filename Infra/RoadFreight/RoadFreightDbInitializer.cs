using System;
using System.Collections.Generic;
using System.Linq;
using SemestriProject.Data.RoadFreight;

namespace SemestriProject.Infra.RoadFreight

{
    public static class RoadFreightDbInitializer
    {
        //latvia
        internal static BalticData lvRiga = new BalticData
        {
            Id = "EE->LV.RG",
            Direction = "Tallinn -> Riga",
            OrderTime = "MON 12:00, TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "TUE 12:00, THU 12:00",
            TravelTime = "1-2 workdays"
        };
        internal static BalticData lvDaugavpils = new BalticData
        {
            Id = "EE->LV.DGVPLS",
            Direction = "Tallinn -> Daugavpils",
            OrderTime = "MON 12:00, TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "TUE 12:00, THU 12:00",
            TravelTime = "1-2 workdays"
        };
        //from latvia
        internal static BalticData lvRigaback = new BalticData
        {
            Id = "LV.RG->EE",
            Direction = "Tallinn -> Riga",
            OrderTime = "MON 12:00, TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 15:00, WED 15:00",
            Departures = "TUE 12:00, THU 12:00",
            TravelTime = "1-2 workdays"
        };
        internal static BalticData lvDaugavpilsback = new BalticData
        {
            Id = "LV.DGVPLS->EE",
            Direction = "Tallinn -> Daugavpils",
            OrderTime = "MON 12:00, TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "TUE 12:00, THU 12:00",
            TravelTime = "1-2 workdays"
        };
        //litva
        internal static BalticData ltVilnius = new BalticData
        {
            Id = "EE->LT.VLNS",
            Direction = "Tallinn -> Vilnius",
            OrderTime = "TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "WED 12:00, FRI 12:00",
            TravelTime = "2-3 workdays"
        };
        internal static BalticData ltKaunas = new BalticData
        {
            Id = "EE->LT.KNS",
            Direction = "Tallinn -> Kaunas",
            OrderTime = "TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "WED 12:00, FRI 12:00",
            TravelTime = "2-3 workdays"
        };
        internal static BalticData ltKlaipeda = new BalticData
        {
            Id = "EE->LT.KLPD",
            Direction = "Tallinn -> Klaipeda",
            OrderTime = "TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "WED 12:00, FRI 12:00",
            TravelTime = "2-3 workdays"
        };
        //from litva
        internal static BalticData ltVilniusback = new BalticData
        {
            Id = "LT.VLNS->EE",
            Direction = "Vilnius -> Tallinn",
            OrderTime = "TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "WED 12:00, FRI 12:00",
            TravelTime = "2-3 workdays"
        };
        internal static BalticData ltKaunasback = new BalticData
        {
            Id = "LT.KNS->EE",
            Direction = "Kaunas -> Tallinn",
            OrderTime = "TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "WED 12:00, FRI 12:00",
            TravelTime = "2-3 workdays"
        };
        internal static BalticData ltKlaipedaback = new BalticData
        {
            Id = "LT.KLPD->EE",
            Direction = "Klaipeda -> Tallinn",
            OrderTime = "TUE 12:00, WED 12:00, THU 12:00",
            Loading = "MON 18:00, WED 18:00",
            Departures = "WED 12:00, FRI 12:00",
            TravelTime = "2-3 workdays"
        };
        //CIS
        internal static RussiaAndCISData moscow = new RussiaAndCISData
        {
            Id = "EE->RUS.MSCW",
            Direction = "Tallinn -> Moscow",
            OrderTime = "THU 12:00",
            Loading = "WED-FRI",
            Departures = "TUE 12:00",
            TravelTime = "3-4 workdays"
        };
        internal static RussiaAndCISData spb = new RussiaAndCISData
        {
            Id = "EE->RUS.SPB",
            Direction = "Tallinn -> Saint-Petersburg",
            OrderTime = "TUE 12:00",
            Loading = "MON-THU",
            Departures = "TUE 12:00 / FRI 12:00",
            TravelTime = "2-4 workdays"
        };
        internal static RussiaAndCISData belarus = new RussiaAndCISData
        {
            Id = "EE->BLR",
            Direction = "Tallinn -> Minsk",
            OrderTime = "TUE 12:00 / THU 12:00",
            Loading = "MON 18:00",
            Departures = "TUE 12:00",
            TravelTime = "3-5 workdays"
        };
        internal static RussiaAndCISData ukraina = new RussiaAndCISData
        {
            Id = "EE->UA",
            Direction = "Tallinn -> Kiev",
            OrderTime = "THU 12:00",
            Loading = "MON 18:00",
            Departures = "TUE 12:00",
            TravelTime = "2-6 workdays"
        };
        //from CIS
        internal static RussiaAndCISData moscowback = new RussiaAndCISData
        {
            Id = "RUS.MSCW->EE",
            Direction = "Moscow -> Tallinn",
            OrderTime = "THU 12:00",
            Loading = "WED-FRI",
            Departures = "TUE 12:00",
            TravelTime = "3-4 workdays"
        };
        internal static RussiaAndCISData spbback = new RussiaAndCISData
        {
            Id = "RUS.SPB->EE",
            Direction = "Saint-Petersburg -> Tallinn",
            OrderTime = "TUE 12:00",
            Loading = "MON-THU",
            Departures = "TUE 12:00 / FRI 12:00",
            TravelTime = "2-4 workdays"
        };
        internal static RussiaAndCISData belarusback = new RussiaAndCISData
        {
            Id = "BLR->EE",
            Direction = "Minsk -> Tallinn",
            OrderTime = "TUE 12:00 / THU 12:00",
            Loading = "MON 18:00",
            Departures = "TUE 12:00",
            TravelTime = "3-5 workdays"
        };
        internal static RussiaAndCISData ukrainaback = new RussiaAndCISData
        {
            Id = "UA->EE",
            Direction = "Kiev -> Tallinn",
            OrderTime = "THU 12:00",
            Loading = "MON 18:00",
            Departures = "TUE 12:00",
            TravelTime = "2-6 workdays"
        };
        //scandinavia
        internal static ScandinaviaData denmark = new ScandinaviaData
        {
            Id = "EE->DK",
            Direction = "Tallinn -> Copenhagen",
            OrderTime = "FRI 12:00",
            Loading = "MON 15:00",
            Departures = "WED 12:00",
            TravelTime = "3-6 workdays"
        };
        internal static ScandinaviaData norway = new ScandinaviaData
        {
            Id = "EE->NO",
            Direction = "Tallinn -> Oslo",
            OrderTime = "THU 12:00",
            Loading = "MON 15:00",
            Departures = "WED 12:00",
            TravelTime = "2-5 workdays"
        };
        internal static ScandinaviaData sweden = new ScandinaviaData
        {
            Id = "EE->SE",
            Direction = "Tallinn -> Stockholm",
            OrderTime = "MON 12:00",
            Loading = "TUE 15:00",
            Departures = "WED 12:00",
            TravelTime = "2-4 workdays"
        };
        //from scandinavia
        internal static ScandinaviaData denmarkback = new ScandinaviaData
        {
            Id = "DK->EE",
            Direction = "Copenhagen -> Tallinn",
            OrderTime = "FRI 12:00",
            Loading = "MON 15:00",
            Departures = "WED 12:00",
            TravelTime = "3-6 workdays"
        };
        internal static ScandinaviaData norwayback = new ScandinaviaData
        {
            Id = "NO->EE",
            Direction = "Oslo -> Tallinn",
            OrderTime = "THU 12:00",
            Loading = "MON 15:00",
            Departures = "WED 12:00",
            TravelTime = "2-5 workdays"
        };
        internal static ScandinaviaData swedenback = new ScandinaviaData
        {
            Id = "SE->EE",
            Direction = "Stockholm -> Tallinn",
            OrderTime = "MON 12:00",
            Loading = "TUE 15:00",
            Departures = "WED 12:00",
            TravelTime = "2-4 workdays"
        };
        internal static List<BalticData> baltic => new List<BalticData>
        {
            lvRiga, lvDaugavpils,
            lvRigaback, lvDaugavpilsback,
            ltKaunas, ltKlaipeda, ltVilnius,
            ltKaunasback, ltKlaipedaback, ltVilniusback
        };
        internal static List<RussiaAndCISData> russiaCIS => new List<RussiaAndCISData>
        {
            moscow, spb, belarus, ukraina,
            moscowback, spbback, belarusback, ukrainaback
        };
        internal static List<ScandinaviaData> scandinavia => new List<ScandinaviaData>
        {
            denmark, sweden, norway,
            denmarkback, swedenback, norwayback
        };

        public static void Initialize(RoadFreightDbContext db)
        {
            initializeBaltic(db);
            initializeRussiaAndCIS(db);
            initializeScandinavia(db);
        }

        private static void initializeBaltic(RoadFreightDbContext db)
        {
            if (db.Baltics.Count() != 0) return;
            db.Baltics.AddRange(baltic);
            db.SaveChanges();
        }
        private static void initializeRussiaAndCIS(RoadFreightDbContext db)
        {
            if (db.RussiaAndCIS.Count() != 0) return;
            db.RussiaAndCIS.AddRange(russiaCIS);
            db.SaveChanges();
        }
        private static void initializeScandinavia(RoadFreightDbContext db)
        {
            if (db.Scandinavia.Count() != 0) return;
            db.Scandinavia.AddRange(scandinavia);
            db.SaveChanges();
        }
    }
}
