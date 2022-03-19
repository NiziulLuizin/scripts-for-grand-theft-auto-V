using GTA;
using GTA.UI;
using Speedometer.Text_Manager;

namespace Speedometer
{
    public class Main : Script
    {
        public Main()
        {
            NotifyWhenTheScriptHasBeenLoaded();         

            Tick += (o, e) =>
            {
                if (Game.Player.Character.IsSittingInVehicle() && !TextManager.IsEditorModeEnabled)
                {
                    SpriteManager.DisplayTheCurrentSpeedometer();
                    //Distance_Traveled_Text_Element.Position = new System.Drawing.PointF(TextManager.ptfX, TextManager.ptfY);
                }
            }; 
        }

        void NotifyWhenTheScriptHasBeenLoaded()
        {
            Screen.ShowHelpText("~r~Script loaded~w~!", 5000);
        }
    }
}
