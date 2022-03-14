using GTA.UI;
using GTA;
using Speedometer_for_bicycle.Text_Element.Speed.In;

namespace Speedometer_for_bicycle.Text_Element.Speed
{
    internal static class Speed
    {
        internal static TextElement Show()
        {
            return new TextElement(Volicity, new System.Drawing.PointF(644f, 662f), 0.50f, System.Drawing.Color.White, Font.Monospace, Alignment.Center);
        }

        private static string Volicity
        {
            get
            {
                return (Game.MeasurementSystem == MeasurementSystem.Metric) ? Speed_In.KilometersPerHour().ToString("0") : Speed_In.MilesPerHour().ToString("0");
            }
        }
    }
}
