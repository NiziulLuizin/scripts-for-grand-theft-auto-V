using GTA;
using System.Drawing;
using Speedometer.Draw.Text_Element.Speed.In;

namespace Speedometer.Draw.Settings.For_The_Text_Elements
{
    internal sealed class SpeedTextElementSettings
    {
        internal static float Scale
        {
            get { return 1.0f; }
        }
        internal static Color Color
        {
            get { return Color.White; }
        }
        internal static GTA.UI.Font Font
        {
            get { return GTA.UI.Font.Monospace; }
        }
        internal static PointF Position
        {
            get { return new PointF(840f, 625f); }
        }
        internal static GTA.UI.Alignment Alignment
        {
            get { return GTA.UI.Alignment.Center; }
        }

        internal static string CorrectSpeed
        {
            get
            {
                return (Game.MeasurementSystem == MeasurementSystem.Metric) ? SpeedIn.KilometersPerHour() : SpeedIn.MilesPerHour();
            }
        }
    }
}
