using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.BLL;
using SummerPracticeProject.DAL;
using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.Entities;
using SummerPracticeProject.BLL.Interfaces;
using Ninject.Modules;

namespace SummerPracticeProject.Ioc
{
    public class NinjectBindings :NinjectModule
    {
        public override void Load()
        {
            Bind<IUsersDao>().To<UsersDAO>();
            Bind<IShopsDao>().To<ShopsDAO>();
            Bind<IRatesDao>().To<RatesDAO>();

            Bind<IUsersLogic>().To<UsersLogic>();
            Bind<IShopsLogic>().To<ShopsLogic>();
            Bind<IRatesLogic>().To<RatesLogic>();
        }
    }
}
