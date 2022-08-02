//using Good_screenshot.settings;
//using Good_screenshot.user_interfaces.creators.resources.structs;
//using Good_screenshot.user_interfaces.managers;
//using GTA;

//namespace Good_screenshot.user_interfaces
//{
//    internal sealed class UserInterfaces : Script
//    {
//        public UserInterfaces()
//        {
//            var settings
//                = new Settings();

//            var customSpriteManager
//                = new CustomSpriteManager();

//            var customSprite
//                = customSpriteManager
//                    .ReturnAnCustomSpriteWithThis(
//                        new StCustomSpriteConfiguration()
//                        {
//                            Filename
//                            = settings
//                                .PathToTheDefaultLayoutImage,

//                            Size
//                            = settings
//                                .ReturnTheCustomSizeOfTheDefaultLayoutImage(),

//                            Position
//                            = settings
//                                .ReturnTheCustomPositionOfCenterOfScreen(),

//                            Color
//                            = settings
//                                .ReturnTheColorOf("Custom Sprite")
//                        });

//            customSprite
//                .Centered = false;

//            Tick    += (o, e) =>
//            {
//                customSprite
//                    .ScaledDraw();
//            };

//            Aborted += (o, e) =>
//            {

//            };
//        }
//    }
//}
