using Speedometer_for_bicycle.User_configuration.Enum;
using GTA;

namespace Speedometer_for_bicycle.User_configuration
{
    internal static class Current
    {
        internal static MeasurementIn MeasurementSystem
        {
            get
            {
                return Game.GetProfileSetting(227) > 0 ? MeasurementIn.KMH : MeasurementIn.MPH;
            }
        } 
    }
}
