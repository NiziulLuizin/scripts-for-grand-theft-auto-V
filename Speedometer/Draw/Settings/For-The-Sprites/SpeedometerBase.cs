using GTA;
using Speedometer.Editor_Mode;
using Speedometer.Settings_Manager;
using System.Drawing;

namespace Speedometer.Draw.Settings.For_The_Sprites
{
    internal class SpeedometerBase
    {
        internal static PointF Position { get; set; }
        internal static SizeF Offset
        {
            get { return Size; }
        }
        internal static string Directory
        {
            get { return "Speedometer"; }
        }        
        internal static string Name
        {
            get { return "SpeedometerK-Type-1"; }
        }
        internal static SizeF Size
        {
            get { return new SizeF(180f / 1.5f, 96f / 1.5f); }
        }
    }
}
