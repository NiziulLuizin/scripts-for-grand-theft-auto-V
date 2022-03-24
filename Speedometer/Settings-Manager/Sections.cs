using GTA.UI;

namespace Speedometer.Settings_Manager
{
    internal class Sections
    {
        internal static float AspectRatio
        { get { return Screen.AspectRatio; } }

        internal static string ReturnsTheCurrentScreenSettings()
        {
            return $"AspectRation: @{AspectRatio}";
        }
    }
}
