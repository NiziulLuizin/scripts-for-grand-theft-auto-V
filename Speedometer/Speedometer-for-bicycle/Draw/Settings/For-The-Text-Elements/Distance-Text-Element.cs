using System.Drawing;
using GTA;

namespace Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements
{
    internal class Distance_Text_Element 
    {
        internal static float Scale
        {
            get { return 0.50f; }
        }
        internal static Color Color
        {
            get { return Color.White; }
        }
        internal static PointF Position
        {
            get { return new PointF(563f, 676f); }
        }
        internal static GTA.UI.Alignment Alignment
        {
            get { return GTA.UI.Alignment.Center; }
        }
        internal static GTA.UI.Font Font
        {
            get { return GTA.UI.Font.ChaletComprimeCologne; }
        }

        internal static string Distance
        {
            get
            {
                return (WaypointExist() ? !World.WaypointBlip.IsOnMinimap ? 0 : World.GetDistance(Game.Player.Character.Position, World.WaypointPosition) : 0).ToString("N2") + "m";
            }
        }

        static bool WaypointExist()
        {
            return World.WaypointBlip != null ? true : false;
        }
    }
}
