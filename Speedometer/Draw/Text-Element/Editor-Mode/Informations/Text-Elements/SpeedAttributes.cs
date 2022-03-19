using GTA.UI;
using Speedometer.Editor_Mode;
using Speedometer.Draw.Settings.For_The_Text_Elements;

namespace Speedometer.Draw.Text_Element.Editor_Mode.Informations.Text_Elements
{
    internal class SpeedAttributes
    {
        internal SpeedAttributes()
        {
            if (EditorMode.IsToEditThePosition)
            {
                new TextElement($"Position X: ~r~{SpeedTextElementSettings.Position.X}~w~ Position Y: ~r~{SpeedTextElementSettings.Position.Y}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Position~w~]", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
            else if (EditorMode.IsToEditTheSize)
            {
                new TextElement($"Scale: ~r~{SpeedTextElementSettings.Scale}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Size~w~]", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
        }
    }
}
