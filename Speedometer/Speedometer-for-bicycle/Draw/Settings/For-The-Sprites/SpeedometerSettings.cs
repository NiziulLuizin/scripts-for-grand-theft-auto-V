using GTA;
using System.Drawing;
using Speedometer.Text_Manager;

namespace Speedometer.Draw.Settings.For_The_Sprites
{
    internal class SpeedometerSettings
    {
        internal static PointF Position
        {         
            get { return new PointF(517f + TextManager.ptfX, 637f + TextManager.ptfY); }
        }
        internal static SizeF Size
        {
            get { return new SizeF(255f + TextManager.szX, 72f + TextManager.szY); }
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
