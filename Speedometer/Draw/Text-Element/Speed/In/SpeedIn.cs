namespace Speedometer.Draw.Text_Element.Speed.In
{
    internal static class SpeedIn
    {
        internal static string KilometersPerHour() => (GTA.Game.Player.Character.CurrentVehicle.Speed * 3.6f).ToString("0");
        internal static string MilesPerHour() => (GTA.Game.Player.Character.CurrentVehicle.Speed * 2.237f).ToString("0");
        internal static string KnotsPerHour() => (GTA.Game.Player.Character.CurrentVehicle.Speed * 1.944f).ToString("0");
    }
}
