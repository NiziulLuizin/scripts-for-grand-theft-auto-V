using System.Drawing;

using System.Windows.Forms;

using GTAScreen 
      = GTA.UI.Screen;


namespace Good_screenshot.features.screenshot.creators.resources.structs
{
    struct StResources
    {
        internal Screen MainScreen
        { 
            get
            {
                var primaryScreen
                    = Screen
                            .PrimaryScreen;

                return _
                       =
                       primaryScreen;
            }
        }

        internal Size CurrentResolution
        {
            get
            {
                var resolution
                    = GTAScreen
                            .Resolution;

                return _
                       =
                       resolution;
            }
        }
    }
}
