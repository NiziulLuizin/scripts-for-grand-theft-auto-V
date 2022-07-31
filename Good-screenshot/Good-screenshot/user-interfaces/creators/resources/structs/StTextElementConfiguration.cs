using System.Drawing;

using Good_screenshot.user_interfaces.creators.resources.interfaces;


namespace Good_screenshot.user_interfaces.creators.resources.structs
{
    internal struct StTextElementConfiguration : IConfiguration
    {
        public Color Color
        { get; set; }

        public Point Position
        { get; set; }

        internal float Scale
        { get; set; }

        internal string Caption
        { get; set; }
    }
}
