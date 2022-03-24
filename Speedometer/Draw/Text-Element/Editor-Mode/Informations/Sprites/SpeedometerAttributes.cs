using GTA.UI;
using Speedometer.Editor_Mode;
using Speedometer.Draw.Settings.For_The_Sprites;
using Speedometer.Draw.Sprites.CurrentSpeedometer;

namespace Speedometer.Draw.Text_Element.Editor_Mode.Informations.Sprites
{
    internal class SpeedometerAttributes
    {
        internal static void Draw()
        {
            if (EditorMode.IsToEditThePosition)
            {
                new TextElement($"Position X: ~r~{SpeedometerBase.Position.X}~w~ Position Y: ~r~{SpeedometerBase.Position.Y}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Position~w~] (Element: ~o~{EditorMode.Element}~w~)", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
            else if (EditorMode.IsToEditTheSizeOrScale)
            {
                new TextElement($"Size X: ~r~{SpeedometerBase.Size.Width}~w~ Size Y: ~r~{SpeedometerBase.Size.Height}~w~ Velocity: ~r~{EditorMode.Velocity}~w~ Mode Edit: ~g~{EditorMode.IsEditorModeEnabled}~w~ / [~g~Edit The Size~w~]", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }
            CurrentSpeedometer
                .Draw();
        }
    }
}
