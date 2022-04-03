using Speedometer.Draw.Settings.For_The_Text_Elements;
using GTA.UI;

namespace Speedometer.Draw.Text_Element.Speed
{
    internal static class Speed
    {
        public static void CurrentSpeed(System.Drawing.SizeF offset)
        {
             new TextElement(SpeedTextElementSettings.CorrectSpeed,
                                   SpeedTextElementSettings.Position,
                                   SpeedTextElementSettings.Scale,
                                   SpeedTextElementSettings.Color,
                                   SpeedTextElementSettings.Font,
                                   SpeedTextElementSettings.Alignment).ScaledDraw(offset);
        }        
    }
}
