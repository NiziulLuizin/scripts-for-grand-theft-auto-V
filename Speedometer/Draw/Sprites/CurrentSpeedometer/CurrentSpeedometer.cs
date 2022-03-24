using GTA.UI;
using Speedometer.Draw.Settings.For_The_Sprites;

namespace Speedometer.Draw.Sprites.CurrentSpeedometer
{
    internal class CurrentSpeedometer 
    {
        internal static void Draw()
        {
            new Sprite(SpeedometerBase.Directory,
                       SpeedometerBase.Name,
                       SpeedometerBase.Size,
                       SpeedometerBase.Position).ScaledDraw(SpeedometerBase.Offset);
        }
    }
}
