﻿using GTA.UI;

using Autorotation_maneuver.user_interface.creators;


namespace Autorotation_maneuver.user_interface.managers
{
    internal sealed class TextElementManager : TextElementCreator
    {
        internal void ReturnTextElement()
        {
            Notification
                .Show($"~y~Text Element Create~w~!", true);
        }
    }
}
