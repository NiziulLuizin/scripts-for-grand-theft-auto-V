namespace Speedometer_for_bicycle.Text_Element.Speed.In
{
    internal static class Speed_In
    {
        internal static float KilometersPerHour() => GTA.Game.Player.Character.CurrentVehicle.Speed * 3.6f;
        internal static float MilesPerHour() => GTA.Game.Player.Character.CurrentVehicle.Speed * 2.237f;
        internal static float KnotsPerHour() => GTA.Game.Player.Character.CurrentVehicle.Speed * 1.944f;
    }
}
