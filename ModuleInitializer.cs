using System.Runtime.CompilerServices;

namespace verify_959;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifierSettings.DisableDateCounting();
    }
}
