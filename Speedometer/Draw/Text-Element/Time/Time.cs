using Speedometer.Draw.Settings.For_The_Text_Elements;
using GTA.UI;

namespace Speedometer.Draw.Text_Element.Time
{
    internal class Time
    {
        internal static void Draw()
        {
            new TextElement(TimeTextElementSettings.Time, 
                            TimeTextElementSettings.Position, 
                            TimeTextElementSettings.Scale, 
                            TimeTextElementSettings.Color, 
                            TimeTextElementSettings.Font, 
                            TimeTextElementSettings.Alignment).Draw();
        }      
    }
}
