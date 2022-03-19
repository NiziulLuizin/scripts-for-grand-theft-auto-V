using GTA.UI;
using Speedometer.Draw.Settings.For_The_Text_Elements;

namespace Speedometer.Draw.Text_Element.Distance
{
    internal class Distance
    {
        internal static void Draw()
        {
            new TextElement(DistanceTextElementSettings.Distance,
                            DistanceTextElementSettings.Position,
                            DistanceTextElementSettings.Scale,
                            DistanceTextElementSettings.Color,
                            DistanceTextElementSettings.Font,
                            DistanceTextElementSettings.Alignment).Draw();
        }   
    }
}
