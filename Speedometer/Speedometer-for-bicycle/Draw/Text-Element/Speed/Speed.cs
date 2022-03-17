using Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements;
using GTA.UI;

namespace Speedometer_for_bicycle.Draw.Text_Element.Speed
{
    internal static class Speed
    {
        internal static void Draw()
        {
            new TextElement(Speed_Text_Element.CorrectSpeed,
                            Speed_Text_Element.Position,
                            Speed_Text_Element.Scale,
                            Speed_Text_Element.Color,
                            Speed_Text_Element.Font,
                            Speed_Text_Element.Alignment).Draw();
        }        
    }
}
