using Azf.Services;
using Unity;

namespace Azf
{
    public class DIContainer
    {
        private static IUnityContainer _container;

        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                    _container = InitialiseUnityContainer();

                return _container;
            }
        }

        //public static Lazy<IUnityContainer> DIContainer =
        // new Lazy<IUnityContainer>(() =>
        // {
        //     IUnityContainer container = InitialiseUnityContainer();
        //     return container;
        // });

        public static IUnityContainer InitialiseUnityContainer()
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IUserService, UserService>();
            return container;
        }
    }
}
