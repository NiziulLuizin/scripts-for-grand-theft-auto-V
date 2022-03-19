using GTA.UI;
using Speedometer.Draw.Settings.For_The_Sprites;

namespace Speedometer.Draw.Sprites.CurrentSpeedometer
{
    internal class CurrentSpeedometer
    {
        internal static void Draw()
        {
            new Sprite(SpeedometerSettings.Directory,
                       SpeedometerSettings.Name,
                       SpeedometerSettings.Size,
                       SpeedometerSettings.Position).Draw();
        }
    }
}
