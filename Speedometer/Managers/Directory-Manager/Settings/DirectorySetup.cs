using Speedometer.Editor_Mode;

namespace Speedometer.Managers.Directory_Manager.Settings
{
    abstract class DirectorySetup
    {
        private static string Directory 
        { 
            get { return EditorMode.PathToTheScriptFolder;} 
        }

        protected static string PathToUserInterface
        { get { return $@"{Directory}UI\"; } }
        protected static string PathOfIcons
        { get { return $@"{PathToUserInterface}SpeedometerIcons\"; } }
        protected static string PathOfBaseToSpeedometer
        { get { return $@"{PathToUserInterface}BaseForSpeedometer\"; } }
    }
}
