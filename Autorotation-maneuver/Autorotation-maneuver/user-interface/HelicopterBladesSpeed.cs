using GTA;

using Autorotation_maneuver.user_interface.managers;


namespace Autorotation_maneuver.user_interface
{
    internal sealed class HelicopterBladesSpeed : Script
    {
        public HelicopterBladesSpeed()
        {
            var oneTime = 
                true;


            Tick    += (o, e) =>
            {
                var isInLoading =
                    Game
                        .IsLoading;

                switch (isInLoading)
                {
                    case true:
                        {
                            return;
                        }
                    case false:
                        {
                            if (oneTime)
                            {
                                var containerElementManager =
                                    new ContainerElementManager();

                                var customSpriteManager =
                                    new CustomSpriteManager();

                                var textElementManager =
                                    new TextElementManager();


                                Wait(1000);

                                containerElementManager
                                    .ReturnContainerElement();

                                Wait(1000);

                                customSpriteManager
                                    .ReturnCustomSprite();
                                
                                Wait(1000);

                                textElementManager
                                    .ReturnTextElement();



                                oneTime =
                                    false;
                            }
                        }
                        return;
                }

                
            };

            Aborted += (o, e) =>
            {

            };
        }
    }
}
