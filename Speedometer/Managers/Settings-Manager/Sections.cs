using GTA.UI;

namespace Speedometer.Managers.Settings_Manager
{
    internal sealed class Sections
    {
        internal static float AspectRatio
        { get { return Screen.AspectRatio; } }
        internal static string ReturnsTheCurrentScreenSettings()
        {
            return $"AspectRation: @{AspectRatio}";
        }
    }
}
