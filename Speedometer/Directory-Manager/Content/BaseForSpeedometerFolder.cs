namespace Speedometer.Directory_Manager.Content
{
    abstract class BaseForSpeedometerFolder : DirectoryManager
    {
        private readonly string _baseSpeedometer = PathOfBaseToSpeedometer;
        private bool _disposedValue;


        protected string[] BaseImages
        { get { return AllBaseImagesForTheSpeedometer(); } }

        private string[] AllBaseImagesForTheSpeedometer()
        {
            _disposedValue = false;
            return ReturnThePathOfTheItemsPresentInThe(_baseSpeedometer);
        }

        protected override string GiveMeTheNameOfThis(ushort baseSpeedometer)
        {
            return GiveMeTheNameOfThis(baseSpeedometer).Remove(startIndex: 0, 
                                                                    count: _baseSpeedometer.Length);
        }
        protected override string GiveMeThePathOfThis(ushort baseSpeedometer)
        {
            return BaseImages[baseSpeedometer];
        }


        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if (BaseImages != null)
                        for (int i = 0; i < BaseImages.Length; i++) BaseImages[i] = null;
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
