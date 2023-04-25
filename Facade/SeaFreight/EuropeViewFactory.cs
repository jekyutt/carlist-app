using SemestriProject.Aids.Methods;
using SemestriProject.Domain.SeaFreight;

namespace SemestriProject.Facade.SeaFreight
{
    public static class EuropeViewFactory
    {
        public static Europe Create(EuropeView v)
        {
            var o = new Europe();
            Copy.Members(v, o.Data);

            return o;
        }
        public static EuropeView Create(Europe o)
        {
            var v = new EuropeView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
