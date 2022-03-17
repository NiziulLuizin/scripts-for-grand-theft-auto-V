using Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements;
using GTA.UI;

namespace Speedometer_for_bicycle.Draw.Text_Element.Distance
{
    internal class Distance
    {
        internal static void Draw()
        {
            new TextElement(Distance_Text_Element.Distance,
                            Distance_Text_Element.Position,
                            Distance_Text_Element.Scale,
                            Distance_Text_Element.Color,
                            Distance_Text_Element.Font,
                            Distance_Text_Element.Alignment).Draw();
        }   
    }
}
