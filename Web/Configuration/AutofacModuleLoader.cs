using Autofac;

namespace Web.Configuration;

public static class AutofacModuleLoader
{
    public static void LoadModules(ContainerBuilder builder)
    {
        // Register individual modules
        // builder.RegisterModule<ServiceModule>();
        // builder.RegisterModule<RepositoryModule>();
        // Add more modules as needed
    }
}