using Speedometer.Draw.Settings.For_The_Sprites;

namespace Speedometer.Draw.Sprites.CurrentSpeedometer
{
    internal class CurrentSpeedometer : SpeedometerBase
    {
        private string _baseSpeedometer;
        public GTA.UI.CustomSprite GettingThe(string baseSpeedometer)
        {
            _baseSpeedometer = baseSpeedometer;
            return new GTA.UI.CustomSprite(CorrectFilenameThe(baseSpeedometer),
                                           CorrectSizeThe(baseSpeedometer),
                                           CorrectPositionThe())
            { Centered = true };
        }

        public System.Drawing.SizeF GettingSizeF()
        {
            return CorrectSizeThe(_baseSpeedometer);
        }
    }
}