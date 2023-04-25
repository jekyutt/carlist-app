using SemestriProject.Aids.Methods;
using SemestriProject.Domain.AirFreight;

namespace SemestriProject.Facade.AirFreight
{
    public static class AmericaViewFactory
    {
        public static America Create(AmericaView v)
        {
            var o = new America();
            Copy.Members(v, o.Data);

            return o;
        }
        public static AmericaView Create(America o)
        {
            var v = new AmericaView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
