using Speedometer_for_bicycle.Renderings.Sprites.Informations.Image;

using GTA.UI;

namespace Speedometer_for_bicycle.Renderings.Sprites.Current_Unit_of_Measure
{
    internal static class Sprite_Manager
    {
        internal static Sprite ReturnTheCurrentSpeedometer => new Sprite(
                Sprite_Speedometer.Directory, Sprite_Speedometer.Name, Sprite_Speedometer.Size, Sprite_Speedometer.Position);
    }
}

