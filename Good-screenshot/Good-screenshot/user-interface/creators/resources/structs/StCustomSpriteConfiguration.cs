using System.Drawing;

using Good_screenshot.user_interface.creators.resources.interfaces;


namespace Good_screenshot.user_interface.creators.resources.structs
{
    internal struct StCustomSpriteConfiguration : IConfiguration
    {
        public Size Size
        { get; set; }

        public Color Color
        { get; set; }

        public Point Position
        { get; set; }
        
        internal string Filename
        { get; set; }
    }
}
