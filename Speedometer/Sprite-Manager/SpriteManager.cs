using Speedometer.Draw.Text_Element.Distance;
using Speedometer.Draw.Sprites.CurrentSpeedometer;
using Speedometer.Draw.Text_Element.Speed;
using Speedometer.Draw.Text_Element.Time;

namespace Speedometer
{
    internal class SpriteManager
    {
        internal static void DisplayTheCurrentSpeedometer()
        {
            CurrentSpeedometer
                .Draw();
            Distance
                .Draw();
            Speed
                .Draw();
            Time
                .Draw();
        }
    }
}

