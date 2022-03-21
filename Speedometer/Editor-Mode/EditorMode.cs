using GTA;
using GTA.UI;
using System.Windows.Forms;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Sprites;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Text_Elements;

namespace Speedometer.Editor_Mode
{
    internal class EditorMode : Script
    {
        internal static bool IsEditorModeEnabled 
        { get; private set; }
        internal static bool IsToEditThePosition 
        { get; private set; }
        internal static bool IsToEditTheSize 
        { get; private set; }

        internal static string Element 
        { get; private set; }
        internal static float Velocity
        { get; private set; }

        internal static float PtfX 
        { get; private set; }
        internal static float PtfY 
        { get; private set; }
        internal static float SzX 
        { get; private set; }
        internal static float SzY 
        { get; private set; }



        public EditorMode()
        {
            KeyDown += (o, e) =>
            {
                if (IsEditorModeEnabled)
                {
                    if (IsToEditThePosition)
                    {
                        if (e.KeyCode is Keys.Up)
                            PtfY -= 1 + Velocity;
                        else if (e.KeyCode == Keys.Down)
                            PtfY += 1 + Velocity;

                        if (e.KeyCode is Keys.Left)
                            PtfX -= 1 + Velocity;
                        else if (e.KeyCode == Keys.Right)
                            PtfX += 1 + Velocity;
                    }
                    else if (IsToEditTheSize)
                    {
                        if (e.KeyCode is Keys.Up)
                            SzY -= 1 + Velocity;
                        else if (e.KeyCode == Keys.Down)
                            SzY += 1 + Velocity;

                        if (e.KeyCode is Keys.Left)
                            SzX -= 1 + Velocity;
                        else if (e.KeyCode == Keys.Right)
                            SzX += 1 + Velocity;
                    }
                }

                if (e.Modifiers is Keys.Shift && e.KeyCode is Keys.D1)
                {
                    var Input = Game.GetUserInput();

                    switch (Input)
                    {
                        case "SavePosition()":
                            //SaveConfigOfPosition();
                            break;
                        case "SaveSize()":
                            //SaveConfigOfSize();
                            break;
                        case "Edit Mode: On":
                            IsEditorModeEnabled = true;
                            break;
                        case "Edit Mode: Off":
                            IsEditorModeEnabled = false;
                            IsToEditThePosition = false;
                            IsToEditTheSize = false;
                            break;
                        case "Text Element: Distance":
                            Element = "Distance";
                            break;
                        case "Text Element: Speed":
                            Element = "Speed";
                            break;
                        case "Text Element: Time":
                            Element = "Time";
                            break;
                        case "Sprite: Speedometer":
                            Element = "Speedometer";
                            break;
                    }
                }

                if (e.Modifiers is Keys.Shift && e.KeyCode is Keys.D2)
                {
                    if (IsEditorModeEnabled)
                    {
                        var Input = Game.GetUserInput();

                        switch (Input)
                        {
                            case "Edit Position":
                                IsToEditThePosition = true;
                                IsToEditTheSize = false;
                                break;
                            case "Edit Size":
                                IsToEditTheSize = true;
                                IsToEditThePosition = false;
                                break;
                        }
                    }
                }

                if (e.KeyCode is Keys.Oemplus)
                    Velocity++;
                else if (e.KeyCode is Keys.OemMinus)
                    Velocity--;
            };
        }

        internal static void DrawInfos()
        {
            string instruction = "~b~Set what you will edit~w~";
            string instruction2 = "~y~Use the D2 key to choose between~w~ '~y~Edit Position~w~' or '~y~Edit Size~w~'";

            if (Element is null)
            {
                new TextElement($"Mode Edit: [~g~{IsEditorModeEnabled}~w~] / [{instruction}] [{instruction2}] (Element: ~o~{Element}~w~)", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }

            switch (Element)
            {
                case "Speedometer":
                    new SpeedometerAttributes();
                    break;
                case "Distance":
                    new DistanceAttributes();
                    break;
                case "Speed":
                    new SpeedAttributes();
                    break;
                case "Time":
                    new TimeAttributes();
                    break;
            }
        }
    }
}
