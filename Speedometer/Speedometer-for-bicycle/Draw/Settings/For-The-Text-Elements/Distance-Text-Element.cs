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
            get { return new PointF(565f, 675f); }
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
                return $"{(WaypointExist() ? World.WaypointBlip.IsOnMinimap ? CurrentDistance() : 0 : 0):N1}m";
            }
        }

        private static float CurrentDistance()
        {
            return Game.MeasurementSystem == MeasurementSystem.Metric ? DistanceInMiles() : DistanceInMeters();
        }

        private static float DistanceInMiles()
        {
            return World.GetDistance(Game.Player.Character.Position, World.WaypointPosition) / 1609f;
        }

        private static float DistanceInMeters()
        {
            return World.GetDistance(Game.Player.Character.Position, World.WaypointPosition);
        }
        static bool WaypointExist()
        {
            return World.WaypointBlip != null;
        }
    }
}
