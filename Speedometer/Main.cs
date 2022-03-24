using GTA;
using Speedometer.Draw.Sprites.CurrentSpeedometer;
using Speedometer.Editor_Mode;

namespace Speedometer
{
    public class Main : Script
    {
        public bool IsToActivateTheNewSprite { get; private set; }
        public Main()
        {     
            Tick += (o, e) =>
            {
                if (Game.Player.Character.IsSittingInVehicle() && !EditorMode.IsEditorModeEnabled)
                {
                    CurrentSpeedometer.Draw();
                    //SpriteManager.DisplayTheCurrentSpeedometer();
                }
                
                if (IsToActivateTheNewSprite) { }
                                 
            };
            KeyUp += (o, e) =>
            {
                if (e.KeyCode == System.Windows.Forms.Keys.CapsLock)
                    IsToActivateTheNewSprite = !IsToActivateTheNewSprite;
            };
        }
    }
}
