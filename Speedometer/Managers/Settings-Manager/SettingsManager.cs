using GTA;
using System.IO;
using System.Drawing;
using Speedometer.Editor_Mode;

namespace Speedometer.Managers.Settings_Manager
{
    internal class SettingsManager
    {
        private static readonly string _directory = EditorMode.PathToTheScriptFolder;

        private static readonly string[] _settings = new string[] 
        { 
            $"Settings\\Sprites\\Sprites-Parameters.ini",
            $"Settings\\Text-Elements\\Texts-Elements-Parameters.ini",
            $"Settings\\ConfigKeys.ini"
        };

        internal static PointF GetTheCurrentPosition(int settingsNumber)
        {
            var file = ScriptSettings.Load($"{_directory}{_settings[settingsNumber]}");
            var ptfX = file.GetValue(Sections.ReturnsTheCurrentScreenSettings(), "PtfX", 0f);
            var ptfY = file.GetValue(Sections.ReturnsTheCurrentScreenSettings(), "PtfY", 0f);

            return new PointF(ptfX, ptfY);
        }
        internal static SizeF GetTheCurrentSize(int settingsNumber)
        {
            var file = ScriptSettings.Load($"{_directory}{_settings[settingsNumber]}");
            var size = file.GetValue(Sections.ReturnsTheCurrentScreenSettings(), "SizeF", new SizeF());
            return size;
        }
        internal static void Save<T>(int fileNumber, string nameOfValue, T value)
        {
            int _fileNumber = fileNumber;

            CreateTheConfigurationFilesIfTheyDoNotExist();

            var file = ScriptSettings.Load($"{_directory}{_settings[_fileNumber]}");
                file.SetValue(Sections.ReturnsTheCurrentScreenSettings(), nameOfValue, value);
                file.Save();
        }

        static int TheSettingsBelongToWhichElement()
        {
            var settingsNumber = 3;

            if (EditorMode.Element != null && EditorMode.Element != "Speedometer")
                settingsNumber = 1;
            else if (EditorMode.Element == "Speedometer")
                settingsNumber = 0;

            return settingsNumber;
        }
        static void CreateTheConfigurationFilesIfTheyDoNotExist()
        {
            for (int i = 0; i < _settings.Length; i++)
                if (!File.Exists($"{_directory}{_settings[i]}"))
                    CreateTheParameterFiles(i);
        }
        static void CreateTheParameterFiles(int fileNumber)
        {
            var file = ScriptSettings.Load($"{_directory}{_settings[fileNumber]}");
                file.Save();
        }
    }
}
