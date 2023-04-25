using SemestriProject.Aids.Methods;
using SemestriProject.Domain.AirFreight;

namespace SemestriProject.Facade.AirFreight
{
    public static class ChinaViewFactory
    {
        public static China Create(ChinaView v)
        {
            var o = new China();
            Copy.Members(v, o.Data);

            return o;
        }
        public static ChinaView Create(China o)
        {
            var v = new ChinaView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
