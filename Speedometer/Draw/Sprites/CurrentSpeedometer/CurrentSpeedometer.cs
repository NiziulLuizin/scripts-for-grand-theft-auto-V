using GTA.UI;
using Speedometer.Draw.Settings.For_The_Sprites;

namespace Speedometer.Draw.Sprites.CurrentSpeedometer
{
    internal class CurrentSpeedometer : SpeedometerBase
    {
        public CustomSprite GettingThe(ushort baseSpeedometer)
        {
            return new CustomSprite(GiveMeTheCorrectFilenameThe(baseSpeedometer),
                                    GiveMeTheCorrectSizeThe(baseSpeedometer),
                                    GiveMeTheCorrectPositionThe(baseSpeedometer)) { Centered = true };
        }
    }
}
