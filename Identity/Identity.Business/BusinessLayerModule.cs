namespace Identity.Business
{
    using Ninject.Modules;

    /// <summary>
    /// Ninject module for business layer bindings.
    /// </summary>
    public class BusinessLayerModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            // this.Kernel.Bind<>().ToSelf().InSingletonScope();
        }
    }
}
