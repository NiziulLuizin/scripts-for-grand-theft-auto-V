using System.Drawing;
using GTA;
using Speedometer.Text_Manager;

namespace Speedometer.Draw.Settings.For_The_Text_Elements
{
    internal class TimeTextElementSettings
    {      
        internal static float Scale
        {
            get { return 0.50f + TextManager.szY; }
        }
        internal static Color Color
        {
            get { return Color.White; }
        }
        internal static PointF Position
        {
            get { return new PointF(724f + TextManager.ptfX, 676f + TextManager.ptfY); }
        }
        internal static GTA.UI.Alignment Alignment
        {
            get { return GTA.UI.Alignment.Center; }
        }
        internal static GTA.UI.Font Font
        {
            get { return GTA.UI.Font.ChaletComprimeCologne; }
        }

        internal static string Time
        {
            get
            {
                return World.CurrentTimeOfDay.ToString();
            }
        }
    }
}
