using GTA.UI;
using Speedometer.Editor_Mode;
using Speedometer.Draw.Settings.For_The_Text_Elements;

namespace Speedometer.Draw.Text_Element.Editor_Mode.Informations.Text_Elements
{
    internal class TimeAttributes
    {
        internal static void Draw()
        {
            if (EditorMode.IsToEditThePosition)
            {
                new TextElement($"Position X: ~r~{TimeTextElementSettings.Position.X}~w~ Position Y: ~r~{TimeTextElementSettings.Position.Y}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Position~w~]", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
            else if (EditorMode.IsToEditTheSizeOrScale)
            {
                new TextElement($"Scale: ~r~{TimeTextElementSettings.Scale}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Size~w~]", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
        }
    }
}
