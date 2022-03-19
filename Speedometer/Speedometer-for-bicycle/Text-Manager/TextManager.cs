using GTA;
using GTA.UI;
using System.IO;
using System.Windows.Forms;
using Speedometer.Draw.Settings.For_The_Sprites;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Sprites;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Text_Elements;

namespace Speedometer.Text_Manager
{
    internal class TextManager : Script
    {
        internal static string element;

        internal static float ptfX = 0f;
        internal static float ptfY = 0f;

        internal static float szX = 0f;
        internal static float szY = 0f;

        internal static float velocity;

        private static bool _isEditorModeEnabled = false;
        private static bool _isToEditThePosition = false;
        private static bool _isToEditTheSize = false;
        internal static bool IsEditorModeEnabled { get { return _isEditorModeEnabled; } }
        internal static bool IsToEditThePosition { get { return _isToEditThePosition; } }
        internal static bool IsToEditTheSize { get { return _isToEditTheSize; } }

        public TextManager()
        {
            Tick += (o, e) =>
            {
                if (IsEditorModeEnabled)
                {
                    DrawInfos();
                    Game.DisableControlThisFrame(GTA.Control.Phone);
                }
            };

            KeyDown += (o, e) =>
            {
                if (IsEditorModeEnabled)
                {
                    if (IsToEditThePosition)
                    {
                        if (e.KeyCode == Keys.Up)
                            ptfY -= 1 + velocity;
                        else if (e.KeyCode == Keys.Down)
                            ptfY += 1 + velocity;

                        if (e.KeyCode == Keys.Left)
                            ptfX -= 1 + velocity;
                        else if (e.KeyCode == Keys.Right)
                            ptfX += 1 + velocity;
                    }
                    else if (IsToEditTheSize)
                    {
                        if (e.KeyCode == Keys.Up)
                            szY -= 1 + velocity;
                        else if (e.KeyCode == Keys.Down)
                            szY += 1 + velocity;

                        if (e.KeyCode == Keys.Left)
                            szX -= 1 + velocity;
                        else if (e.KeyCode == Keys.Right)
                            szX += 1 + velocity;
                    }
                }

                if (e.KeyCode == Keys.D1)
                {
                    var Input = Game.GetUserInput();

                    switch (Input)
                    {
                        case "SavePosition()":
                            SaveConfigOfPosition();
                            break;
                        case "SaveSize()":
                            SaveConfigOfSize();
                            break;
                        case "Edit Mode: On":
                            _isEditorModeEnabled = true;
                            break;
                        case "Edit Mode: Off":
                            _isEditorModeEnabled = false;
                            _isToEditThePosition = false;
                            _isToEditTheSize = false;
                            break;
                        case "Text Element: Distance":
                            element = "Distance";
                            break;
                        case "Text Element: Speed":
                            element = "Speed";
                            break;
                        case "Text Element: Time":
                            element = "Time";
                            break;
                        case "Sprite: Speedometer":
                            element = "Speedometer";
                            break;
                    }
                }

                if (e.KeyCode == Keys.D2)
                {
                    if (IsEditorModeEnabled)
                    {
                        var Input = Game.GetUserInput();

                        switch (Input)
                        {
                            case "Edit Position":
                                _isToEditThePosition = true;
                                _isToEditTheSize = false;
                                break;
                            case "Edit Size":
                                _isToEditTheSize = true;
                                _isToEditThePosition = false;
                                break;
                        }
                    }
                }

                if (e.KeyCode == Keys.Oemplus)
                    velocity += 1;
                else if (e.KeyCode == Keys.OemMinus)
                    velocity -= 1;
            };
        }

        void SaveConfigOfPosition()
        {
            using (var ConfigPosition = new StreamWriter(GetRelativeFilePath("Image\\ConfigPosition.txt")))
                ConfigPosition.WriteLine($"Position X: {SpeedometerSettings.Position.X} Position Y: {SpeedometerSettings.Position.Y}");
        }

        void SaveConfigOfSize()
        {
            using (var ConfigPosition = new StreamWriter(GetRelativeFilePath("Image\\ConfigSize.txt")))
                ConfigPosition.WriteLine($"Size X: {SpeedometerSettings.Size.Width} Size Y: {SpeedometerSettings.Size.Height}");
        }

        static string ReturnWhatYouReadInTheLegacy(string path)
        {
            using (var FileContent = new StreamReader(path))
                return FileContent.ReadToEnd();
        }

        void DrawInfos()
        {
            string instructions = "~b~Set what you will edit~w~";
            string instructions2 = "~y~Use the D2 key to choose between~w~ '~y~Edit Position~w~' or '~y~Edit Size~w~'";

            if (element == null)
            {
                new TextElement($"Mode Edit: [~g~{IsEditorModeEnabled}~w~] / [{instructions}] [{instructions2}] (Element: ~o~{element}~w~)", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }

            switch (element)
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
