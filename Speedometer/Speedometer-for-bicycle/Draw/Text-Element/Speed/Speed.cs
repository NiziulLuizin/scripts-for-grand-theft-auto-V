using Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements;
using Speedometer_for_bicycle.Draw.Text_Element.Speed.In;
using GTA.UI;
using GTA;

namespace Speedometer_for_bicycle.Draw.Text_Element.Speed
{
    internal static class Speed
    {
        internal static TextElement Show()
        {
            return new TextElement(CorrectSpeed, Speed_Text_Element.Position, 0.50f, System.Drawing.Color.White, Font.Monospace, Alignment.Center);
        }

        private static string CorrectSpeed
        {
            get
            {
                return (Game.MeasurementSystem == MeasurementSystem.Metric) ? SpeedIn.KilometersPerHour().ToString("0") : SpeedIn.MilesPerHour().ToString("0");
            }
        }
    }
}
