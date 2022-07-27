using System.Drawing;

using System.Drawing.Imaging;

using Good_screenshot.features.screenshot.creators.resources.structs;

using Good_screenshot.features.screenshot.creators.resources.enumerators;


namespace Good_screenshot.features.screenshot.creators
{
    internal abstract class BitmapCreator
    {
        protected Bitmap CreateAndReturnAnBitmapAlreadyConfiguredWithTheScreenSizeAndWithThis(EPixelFormat ePixelFormat)
        {
            var stResources
                = new StResources();

            var currentResolution
                = stResources
                        .CurrentResolution;

            return _
                   =
                   new Bitmap(currentResolution
                                            .Width, 
                              currentResolution
                                            .Height,
                              (PixelFormat)ePixelFormat);
        }
    }
}
