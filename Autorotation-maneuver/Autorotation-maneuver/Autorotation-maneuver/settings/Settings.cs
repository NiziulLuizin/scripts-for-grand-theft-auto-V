using System.IO;


namespace Autorotation_maneuver.settings
{
    internal sealed class Settings
    {
        internal string PathToTheAutorotationManeuverFolder
        {
            get
            {
                return $@"{Directory
                                .GetCurrentDirectory()}\scripts\AutorotationManeuver";
            }
        }
    }
}
