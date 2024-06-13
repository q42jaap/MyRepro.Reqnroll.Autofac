using Reqnroll;

namespace MyRepro.Reqnroll.Autofac.Hooks;

[Binding]
public class SetupHook
{
    [BeforeTestRun]
    public static void BeforeTestRun(IMyImpl myImpl)
    {
    }
}