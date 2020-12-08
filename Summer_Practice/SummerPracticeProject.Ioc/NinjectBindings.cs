using Ninject.Modules;
using SummerPracticeProject.BLL;
using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.DAL;
using SummerPracticeProject.Dao.Interfaces;

namespace SummerPracticeProject.Ioc
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IShopsLogic>().To<ShopsLogic>().InSingletonScope();
            Bind<IUsersLogic>().To<UsersLogic>().InSingletonScope();
            Bind<IRatesLogic>().To<RatesLogic>().InSingletonScope();

            Bind<IUsersDao>().To<UsersDAO>().InSingletonScope();
            Bind<IShopsDao>().To<ShopsDAO>().InSingletonScope();
            Bind<IRatesDao>().To<RatesDAO>().InSingletonScope();
        }
    }
}