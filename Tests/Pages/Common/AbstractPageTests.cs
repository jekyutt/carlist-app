using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Tests.Pages.Common
{
    public abstract class AbstractPageTests<TClass, TBaseClass> : AbstractClassTests<TClass, TBaseClass>
        where TClass : BasePage<IAmericaRepository, America, AmericaView, AmericaData>
    {

        internal testRepository db;
        internal class testClass : BasePage<IAmericaRepository, America, AmericaView, AmericaData>
        {

            protected internal testClass(IAmericaRepository r) : base(r)
            {
                PageTitle = "America";
            }

            public override string ItemId => Item?.Id ?? string.Empty;

            public override string getPageUrl() => "/AirFreight/America";

            public override America toObject(AmericaView view) => AmericaViewFactory.Create(view);

            public override AmericaView toView(America obj) => AmericaViewFactory.Create(obj);

        }

        internal class testRepository : BaseTestRepositoryForUniqueEntity<America, AmericaData>, IAmericaRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            db = new testRepository();
        }

    }

}


