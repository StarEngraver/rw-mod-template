using Verse;

namespace RWModTemplate
{
    [StaticConstructorOnStartup]
    public static class CheckLog_ModStartup
    {
        static CheckLog_ModStartup()
        {
            Log.Message(System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " - " + "Mod Template: Load Successfully.");
        }
    }
}
