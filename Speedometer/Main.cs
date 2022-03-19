using GTA;
using GTA.UI;
using Speedometer.Editor_Mode;

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
