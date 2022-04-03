using GTA;
using System.Windows.Forms;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Sprites;
using Speedometer.Draw.Text_Element.Editor_Mode.Informations.Text_Elements;

namespace Speedometer.Editor_Mode
{
    internal class EditorMode : Script
    {
        internal static string PathToTheScriptFolder
        { get; private set; }

        internal static bool IsEditorModeEnabled 
        { get; private set; }
        internal static bool IsToEditThePosition 
        { get; private set; }
        internal static bool IsToEditTheSizeOrScale 
        { get; private set; }

        internal static string Element 
        { get; private set; }
        internal static float Velocity
        { get; private set; }

        internal static float PtfX 
        { get; private set; }
        internal static float PtfY 
        { get; private set; }
        internal static float SzW 
        { get; private set; }
        internal static float SzH 
        { get; private set; }

        //System.Drawing.PointF currentPosition;
        public EditorMode()
        {
            PathToTheScriptFolder = GetRelativeFilePath(@"Speedometer\");        
            
            Tick += (o, e) =>
            {
                //currentPosition = new System.Drawing.PointF(845f + PtfX, 650f + PtfY);

                if (IsEditorModeEnabled) 
                    DisplayEditingInformation();

                //if (Game.Player.Character.IsInVehicle())
            };

            KeyUp += OperationOfTheEditorMode;

            KeyDown += PositionEditingMode;
            KeyDown += SizeOrScaleEditinMode;

        }


        private void OperationOfTheEditorMode(object sender, KeyEventArgs e)
        {
            if (e.Modifiers is Keys.Shift && e.KeyCode is Keys.D1)
            {
                var Input = Game.GetUserInput();

                switch (Input)
                {
                    case "Edit Mode: On":
                        IsEditorModeEnabled = true;
                        break;
                    case "Edit Mode: Off":
                        IsEditorModeEnabled = false;
                        IsToEditThePosition = false;
                        IsToEditTheSizeOrScale = false;
                        break;
                }
            }

            if (e.Modifiers is Keys.Shift && e.KeyCode is Keys.D2 && IsEditorModeEnabled)
            {
                var Input = Game.GetUserInput();
                switch (Input)
                {
                    case "Save: Position":
                        //SettingsManager.Save(2, "PtfX", currentPosition.X);
                        //SettingsManager.Save(2, "PtfY", currentPosition.Y);
                        
                        //SettingsManager.Save("PtfX", SpeedometerBase.Position.X);
                        //SettingsManager.Save("PtfY", SpeedometerBase.Position.Y);
                        break;
                    case "Save: Size":
                        //SettingsManager.Save("SizeF", SpeedometerBase.Size);
                        break;
                    case "Edit: Position":
                        IsToEditThePosition = true;
                        IsToEditTheSizeOrScale = false;
                        break;
                    case "Edit: Size/Scale":
                        IsToEditTheSizeOrScale = true;
                        IsToEditThePosition = false;
                        break;
                    case "Edit: TextDistance":
                        Element = "Distance";
                        break;
                    case "Edit: TextSpeed":
                        Element = "Speed";
                        break;
                    case "Edit: TextTime":
                        Element = "Time";
                        break;
                    case "Edit: SpriteSpeedometer":
                        Element = "Speedometer";
                        break;
                }
            }

            if (e.KeyCode is Keys.Oemplus)
                Velocity++;
            else if (e.KeyCode is Keys.OemMinus)
                Velocity--;
        }
        private void SizeOrScaleEditinMode(object sender, KeyEventArgs e)
        {
            if (IsToEditTheSizeOrScale)
            {
                if (e.KeyCode is Keys.Up)
                    SzH -= 1 + Velocity;
                else if (e.KeyCode == Keys.Down)
                    SzH += 1 + Velocity;
                if (e.KeyCode is Keys.Left)
                    SzW -= 1 + Velocity;
                else if (e.KeyCode == Keys.Right)
                    SzW += 1 + Velocity;
            }
        }
        private void PositionEditingMode(object sender, KeyEventArgs e)
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
        }

        void DisplayEditingInformation()
        {
            //new GTA.UI.TextElement($"Position X: ~r~{currentPosition.X}~w~ Position Y: ~r~{currentPosition.Y}~w~ Velocity: ~r~{EditorMode.Velocity}~w~", new System.Drawing.PointF(200f, 200f), 0.40f).Draw();
            
            switch (Element)
            {
                case "Speedometer":
                    SpeedometerAttributes
                        .Draw();
                    break;
                case "Speed":
                    SpeedAttributes
                        .Draw();
                    break;
            }
        }
    }
}
