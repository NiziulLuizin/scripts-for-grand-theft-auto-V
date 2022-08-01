using GTA;

using GTA.UI;

using System;

using System.IO;

using System.Drawing;


namespace Good_screenshot.settings
{
    internal sealed class Settings
    {
        internal string PathToTheGoodScreenshotFolder
        {
            get
            {
                return _
                       = Directory
                            .GetCurrentDirectory()
                         +
                         @"\scripts\GoodScreenshot\";
            }
        }
        internal string PathToTheDefaultLayoutImage
        {
            get
            {
                return _
                       = PathToTheGoodScreenshotFolder
                         +
                         @"\UserInterfaceResources\CustomSprite\DefaultLayout.png";
            }
        }
        
        internal string PathToDisplayCompatibilityFile
        {
            get
            {
                return _
                       = PathToTheGoodScreenshotFolder
                         +
                         @"\UserInterfaceResources\DisplayCompatibility.ini";
            }
        }
        internal string PathToBehaviorOfUserInterfaceElementsFile
        {
            get
            {
                return _
                       = PathToTheGoodScreenshotFolder
                         +
                         @"\BehaviorOfUserInterfaceElements.ini";
            }
        }
        
        internal Boolean ReturnTheInterfaceVisibility()
        {
            var behaviorOfUserInterfaceElementsFile
                = ScriptSettings
                    .Load(PathToBehaviorOfUserInterfaceElementsFile);

            var interfaceVisibility
                = false;

            var section
                = "Interface Visibility";

            var key
                = "_";

            var value
                = behaviorOfUserInterfaceElementsFile
                    .GetAllValues<string>(section,
                                          key)[0];

            if (value != null 
                &&
                value == "On")
            {
                interfaceVisibility
                = true;
            }

            return interfaceVisibility;
        }

        internal Point ReturnThePositionOfCenterOfScreen()
        {
            var displayCompatibility 
                = ScriptSettings
                    .Load(PathToDisplayCompatibilityFile);

            var aspectRatio 
                = Screen
                    .AspectRatio;

            var screenCompatibility 
                = displayCompatibility
                    .GetAllValues<string>(section: "Compatibility",
                                          name   : $"{aspectRatio}")[0];

            var screenCenterPosition 
                = displayCompatibility
                    .GetAllValues<string>(section: screenCompatibility,
                                          name   : "Screen Center Position")[0];

            return _ 
                   = new Point(x: int
                                    .Parse(screenCenterPosition),
                               y: 0);
        }
        internal Point ReturnTheCustomPositionOfCenterOfScreen()
        {
            var positionOfCenterOfScreen 
                = ReturnThePositionOfCenterOfScreen();

            return _
                   = new Point(x: positionOfCenterOfScreen
                                                         .X,
                               y: 50);
        }
        
        internal Size ReturnTheSizeOfTheDefaultLayoutImage()
        {
            var sizeOfDefaultLayoutImage 
                = new Size();

            using (var defaultLayoutImage = Image
                                                .FromFile(PathToTheDefaultLayoutImage))
            {
                sizeOfDefaultLayoutImage 
                = defaultLayoutImage
                                    .Size;
            }
            

            return sizeOfDefaultLayoutImage;
        }
        internal Size ReturnTheCustomSizeOfTheDefaultLayoutImage()
        {
            var sizeOfDefaultLayoutImage
                = ReturnTheSizeOfTheDefaultLayoutImage();

            return _
                   = new Size(width: sizeOfDefaultLayoutImage
                                                        .Width / 2,
                              height: sizeOfDefaultLayoutImage
                                                        .Height / 2);
            
        }
        
        internal Color ReturnTheColorOf(string section)
        {
            var behaviorOfUserInterfaceElementsFile
                = ScriptSettings
                    .Load(PathToBehaviorOfUserInterfaceElementsFile);

            var keys 
                = new[]
                {
                    "Color - A",
                    "Color - R",
                    "Color - G",
                    "Color - B"
                };

            var unconvertedColor
                = new string[4];

            var convertedColor
                = new byte[4];

            for (var i = (byte)0; i < keys
                                        .Length; i++)
            {
                unconvertedColor
                [i] = behaviorOfUserInterfaceElementsFile
                        .GetAllValues<string>(section, 
                                              keys[i])[0];

                convertedColor
                [i] = byte
                        .Parse(unconvertedColor[i]);
            }

            return _
                   = Color
                        .FromArgb(alpha: convertedColor[0],
                                  red  : convertedColor[1],
                                  green: convertedColor[2],
                                  blue : convertedColor[3]);
        }
    }
}
