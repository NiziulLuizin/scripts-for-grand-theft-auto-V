using GTA.UI;

using Good_screenshot.user_interface.creators.resources.structs;


namespace Good_screenshot.user_interface.creators
{
    internal abstract class CustomSpriteCreator
    {
        protected CustomSprite CreateAndReturnAnCustomSpriteWithThis(StCustomSpriteConfiguration stCustomSpriteConfiguration)
        {
            return _
                   = new CustomSprite(stCustomSpriteConfiguration
                                                            .Filename,
                                      stCustomSpriteConfiguration
                                                            .Size,
                                      stCustomSpriteConfiguration
                                                            .Position,
                                      stCustomSpriteConfiguration
                                                            .Color);
        }
    }
}
