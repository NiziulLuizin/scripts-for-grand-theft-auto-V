using GTA.UI;

using System;

using System.Drawing;

using System.Collections.Generic;

using Good_screenshot.features.screenshot.managers;

using Good_screenshot.features.screenshot.creators.resources.structs;

using Good_screenshot.features.screenshot.creators.resources.enumerators;


namespace Good_screenshot.features.screenshot
{
    internal class Screenshot : IDisposable
    {
        private readonly IList<Bitmap> _screenshots;
        
        private readonly BitmapManager _bitmapManager;

        private readonly GraphicManager _graphicManager;


        public Screenshot()
        {
            _screenshots 
            = new List<Bitmap>();
            
            _bitmapManager 
            = new BitmapManager();
            
            _graphicManager 
            = new GraphicManager();
        }

        internal void MakeAnSequenceOfScreenshots(byte amount, int interval = 100)
        {
            for (var i = 0; i < amount; i++)
            {
                MakeAnScreenshot();

                Main
                    .Wait(interval);
            }
        }
        
        internal void MakeAnScreenshot()
        {
            var bitmap
                = _bitmapManager
                        .ReturnAnBitmapWihtThis(EPixelFormat
                                                    .Format32bppRgb);

            RecordTheScreenshotInThis(bitmap);
        }

        private void RecordTheScreenshotInThis(Bitmap bitmap)
        {
            var stResources
                = new StResources();

            var mainScreen
                = stResources
                        .MainScreen;

            var bounds
                = mainScreen
                        .Bounds;

            var graphic
                = _graphicManager
                        .ReturnAnGraphicOfThis(bitmap);

            graphic
                .CopyFromScreen(sourceX        : bounds
                                                    .Left,
                                sourceY        : bounds
                                                    .Top,
                                destinationX   : 0,
                                destinationY   : 0,
                                blockRegionSize: bounds
                                                    .Size);

            graphic
                .Dispose();

            _screenshots
                .Add(bitmap);
        }
        
        internal void SaveAllScreenshotsInThis(string path)
        {
            var index
                = 0;

            foreach (var screenshot in _screenshots)
            {
                index++;

                var currentScreenshot
                    = $"Screenshot - {index}";

                LoadingPrompt
                    .Show($"Save: {currentScreenshot}");

                screenshot
                    .Save($"{path}{currentScreenshot}.png");

                Main
                    .Wait(5000);

                LoadingPrompt
                    .Hide();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            else
            {
                if (_screenshots != null)
                {
                    foreach (var screenshot in _screenshots)
                    {
                        screenshot
                            .Dispose();
                    }

                    _screenshots
                        .Clear();
                }
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}