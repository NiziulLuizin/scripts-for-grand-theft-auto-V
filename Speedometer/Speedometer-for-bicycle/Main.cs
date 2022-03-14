using Speedometer_for_bicycle.Renderings.Sprites.Current_Unit_of_Measure;
using Speedometer_for_bicycle.Text_Element.Speed;
using System.Windows.Forms;
using System.IO;
using GTA.UI;
using System;
using GTA;

namespace Speedometer_for_bicycle
{
    public class Main : Script
    {
        float PtfX = 0f;
        float PtfY = 0f;

        float SzX = 0f;
        float SzY = 0f;

        float Velocity;
        public Main()
        {
            NotifyWhenTheScriptHasBeenLoaded();         

            Tick += (o, e) =>
            {
                drawInfos();

                if (Game.Player.Character.IsSittingInVehicle())
                {
                    if(Game.Player.Character.CurrentVehicle.Type == VehicleType.Bicycle)
                    {
                        Sprite_Manager.ReturnTheCurrentSpeedometer.ScaledDraw();
                        Speed.Show().Draw();
                    }
                    else if (Game.Player.Character.CurrentVehicle.Type == VehicleType.Helicopter)
                    {
                        var Speed = new TextElement((Game.Player.Character.CurrentVehicle.Speed * 1.94384f).ToString("0"), new System.Drawing.PointF(644f, 662f), 0.50f, System.Drawing.Color.White, Font.Monospace, Alignment.Center);
                        Speed.Draw();
                    }
                }     
            };

            KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Up)
                    PtfY -= 1 + Velocity;
                else if(e.KeyCode == Keys.Down)
                    PtfY += 1 + Velocity;

                if (e.KeyCode == Keys.Left)
                    PtfX -= 1 + Velocity;
                else if (e.KeyCode == Keys.Right)
                    PtfX += 1 + Velocity;

                if(e.KeyCode == Keys.D9)
                    SzX = Convert.ToSingle(Game.GetUserInput());
                else if(e.KeyCode == Keys.D8)
                    SzY = Convert.ToSingle(Game.GetUserInput());


                if (e.KeyCode == Keys.D7)
                {
                    var Input = Game.GetUserInput();

                    if (Input == "SavePosition")
                        SaveConfigOfPosition();
                    else if (Input == "SaveSize")
                        SaveConfigOfSize();
                }

                if (e.KeyCode == Keys.Oemplus)
                    Velocity += 1;
                else if (e.KeyCode == Keys.OemMinus)
                    Velocity -= 1;
            };
        }

        void NotifyWhenTheScriptHasBeenLoaded()
        {
            GTA.UI.Screen.ShowHelpText("~r~Script loaded~w~!", 5000);
        }

        void SaveConfigOfPosition()
        {
            using (var ConfigPosition = new StreamWriter(GetRelativeFilePath("Image\\ConfigPosition.txt")))
                ConfigPosition.WriteLine($"Position X: {PtfX} Position Y: {PtfY}");
        }

        void SaveConfigOfSize()
        {
            using (var ConfigPosition = new StreamWriter(GetRelativeFilePath("Image\\ConfigSize.txt")))
                ConfigPosition.WriteLine($"Size X: {SzX} Size Y: {SzY}"); 
        }

        static string ReturnWhatYouReadInTheLegacy(string path)
        {
            using (var FileContent = new StreamReader(path))
                return FileContent.ReadToEnd();
        }


        void drawInfos()
        {
            var InformationGroup = new TextElement($"Position X: ~r~{PtfX}~w~ Position Y: ~r~{PtfY}~w~ Velocity: ~r~{Velocity}~w~", new System.Drawing.PointF(200f, 200f), 0.40f);
                InformationGroup.Draw();
        }
    }
}
