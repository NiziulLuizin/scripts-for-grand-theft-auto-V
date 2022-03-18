using Speedometer_for_bicycle.Draw.Settings.For_The_Sprites;
using Speedometer_for_bicycle.Draw.Text_Element.Distance;
using Speedometer_for_bicycle.Draw.Text_Element.Speed;
using Speedometer_for_bicycle.Draw.Text_Element.Time;
using GTA.UI;

namespace Speedometer_for_bicycle.Draw.Sprites
{
    internal static class SpriteManager
    {
        internal static void DisplayTheCurrentSpeedometer()
        {
            new Sprite(Speedometer.Directory,
                       Speedometer.Name,
                       Speedometer.Size,
                       Speedometer.Position).ScaledDraw();

            Distance.Draw();
            Speed.Draw();
            Time.Draw();
        }
    }
}

