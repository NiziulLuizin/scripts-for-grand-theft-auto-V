using GTA;
using GTA.UI;
using Speedometer.Editor_Mode;
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
                if (Game.Player.Character.IsSittingInVehicle() && !EditorMode.IsEditorModeEnabled)
                {
                    SpriteManager.DisplayTheCurrentSpeedometer();
                }
            }; 
        }

        void NotifyWhenTheScriptHasBeenLoaded()
        {
            Screen.ShowHelpText("~r~Script loaded~w~!", 5000);
        }
    }
}
