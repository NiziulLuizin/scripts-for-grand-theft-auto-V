using GTA.UI;

using Autorotation_maneuver.user_interface.creators;


namespace Autorotation_maneuver.user_interface.managers
{
    internal sealed class CustomSpriteManager : CustomSpriteCreator
    {
        internal void ReturnCustomSprite()
        {
            Notification
                .Show($"~y~Custom Sprite Create~w~!", true);
        }
    }
}
