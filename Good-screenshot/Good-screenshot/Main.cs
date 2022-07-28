using GTA;

using System.Windows.Forms;

using Good_screenshot.settings;

using Good_screenshot.features.screenshot;
using Good_screenshot.user_interface.managers;
using Good_screenshot.user_interface.creators.resources.structs;

namespace Good_screenshot
{
    internal class Main : Script
    {
        public Main()
        {
            var settings
                = new Settings();

            //var customSpriteManager
            //    = new CustomSpriteManager();

            //var customSprite
            //    = customSpriteManager
            //          .ReturnAnCustomSpriteWithThis(
            //              new StCustomSpriteConfiguration()
            //              {
            //                  Size 
            //                  = settings
            //                      .ReturnTheCustomSizeOfTheDefaultLayoutImage(),
                      
            //                  Position 
            //                  = settings
            //                      .ReturnThePositionOfCenterOfScreen(),
                  
            //                  Color
            //                  = settings
            //                      .ReturnTheColorOf("Custom Sprite"),
                  
            //                  Filename
            //                  = settings
            //                      .PathToTheDefaultLayoutImage
            //              });

            Tick += (o, e) =>
            {
                if (Game.WasCheatStringJustEntered("ScreenshotSequence();"))
                {
                    using (var screenshot = new Screenshot())
                    {
                        Main
                            .Yield();

                        screenshot
                            .MakeAnSequenceOfScreenshots(amount  : 5, 
                                                         interval: 5000);

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

                //customSprite.ScaledDraw();
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
