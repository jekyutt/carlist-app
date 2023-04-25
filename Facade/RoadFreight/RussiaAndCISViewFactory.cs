using SemestriProject.Aids.Methods;
using SemestriProject.Domain.RoadFreight;

namespace SemestriProject.Facade.RoadFreight
{
    public static class RussiaAndCISViewFactory
    {
        public static RussiaAndCIS Create(RussiaAndCISView v)
        {
            var o = new RussiaAndCIS();
            Copy.Members(v, o.Data);

            return o;
        }
        public static RussiaAndCISView Create(RussiaAndCIS o)
        {
            var v = new RussiaAndCISView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
