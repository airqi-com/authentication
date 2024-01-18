
namespace Identity.Data
{

    using Ninject.Modules;

    /// <summary>
    /// Ninject module for data layer bindings.
    /// </summary>
    public class DataLayerModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            this.Kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            this.Kernel.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
