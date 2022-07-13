using GTA;
using GTA.UI;

using System.IO;
using System.Drawing;


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

        internal PointF ReturnThePositionOfCenterOfScreen()
        {
            var displayCompatibility =
                ScriptSettings
                    .Load(PathToTheAutorotationManeuverFolder
                            +
                          @"\UserInterfaceResources\DisplayCompatibility.ini");

            var aspectRatio =
                Screen
                    .AspectRatio;

            var screenCompatibility =
                displayCompatibility
                    .GetAllValues<string>(section: "Compatibility",
                                          name   : $"{aspectRatio}")[0];

            var screenCenterPosition =
                displayCompatibility
                    .GetAllValues<string>(section: screenCompatibility,
                                          name   : "Screen Center Position")[0];

            return new PointF(x: float
                                    .Parse(screenCenterPosition),
                              y: 0f);
        }

    }
}
