using System.Drawing;

using System.Collections.Generic;

using Good_screenshot.features.screenshot.managers;

using Good_screenshot.features.screenshot.creators.resources.structs;


namespace Good_screenshot.features.screenshot
{
    internal class Screenshot
    {
        private readonly IList<Bitmap> _screenshots;
        
        private readonly BitmapManager _bitmapaManager;

        private readonly GraphicsManager _graphicsManager;


        public Screenshot()
        {
            _screenshots 
            = new List<Bitmap>();
            
            _bitmapaManager 
            = new BitmapManager();
            
            _graphicsManager 
            = new GraphicsManager();
        }


        internal void MakeAnScreenshot()
        {
            var bitmap
                = _bitmapaManager
                        .ReturnAnBitmapWihtThis();

            var graphics
                = _graphicsManager
                        .ReturnAnGraphicOfThis(bitmap);

            RecordTheScreenshotInThis(graphics);

            _screenshots
                .Add(bitmap);
        }
        
        private void RecordTheScreenshotInThis(Graphics graphic)
        {
            var stResources
                = new StResources();

            var mainScreen
                = stResources
                        .MainScreen;

            var bounds
                = mainScreen
                        .Bounds;

            graphic
                .CopyFromScreen(bounds.Left,
                                bounds.Top,
                                0,
                                0,
                                bounds.Size);

            graphic
                .Dispose();
        }
        
        internal void SaveAllScreenshotsInThis(string path)
        {
            var index
                = 0;

            foreach (var screenshot in _screenshots)
            {
                index ++;

                screenshot
                    .Save(path + $"Screenshot - {index}.png");

                Main
                    .Yield();
            }
        }
        
        internal void Dispose()
        {
            if (_screenshots != null)
            {
                foreach (var screenshot in _screenshots)
                {
                    screenshot
                        .Dispose();
                }
            }

            _screenshots
                .Clear();
        }
    }
}
