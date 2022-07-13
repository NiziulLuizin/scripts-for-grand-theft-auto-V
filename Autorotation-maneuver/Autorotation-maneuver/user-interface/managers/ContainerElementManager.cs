using GTA.UI;

using Autorotation_maneuver.user_interface.creators;


namespace Autorotation_maneuver.user_interface.managers
{
    internal sealed class ContainerElementManager : ContainerElementCreator
    {
        internal void ReturnContainerElement()
        {
            Notification
                .Show($"~y~Container Element Create~w~!", true);
        }
    }
}
