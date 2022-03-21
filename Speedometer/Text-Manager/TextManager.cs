using GTA;
using Speedometer.Draw.Settings.For_The_Sprites;
using Speedometer.Editor_Mode;
using System.IO;
using System.Windows.Forms;

namespace Speedometer.Text_Manager
{
    internal class TextManager : Script
    {
        private static readonly string _directoryForSettingTheSprite = $"\\Sprites\\Sprite-Parameter.ini";

        private static readonly string _directoryForTheConfigurationOfTheTextElement = $"\\Text-Elements\\Text-Element-Parameter.ini";

        public TextManager()
        {
            CreateTheParameterFiles();
        }

        void SaveConfigOfPosition()
        {
            //using (var Position = new StreamWriter()
                //Position.WriteLine();
        }

        void SaveConfigOfSize()
        {
            //using (var Size = new StreamWriter()
                //Size.WriteLine();
        }

        static string ReturnWhatYouReadInTheLegacy(string path)
        {
            using (var FileContent = new StreamReader(path))
                return FileContent.ReadToEnd();
        }

        void CreateTheParameterFiles()
        {
            var directoryToSettings = GetRelativeFilePath("Speedometer\\Settings");
            var styleGarp = "------------";

            var spriteParameterFile = ScriptSettings.Load($"{directoryToSettings}\\{_directoryForSettingTheSprite}");
                spriteParameterFile.SetValue("speedometer", $"{styleGarp}@Resolution", GTA.UI.Screen.Resolution);
                spriteParameterFile.SetValue("speedometer", $"{styleGarp}@AspectRatio", GTA.UI.Screen.AspectRatio);
                spriteParameterFile.SetValue("speedometer", "position", SpeedometerSettings.Position);
                spriteParameterFile.SetValue("speedometer", "size", SpeedometerSettings.Size);
            spriteParameterFile.Save();
            
            var textElementParameterFile = ScriptSettings.Load($"{directoryToSettings}\\{_directoryForTheConfigurationOfTheTextElement}");
                textElementParameterFile.SetValue("Distance", "position", 0f);
                textElementParameterFile.SetValue("Distance", "scale", 0f);

                textElementParameterFile.SetValue("Speed", "position", 0f);
                textElementParameterFile.SetValue("Speed", "scale", 0f);

                textElementParameterFile.SetValue("Time", "position", 0f);
                textElementParameterFile.SetValue("Time", "scale", 0f);
             textElementParameterFile.Save();
        }
    }
}
