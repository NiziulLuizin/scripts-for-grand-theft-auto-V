using GTA.UI;

namespace Speedometer_for_bicycle.Renderings.Sprites.Current_Unit_of_Measure
{ 
    public class Speedometer_K : Sprite_Manager
    {
        public Sprite SpeedometerInK => new Sprite_Manager().ReturnTheCurrentSpeedometer();
    }
}
