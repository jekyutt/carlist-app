using SemestriProject.Aids.Methods;
using SemestriProject.Domain.RoadFreight;

namespace SemestriProject.Facade.RoadFreight
{
    public static class ScandinaviaViewFactory
    {
        public static Scandinavia Create(ScandinaviaView v)
        {
            var o = new Scandinavia();
            Copy.Members(v, o.Data);

            return o;
        }
        public static ScandinaviaView Create(Scandinavia o)
        {
            var v = new ScandinaviaView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
