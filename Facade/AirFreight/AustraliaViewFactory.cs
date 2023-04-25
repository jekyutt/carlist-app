using SemestriProject.Aids.Methods;
using SemestriProject.Domain.AirFreight;

namespace SemestriProject.Facade.AirFreight
{
    public static class AustraliaViewFactory
    {
        public static Australia Create(AustraliaView v)
        {
            var o = new Australia();
            Copy.Members(v, o.Data);

            return o;
        }
        public static AustraliaView Create(Australia o)
        {
            var v = new AustraliaView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
