using System.Drawing;

namespace Good_screenshot.user_interface.creators.resources.interfaces
{
    internal interface IConfiguration
    {
        Color Color
        { get; set; }

        Point Position
        { get; set; }
    }
}