namespace Speedometer.Directory_Manager.Content
{
    sealed class SpeedometerIconsFolder : DirectoryManager
    {
        private static readonly string[] _pathIcons = 
        {
            $"{PathOfIcons}Metric\\",
            $"{PathOfIcons}Imperial\\"
        };

        private static string[] IconsMetric 
        { get { return ReturnAllMetricIcons(); } }
        private static string[] IconsImperial 
        { get { return ReturnAllImperialIcons(); } }

        internal static string GiveMeThePathOfThis(int icon, GTA.MeasurementSystem type)
        {
            if (type is GTA.MeasurementSystem.Metric)
                return IconsMetric[icon];
            else
                return IconsImperial[icon];
        }
        internal static string GiveMeTheNameOfThis(int icon, GTA.MeasurementSystem type)
        {
            if (type is GTA.MeasurementSystem.Metric)
                return IconsMetric[icon].Remove(0, _pathIcons[0].Length);
            else
                return IconsImperial[icon].Remove(0, _pathIcons[1].Length);
        }
        private static string[] ReturnAllMetricIcons()
        {
            return ReturnThePathOfTheItemsPresentInThe(_pathIcons[0]);
        }
        private static string[] ReturnAllImperialIcons()
        {
            return ReturnThePathOfTheItemsPresentInThe(_pathIcons[1]);
        }
    }
}
