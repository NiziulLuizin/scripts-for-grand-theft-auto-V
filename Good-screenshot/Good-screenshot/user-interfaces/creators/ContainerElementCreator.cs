using GTA.UI;

using Good_screenshot.user_interfaces.creators.resources.structs;

namespace Good_screenshot.user_interfaces.creators
{
    internal abstract class ContainerElementCreator
    {
        protected ContainerElement CreateAndReturnAnContainerWithThis(StContainerElementConfiguration stContainerElementConfiguration)
        {
            return _
                   = new ContainerElement(stContainerElementConfiguration
                                                                    .Position,
                                          stContainerElementConfiguration
                                                                    .Size,
                                          stContainerElementConfiguration
                                                                    .Color);
        }
    }
}