using GTA.UI;
using Speedometer_for_bicycle.Draw.Settings.For_The_Sprites;

namespace Speedometer_for_bicycle.Draw.Sprites
{
    internal static class Sprite_Manager
    {
        internal static Sprite ReturnTheCurrentSpeedometer => new Sprite(
                Speedometer.Directory, Speedometer.Name, Speedometer.Size, Speedometer.Position);
    }
}

