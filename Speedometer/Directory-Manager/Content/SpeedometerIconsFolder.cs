using GTA;

namespace Speedometer.Directory_Manager.Content
{
    sealed class SpeedometerIconsFolder : DirectoryManager
    {
        private static readonly string[] _pathIcons =
        {
            $@"{PathOfIcons}\",
            $@"{PathOfIcons}Metric\",
            $@"{PathOfIcons}Imperial\"
        };

        internal static string[] SimpleIcons
        { get { return ReturnAllSimpleIcons(); } }
        internal static string[] MetricIcons
        { get { return ReturnAllMetricIcons(); } }
        internal static string[] ImperialIcons
        { get { return ReturnAllImperialIcons(); } }

        internal static string GiveMeThePathOfThis(int icon, string type)
        {
            return CheckTheTypeAndPassMeTheCorrectIcon(icon, type);
        }
        internal static string GiveMeTheNameOfThis(int icon, string type)
        {
            int path;
            switch (type)
            {
                case "Metric": path = 1;
                    break;
                case "Imperial": path = 2;
                    break;
                default: path = 0;
                    break;
            }
            return GiveMeThePathOfThis(icon, type).Remove(0, _pathIcons[path].Length);
        }

        private static string CheckTheTypeAndPassMeTheCorrectIcon(int icon, string type)
        {
            return type
                   is "Simple"
                   ? SimpleIcons[icon]
                   : type 
                   is "Metric"
                   ? MetricIcons[icon]
                   : type 
                   is "Imperial"
                   ? ImperialIcons[icon]
                   : null;
        }
        private static string[] ReturnAllSimpleIcons()
        {
            return ReturnThePathOfTheItemsPresentInThe(_pathIcons[0]);
        }
        private static string[] ReturnAllMetricIcons()
        {
            return ReturnThePathOfTheItemsPresentInThe(_pathIcons[1]);
        }
        private static string[] ReturnAllImperialIcons()
        {
            return ReturnThePathOfTheItemsPresentInThe(_pathIcons[2]);
        }
    }
}
