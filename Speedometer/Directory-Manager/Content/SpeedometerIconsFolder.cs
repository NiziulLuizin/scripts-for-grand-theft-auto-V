namespace Speedometer.Directory_Manager.Content
{
    sealed class SpeedometerIconsFolder : DirectoryManager
    {
        private readonly string[] _icons =
        {
            $@"{PathOfIcons}\",
            $@"{PathOfIcons}Metric\",
            $@"{PathOfIcons}Imperial\"
        };
        private bool _disposedValue;

        private string[] SimpleIcons
        { get { return AllIconsSimple(); } }
        private string[] MetricIcons
        { get { return AllMetricIcons(); } }
        private string[] ImperialIcons
        { get { return AllImperialIcons(); } }

        protected override string GiveMeThePathOfThis(ushort icon, string type)
        {
            return CheckTheTypeAndPassMeTheCorrect(icon,
                                                   type);
        }
        protected override string GiveMeTheNameOfThis(ushort icon, string type)
        {
            int path;
            switch (type)
            {
                case "Metric":
                    path = 1;
                    break;
                case "Imperial":
                    path = 2;
                    break;
                default:
                    path = 0;
                    break;
            }
            return GiveMeThePathOfThis(icon,
                                       type).Remove(0,
                                                    _icons[path].Length);
        }

        private string CheckTheTypeAndPassMeTheCorrect(ushort icon, string type)
        {
            _disposedValue = false;
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

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if (SimpleIcons != null)
                        for (int i = 0; i < SimpleIcons.Length; i++) SimpleIcons[i] = null;

                    if (MetricIcons != null)
                        for (int i = 0; i < MetricIcons.Length; i++) MetricIcons[i] = null;

                    if (ImperialIcons != null)
                        for (int i = 0; i < ImperialIcons.Length; i++) ImperialIcons[i] = null;
                }
                _disposedValue = true;
            }
        }

        public override void Dispose()
        {
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}