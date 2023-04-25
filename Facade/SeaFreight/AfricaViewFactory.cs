using SemestriProject.Aids.Methods;
using SemestriProject.Domain.SeaFreight;

namespace SemestriProject.Facade.SeaFreight
{
    public static class AfricaViewFactory
    {
        public static Africa Create(AfricaView v)
        {
            var o = new Africa();
            Copy.Members(v, o.Data);

            return o;
        }
        public static AfricaView Create(Africa o)
        {
            var v = new AfricaView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
