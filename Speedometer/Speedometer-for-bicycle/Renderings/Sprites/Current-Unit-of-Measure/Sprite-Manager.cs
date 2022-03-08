using Speedometer_for_bicycle.Renderings.Sprites.Informations.Image;
using System.Drawing;
using GTA.UI;

namespace Speedometer_for_bicycle.Renderings.Sprites.Current_Unit_of_Measure
{
    public class Sprite_Manager
    {
        public Sprite ReturnTheCurrentSpeedometer()
        {
            return new Sprite(
                Sprite_Speedometer.Directory, Sprite_Speedometer.Name, new SizeF(388f, 128f), new PointF(650f, 550f));
        }
    }
}

