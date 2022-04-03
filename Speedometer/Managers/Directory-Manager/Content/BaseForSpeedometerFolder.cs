namespace Speedometer.Managers.Directory_Manager.Content
{
    abstract class BaseForSpeedometerFolder : DirectoryManager
    {
        private string[] BaseImages
        { get { return AllBaseImagesForTheSpeedometer(); } }

        private string[] AllBaseImagesForTheSpeedometer()
        {
            return ReturnThePathOfTheItemsPresentInThe(PathOfBaseToSpeedometer);
        }

        protected override string GiveMeThis(string sprite)
        {
            foreach (var image in BaseImages)
            {
                if (image.Contains(sprite))
                    return image;
            }
            return string.Empty;
        }
    }
}
