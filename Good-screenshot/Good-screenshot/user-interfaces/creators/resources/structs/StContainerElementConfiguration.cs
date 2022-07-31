using System.Drawing;

using Good_screenshot.user_interfaces.creators.resources.interfaces;


namespace Good_screenshot.user_interfaces.creators.resources.structs
{
    internal struct StContainerElementConfiguration : IConfiguration
    {
        public Size Size
        { get; set; }

        public Color Color
        { get; set; }

        public Point Position
        { get; set; }
    }
}
