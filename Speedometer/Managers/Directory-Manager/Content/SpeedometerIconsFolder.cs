namespace Speedometer.Managers.Directory_Manager.Content
{
    abstract class SpeedometerIconsFolder : DirectoryManager
    {
        private readonly string[] _icons =
        {
            $@"{PathOfIcons}\",
            $@"{PathOfIcons}Metric\",
            $@"{PathOfIcons}Imperial\"
        };

        private string[] SimpleIcons
        { get { return AllIconsSimple(); } }
        private string[] MetricIcons
        { get { return AllMetricIcons(); } }
        private string[] ImperialIcons
        { get { return AllImperialIcons(); } }


        protected override string GiveMeThis(string sprite)
        {
            if (sprite.Contains("Simples"))
                return CompleteDirectoryOfThis(sprite, folder: SimpleIcons);
            else if (sprite.Contains("Metric"))
                return CompleteDirectoryOfThis(sprite, folder: MetricIcons);
            else if (sprite.Contains("Imperial"))
                return CompleteDirectoryOfThis(sprite, folder: ImperialIcons);

            return string.Empty;
        }
        private string CompleteDirectoryOfThis(string spriteName, string[] folder)
        {
            foreach (var imageName in folder)
                if (spriteName.Contains(imageName))
                    return spriteName;

            return string.Empty;
        }

        private string[] AllIconsSimple()
        {
            return ReturnAllDirectory(_icons[0]);
        }
        private string[] AllMetricIcons()
        {
            return ReturnAllDirectory(_icons[1]);
        }
        private string[] AllImperialIcons()
        {
            return ReturnAllDirectory(_icons[2]);
        }

        private string[] ReturnAllDirectory(string icons)
        {
            return ReturnThePathOfTheItemsPresentInThe(folder: icons);
        }
    }
}