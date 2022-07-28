using GTA;

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

            Tick += (o, e) =>
            {
                if (Game.WasCheatStringJustEntered("ScreenshotSequence();"))
                {
                    using (var screenshot = new Screenshot())
                    {
                        Main.Yield();

                        screenshot
                            .MakeAnSequenceOfScreenshots(amount  : 5, 
                                                         interval: 5000);

                        Main.Yield();

                        screenshot
                            .SaveAllScreenshotsInThis(settings
                                                            .PathToTheFolderGoodScreenshot);

                        Main.Yield();
                    }
                    
                    
                    GTA.UI.Notification.Show("~g~all screenshots were saved successfully~w~!");
                }
            };

            KeyUp += (o, e) =>
            {
            };

            Aborted += (o, e) =>
            {
            };
        }
    }
}
