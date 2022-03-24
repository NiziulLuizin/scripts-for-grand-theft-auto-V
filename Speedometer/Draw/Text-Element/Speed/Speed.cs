using Speedometer.Draw.Settings.For_The_Text_Elements;
using GTA.UI;

namespace Speedometer.Draw.Text_Element.Speed
{
    internal class Speed
    {
        internal static void Draw()
        {
            new TextElement(SpeedTextElementSettings.CorrectSpeed,
                            SpeedTextElementSettings.Position,
                            SpeedTextElementSettings.Scale,
                            SpeedTextElementSettings.Color,
                            SpeedTextElementSettings.Font,
                            SpeedTextElementSettings.Alignment).Draw();
        }        
    }
}
