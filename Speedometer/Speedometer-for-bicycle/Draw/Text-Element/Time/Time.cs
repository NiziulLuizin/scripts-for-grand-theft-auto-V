using Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements;
using GTA.UI;

namespace Speedometer_for_bicycle.Draw.Text_Element.Time
{
    internal static class Time
    {
        internal static void Draw()
        {
            new TextElement(Time_Text_Element.Time, 
                            Time_Text_Element.Position, 
                            Time_Text_Element.Scale, 
                            Time_Text_Element.Color, 
                            Time_Text_Element.Font, 
                            Time_Text_Element.Alignment).Draw();
        }      
    }
}
