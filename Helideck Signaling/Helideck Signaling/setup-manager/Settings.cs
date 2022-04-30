using GTA;

namespace Helideck_Signaling.setup_manager
{
    class Settings
    {
        private ScriptSettings fileSetBlipColor;

        public Settings(string directory)
        {
            fileSetBlipColor = ScriptSettings.Load($"{directory}/SetBlipColor.ini");

            SetTheColor();
        }

        void SetTheColor()
        {
            var id = GetTheColorForTheBlip();

            if (id >= 0 &&
                id <= 85)
            {
                SettingColor.ColorId = GetTheColorForTheBlip();
            }
        }
        int GetTheColorForTheBlip()
        {
            return fileSetBlipColor.GetValue<int>("Blip color", "Id:", 5);
        }
    }
}