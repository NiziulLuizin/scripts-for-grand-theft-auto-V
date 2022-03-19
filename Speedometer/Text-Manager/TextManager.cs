using System.IO;

namespace Speedometer.Text_Manager
{
    internal class TextManager
    {
        private static string DirectoryForTheSettings
        { get { return new Main().GetRelativeFilePath("SpeedometerSettings"); } }

        private static readonly string _directoryForSettingTheSpriteSize = $"{DirectoryForTheSettings}\\Sprites\\Size.txt";
        private static readonly string _directoryForSettingTheSpritePosition = $"{DirectoryForTheSettings}\\Sprites\\Position.txt";

        private static readonly string _directoryForTheConfigurationOfThePositionOfScale = $"{DirectoryForTheSettings}\\Text-Element\\Scale.txt";
        private static readonly string _directoryForTheConfigurationOfThePositionOfTheTextElement = $"{DirectoryForTheSettings}\\Text-Element\\Position.txt";

        public TextManager()
        {

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
    }
}
