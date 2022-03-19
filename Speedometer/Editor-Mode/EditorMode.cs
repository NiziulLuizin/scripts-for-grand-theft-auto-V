using GTA;
using GTA.UI;
using System.Windows.Forms;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Sprites;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Text_Elements;

namespace Speedometer.Editor_Mode
{
    internal class EditorMode : Script
    {
        private static bool _isEditorModeEnabled = false;
        private static bool _isToEditThePosition = false;
        private static bool _isToEditTheSize = false;

        private static string _element;
        private static float _velocity;

        private static float _ptfX = 0f;
        private static float _ptfY = 0f;
        private static float _szX = 0f;
        private static float _szY = 0f;


        internal static bool IsEditorModeEnabled 
        { get { return _isEditorModeEnabled; } }
        internal static bool IsToEditThePosition 
        { get { return _isToEditThePosition; } }
        internal static bool IsToEditTheSize 
        { get { return _isToEditTheSize; } }

        internal static float Velocity
        { get { return _velocity;  } }
        internal static string Element
        { get { return _element; } }

        internal static float PtfX 
        { get { return _ptfX; } }
        internal static float PtfY 
        { get { return _ptfY; } }
        internal static float SzX 
        { get { return _szX; } }
        internal static float SzY 
        { get { return _szY; } }



        public EditorMode()
        {
            KeyDown += (o, e) =>
            {
                if (IsEditorModeEnabled)
                {
                    if (IsToEditThePosition)
                    {
                        if (e.KeyCode is Keys.Up)
                            _ptfY -= 1 + _velocity;
                        else if (e.KeyCode == Keys.Down)
                            _ptfY += 1 + _velocity;

                        if (e.KeyCode is Keys.Left)
                            _ptfX -= 1 + _velocity;
                        else if (e.KeyCode == Keys.Right)
                            _ptfX += 1 + _velocity;
                    }
                    else if (IsToEditTheSize)
                    {
                        if (e.KeyCode is Keys.Up)
                            _szY -= 1 + _velocity;
                        else if (e.KeyCode == Keys.Down)
                            _szY += 1 + _velocity;

                        if (e.KeyCode is Keys.Left)
                            _szX -= 1 + _velocity;
                        else if (e.KeyCode == Keys.Right)
                            _szX += 1 + _velocity;
                    }
                }

                if (e.KeyCode is Keys.D1)
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
                            _isEditorModeEnabled = true;
                            break;
                        case "Edit Mode: Off":
                            _isEditorModeEnabled = false;
                            _isToEditThePosition = false;
                            _isToEditTheSize = false;
                            break;
                        case "Text Element: Distance":
                            _element = "Distance";
                            break;
                        case "Text Element: Speed":
                            _element = "Speed";
                            break;
                        case "Text Element: Time":
                            _element = "Time";
                            break;
                        case "Sprite: Speedometer":
                            _element = "Speedometer";
                            break;
                    }
                }

                if (e.KeyCode is Keys.D2)
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

                if (e.KeyCode is Keys.Oemplus)
                    _velocity += 1;
                else if (e.KeyCode is Keys.OemMinus)
                    _velocity -= 1;
            };
        }

        internal static void DrawInfos()
        {
            string instructions = "~b~Set what you will edit~w~";
            string instructions2 = "~y~Use the D2 key to choose between~w~ '~y~Edit Position~w~' or '~y~Edit Size~w~'";

            if (_element is null)
            {
                new TextElement($"Mode Edit: [~g~{IsEditorModeEnabled}~w~] / [{instructions}] [{instructions2}] (Element: ~o~{_element}~w~)", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            }

            switch (_element)
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
