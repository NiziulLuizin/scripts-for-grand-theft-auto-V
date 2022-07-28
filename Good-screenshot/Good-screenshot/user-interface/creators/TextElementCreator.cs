﻿using GTA.UI;

using Good_screenshot.user_interface.creators.resources.structs;


namespace Good_screenshot.user_interface.creators
{
    internal abstract class TextElementCreator
    {
        protected TextElement CreateAndReturnAnTextElementWithThis(StTextElementConfiguration stTextElementConfiguration)
        {
            return _
                   = new TextElement(stTextElementConfiguration
                                                        .Caption,
                                     stTextElementConfiguration
                                                        .Position,
                                     stTextElementConfiguration
                                                        .Scale,
                                     stTextElementConfiguration
                                                        .Color);
        }
    }
}
