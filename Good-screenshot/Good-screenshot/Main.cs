using GTA;

using Good_screenshot.settings;

using Good_screenshot.features.screenshot;


namespace Good_screenshot
{
    internal sealed class Main : Script
    {
        public Main()
        {
            var settings
                = new Settings();
            

            Tick    += (o, e) =>
            {
                if (Game.WasCheatStringJustEntered("ScreenshotSequence();"))
                {
                    using (var screenshot 
                               = new Screenshot())
                    {
                        Main
                            .Yield();

                        for (var i = 0; i < 5; i++)
                        {
                            screenshot
                                .MakeAnScreenshot();

                            Main
                                .Wait(5000);
                        }

                        Main
                            .Yield();

                        screenshot
                            .SaveAllScreenshotsInThis(settings
                                                            .PathToTheGoodScreenshotFolder);

                        Main
                            .Yield();
                    }
                    
                    GTA.UI.Notification.Show("~g~all screenshots were saved successfully~w~!");
                }
            };

            KeyUp   += (o, e) =>
            {
            };

            Aborted += (o, e) =>
            {
            };
        }
    }
}
