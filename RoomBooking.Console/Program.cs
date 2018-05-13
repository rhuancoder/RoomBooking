using Unity;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<IAuthorRepository, AuthorRepository>(new HierarchicalLifetimeManager());

            var productRepository = container.Resolve<IProductRepository>();
        }
    }
}
