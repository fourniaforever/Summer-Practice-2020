using Ninject;

namespace SummerPracticeProject.Ioc
{
    public class DependencyResolver
    {
        private static NinjectBindings _bindings = new NinjectBindings();
        public static StandardKernel Kernel = new StandardKernel(_bindings);
    }
}