using GTA;
using GTA.UI;
using Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements;
using System;

namespace Speedometer_for_bicycle.Draw.Text_Element.Time
{
    internal static class FullTime
    {
        internal static TextElement Show()
        {
            return new TextElement(Convert.ToString(Time()), Time_Text_Element.Position, 0.50f, System.Drawing.Color.White, Font.ChaletComprimeCologne, Alignment.Center);
        }
        private static TimeSpan Time()
        {
            return World.CurrentTimeOfDay;
        }
    }
}
