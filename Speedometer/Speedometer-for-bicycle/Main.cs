using Speedometer_for_bicycle.Renderings.Sprites.Current_Unit_of_Measure;
using GTA;

namespace Speedometer_for_bicycle
{
    public class Main : Script
    {
        public Main()
        {
            var Speedometer = new Speedometer_K().SpeedometerInK;
            
            NotifyWhenTheScriptHasBeenLoaded();

            Tick += (o, e) =>
            {
                Speedometer.ScaledDraw();
            };
        }

        void NotifyWhenTheScriptHasBeenLoaded()
        {
            GTA.UI.Screen.ShowHelpText("~r~Script loaded~w~!", 5000);
        }
    }
}
