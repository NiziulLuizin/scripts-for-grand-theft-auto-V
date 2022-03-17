using System.Drawing;
using GTA;

namespace Speedometer_for_bicycle.Draw.Settings.For_The_Sprites
{
    internal class Speedometer
    {
        internal static PointF Position
        {
            get { return new PointF(685f, 640f); }
        }
        internal static SizeF Size
        {
            get { return new SizeF(320f, 65f); }
        }

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
    }
}
