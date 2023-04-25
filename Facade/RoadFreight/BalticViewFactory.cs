using SemestriProject.Aids.Methods;
using SemestriProject.Domain.RoadFreight;

namespace SemestriProject.Facade.RoadFreight
{
    public static class BalticViewFactory
    {
        public static Baltic Create(BalticView v)
        {
            var o = new Baltic();
            Copy.Members(v, o.Data);

            return o;
        }
        public static BalticView Create(Baltic o)
        {
            var v = new BalticView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
