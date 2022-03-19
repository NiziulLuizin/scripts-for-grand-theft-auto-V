using GTA.UI;
using Speedometer.Editor_Mode;
using Speedometer.Draw.Settings.For_The_Sprites;

namespace Speedometer.Draw.Text_Element.Editor_Mode.Informations.Sprites
{
    internal class SpeedometerAttributes
    {
        internal SpeedometerAttributes()
        {
            if (EditorMode.IsToEditThePosition)
            {
                new TextElement($"Position X: ~r~{SpeedometerSettings.Position.X}~w~ Position Y: ~r~{SpeedometerSettings.Position.Y}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Position~w~] (Element: ~o~{EditorMode.Element}~w~)", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
            else if (EditorMode.IsToEditTheSize)
            {
                new TextElement($"Size X: ~r~{SpeedometerSettings.Size.Width}~w~ Size Y: ~r~{SpeedometerSettings.Size.Height}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Size~w~]", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
        }
    }
}
