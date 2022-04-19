using GTA;
using GTA.Math;

namespace Helideck_Signaling.blip_creator
{
    class HelipadBlip
    {
        /*
             #1: bigCircleOutline
             #2: theJewelStoreJob
        */

        private Blip[] blips = new Blip[2];
        private float[] blipSize =
        {
            0.40f,
            0.30f
        };
        private BlipColor[] blipColor =
        {
            BlipColor.Yellow6,
            BlipColor.White
        };
        private BlipSprite[] blipSprite =
        {
            BlipSprite.SonicWave,
            BlipSprite.TheJewelStoreJob
        };
        private BlipDisplayType[] displayType =
        {
            BlipDisplayType.BothMapNoSelectable,
            BlipDisplayType.BothMapSelectable
        };

        public HelipadBlip(Vector3 position)
        {
            for (int i = 0; i < 2; i++)
            {
                blips[i] = World.CreateBlip(position);
            }

            DefaultSettingForBlips();
        }

        void DefaultSettingForBlips()
        {
            DefaultSettingForBlipOne();
            DefaultSettingForBlipTwo();
        }
        void DefaultSettingForBlipOne()
        {
            blips[0].Sprite =
                blipSprite[0];
            
            blips[0].Name =
                "Helipad";

            blips[0].Color =
                blipColor[0];

            blips[0].Scale =
                blipSize[0];

            blips[0].IsShortRange =
                true;

            blips[0].DisplayType =
                displayType[0];
        }
        void DefaultSettingForBlipTwo()
        {
            blips[1].Sprite =
                blipSprite[1];
            
            blips[1].Name =
                "Helipad";

            blips[1].Color =
                blipColor[1];

            blips[1].Scale =
                blipSize[1];


            blips[1].IsShortRange =
                true;

            blips[1].DisplayType =
                displayType[1];
        }


        internal void MakeTheBlipVisibleOnTheMinimap()
        {
            blips[1].IsShortRange = false;
        }

        internal void Delete()
        {
            foreach (var blip in blips)
                blip.Delete();
        }
    }
}