using Autofac;
using Reqnroll.Autofac;
using Reqnroll.Autofac.ReqnrollPlugin;

namespace MyRepro.Reqnroll.Autofac;

public class SetupTestDependencies
{
    [GlobalDependencies]
    public static void RegisterGlobalDependencies(ContainerBuilder containerBuilder)
    {
        containerBuilder.RegisterType<MyImpl>().As<IMyImpl>().SingleInstance();

        containerBuilder.AddReqnrollBindings<SetupTestDependencies>();
    }
    
    [ScenarioDependencies]
    public static void RegisterScenarioDependencies(ContainerBuilder containerBuilder)
    {
    }
}