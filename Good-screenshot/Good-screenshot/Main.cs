using GTA;

using GTA.UI;

using System.Drawing;

using System.Windows.Forms;

using Good_screenshot.settings;

using Good_screenshot.features.screenshot;


namespace Good_screenshot
{
    internal class Main : Script
    {
        public Main()
        {
            var settings
                = new Settings();

            var screenshot
                = new Screenshot();

            Tick += (o, e) =>
            {

            };

            KeyUp += (o, e) =>
            {
                switch (e.KeyData)
                {
                    case Keys.D0:
                        {
                            screenshot
                                .MakeAnScreenshot();

                            Yield();
                        }
                        break;
                    case Keys.D9:
                        {
                            screenshot
                                .SaveAllScreenshotsInThis(settings.PathToTheFolderGoodScreenshot);

                            screenshot
                                .Dispose();
                        }
                        break;
                }
            };

            Aborted += (o, e) =>
            {
                screenshot
                    .Dispose();
            };
        }
    }
}
