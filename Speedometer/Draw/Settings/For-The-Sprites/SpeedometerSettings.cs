using GTA;
using System.Drawing;

namespace Speedometer.Draw.Settings.For_The_Sprites
{
    internal class SpeedometerSettings
    {
        internal static PointF Position
        {         
            get { return new PointF(517f, 637f); }
        }
        internal static SizeF Size
        {
            get { return new SizeF(255f, 72f); }
        }
        internal static string Directory
        {
            get { return "Speedometer"; }
        }        
        internal static string Name
        {
            get
            {
                return (Game.MeasurementSystem == MeasurementSystem.Metric) ? "SpeedometerK" : "SpeedometerM";
            }
        }
    }
}
