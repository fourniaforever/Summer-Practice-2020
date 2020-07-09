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
using Ninject;

namespace SummerPracticeProject.Ioc
{
    public class DependencyResolver
    {
        private static NinjectBindings _bindings = new NinjectBindings();
        public static StandardKernel Kernel = new StandardKernel(_bindings);
    }
}
