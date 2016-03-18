using Autofac;

namespace Core
{
    public interface IDependencyRegister
    {
        void Register(ContainerBuilder builder);

        int Order();
    }
}
