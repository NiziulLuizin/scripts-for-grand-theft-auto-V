using Speedometer_for_bicycle.Draw.Sprites;
using GTA.UI;
using GTA;

namespace Speedometer_for_bicycle
{
    public class Main : Script
    {
        public Main()
        {
            NotifyWhenTheScriptHasBeenLoaded();         

            Tick += (o, e) =>
            {
                if (Game.Player.Character.IsSittingInVehicle())
                {
                    if(Game.Player.Character.CurrentVehicle.Type == VehicleType.Bicycle)
                    {
                        SpriteManager.ReturnTheCurrentSpeedometer();
                        //Distance_Traveled_Text_Element.Position = new System.Drawing.PointF(TextManager.ptfX, TextManager.ptfY);
                    }
                }     
            }; 
        }

        void NotifyWhenTheScriptHasBeenLoaded()
        {
            Screen.ShowHelpText("~r~Script loaded~w~!", 5000);
        }
    }
}
