using GTA;
using System.Drawing;

namespace Speedometer_for_bicycle.Renderings.Sprites.Informations.Image
{
    internal static class Sprite_Speedometer
    {
        internal static string Name
        {
            get
            {
                return (Game.MeasurementSystem == MeasurementSystem.Metric) ? "SpeedometerK" : "SpeedometerM";
            }
        }

        internal static string Directory
        {
            get
            {
                return "Speedometer";
            }
        }

        internal static PointF Position
        {
            get
            {
                return new PointF(720f, 640f);
            }
        }

        internal static SizeF Size
        {
            get
            {
                return new SizeF(251f, 63f);
            }
        }
    }
}
