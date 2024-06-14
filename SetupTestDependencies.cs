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
    }
    
    [ScenarioDependencies]
    public static void RegisterScenarioDependencies(ContainerBuilder containerBuilder)
    {
        containerBuilder.AddReqnrollBindings<SetupTestDependencies>();
    }
}