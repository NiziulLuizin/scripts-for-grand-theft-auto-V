using Speedometer_for_bicycle.User_configuration.Enum;
using Speedometer_for_bicycle.User_configuration;

namespace Speedometer_for_bicycle.Renderings.Sprites.Informations.Image
{
    public static class Sprite_Speedometer
    {
        public static string Name
        {
            get
            {
                return (Current.MeasurementSystem == MeasurementIn.KMH) ? "SpeedometerK" : "SpeedometerM";
            }
        }

        public static string Directory
        {
            get
            {
                return "Speedometer";
            }
        }
    }
}
