using GTA;
using System.Drawing;

namespace Speedometer_for_bicycle.Draw.Settings.For_The_Sprites
{
    internal static class Speedometer
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
            get { return new PointF(685f, 640f); }
        }

        internal static SizeF Size
        {
            get { return new SizeF(320f, 65f); }
        }
    }
}
