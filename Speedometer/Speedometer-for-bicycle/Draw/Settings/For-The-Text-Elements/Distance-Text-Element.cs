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
                return IsTheWaypointBeingUsed() ? CurrentDistance() : DistanceBase();
            }
        }


        private static bool IsTheWaypointBeingUsed()
        {
            return WaypointExist();
        }
        private static string DistanceBase()
        {
            var metersBase = $"{0:N2}m";
            var milesBase = $"{0:N3}mi";
            return Game.MeasurementSystem
                == MeasurementSystem.Metric ? metersBase : milesBase;
        }
        private static bool WaypointExist()
        {
            return World.WaypointBlip != null && World.WaypointBlip.IsOnMinimap;
        }
        private static string CurrentDistance()
        {
            return Game.MeasurementSystem == MeasurementSystem.Metric ? DistanceInMeters() : DistanceInMiles();
        }
        private static string DistanceInMeters()
        {
            return $"{World.GetDistance(origin: Game.Player.Character.Position, destination: World.WaypointPosition):N2}m";
        }
        private static string DistanceInMiles()
        {
            return $"{World.GetDistance(origin: Game.Player.Character.Position, destination: World.WaypointPosition) / 1609f:N3}mi";
        }
    }
}
