using System.Collections.Generic;
using System.Linq;
using SemestriProject.Data.SeaFreight;

namespace SemestriProject.Infra.SeaFreight
{
    public static class SeaFreightDbInitializer
    {
        //africa
        internal static AfricaData angola = new AfricaData
        {
            Id = "EE->AN",
            Direction = "Estonia -> Angola",
            OrderTime = "MON, THU",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "20-30 workdays"
        };
        internal static AfricaData cameroon = new AfricaData
        {
            Id = "EE->CM",
            Direction = "Estonia -> Cameroon",
            OrderTime = "MON, THU",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "20-28 workdays"
        };
        internal static AfricaData kongo = new AfricaData
        {
            Id = "EE->KNG",
            Direction = "Estonia -> Kongo",
            OrderTime = "MON, THU",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "20-30 workdays"
        };
        //from africa
        internal static AfricaData angolaback = new AfricaData
        {
            Id = "AN->EE",
            Direction = "Angola -> Estonia",
            OrderTime = "MON, THU",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "20-30 workdays"
        };
        internal static AfricaData cameroonback = new AfricaData
        {
            Id = "CM->EE",
            Direction = "Cameroon -> Estonia",
            OrderTime = "MON, THU",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "20-28 workdays"
        };
        internal static AfricaData kongoback = new AfricaData
        {
            Id = "KNG->EE",
            Direction = "Kongo -> Estonia",
            OrderTime = "MON, THU",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "20-30 workdays"
        };
        //europe
        internal static EuropeData holland = new EuropeData
        {
            Id = "EE->HL",
            Direction = "Estonia -> Amsterdam",
            OrderTime = "TUE 12:00, THU 12:00",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "10-15 workdays"
        };
        internal static EuropeData france = new EuropeData
        {
            Id = "EE->FR",
            Direction = "Estonia -> Marsel",
            OrderTime = "TUE 12:00, THU 12:00",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "12-16 workdays"
        };
        internal static EuropeData germany = new EuropeData
        {
            Id = "EE->DE",
            Direction = "Estonia -> Hamburg",
            OrderTime = "TUE 12:00, THU 12:00",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "10-15 workdays"
        };
        //from europe
        internal static EuropeData hollandback = new EuropeData
        {
            Id = "HL->EE",
            Direction = "Amsterdam -> Estonia",
            OrderTime = "MON 12:00, THU 12:00",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "10-15 workdays"
        };
        internal static EuropeData franceback = new EuropeData
        {
            Id = "FR->EE",
            Direction = "Marsel -> Estonia",
            OrderTime = "TUE 12:00, THU 12:00",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "12-16 workdays"
        };
        internal static EuropeData germanyback = new EuropeData
        {
            Id = "DE->EE",
            Direction = "Hamburg -> Estonia",
            OrderTime = "THU 12:00",
            LiftingCapacity = "25 000 kg, 33.2 m2; 26 000kg, 67.8 m2",
            ContainerType = "20ft Container, 40ft Container",
            TravelTime = "10-15 workdays"
        };
        internal static List<AfricaData> africa => new List<AfricaData>
        {
            angola, kongo, cameroon,
            angolaback, kongoback, cameroonback
        };
        internal static List<EuropeData> europe => new List<EuropeData>
        {
            holland, france, germany,
            hollandback, franceback, germanyback
        };

        public static void Initialize(SeaFreightDbContext db)
        {
            initializeAfrica(db);
            initializeEurope(db);
        }

        private static void initializeAfrica(SeaFreightDbContext db)
        {
            if (db.Africa.Count() != 0) return;
            db.Africa.AddRange(africa);
            db.SaveChanges();
        }
        private static void initializeEurope(SeaFreightDbContext db)
        {
            if (db.Europe.Count() != 0) return;
            db.Europe.AddRange(europe);
            db.SaveChanges();
        }
    }
}
