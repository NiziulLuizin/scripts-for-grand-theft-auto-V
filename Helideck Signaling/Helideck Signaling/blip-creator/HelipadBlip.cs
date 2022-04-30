using GTA;
using GTA.Math;
using GTA.Native;

namespace Helideck_Signaling.blip_creator
{
    class HelipadBlip
    {
        /*
             #1: sonicWave
             #2: theJewelStoreJob
        */
        internal Vector3 Position
        { get; private set; }

        internal readonly Blip[] blips = new Blip[2];


        private readonly float[] blipScale =
        {
            0.40f,
            0.30f
        };
        private readonly string[] colorCode =
        {
            "~w~",  // HUD_COLOUR_WHITE
            "~y~", // HUD_COLOUR_YELLOW
            "~b~" // HUD_COLOUR_BLUE
        };
        private readonly BlipColor[] blipColor =
        {
            BlipColor.Yellow,
            BlipColor.White
        };
        private readonly BlipSprite[] blipSprite =
        {
            BlipSprite.SonicWave,
            BlipSprite.TheJewelStoreJob
        };
        private readonly BlipDisplayType[] displayType =
        {
            BlipDisplayType.BothMapNoSelectable,
            BlipDisplayType.BothMapSelectable
        };
        private readonly BlipCategoryType[] categoryType =
        {
            BlipCategoryType.Property,
            BlipCategoryType.OwnedProperty
        };

        public HelipadBlip(Vector3 position)
        {
            Position = position;

            MakerBlip();
        }

        private void MakerBlip()
        {
            for (var i = 0; i < 2; i++)
            {
                blips[i] = World.CreateBlip(Position);
            }

            DefaultSettingForBlips();
        }

        void DefaultSettingForBlips()
        {
            var colorId = 
                setup_manager.SettingColor.ColorId;

            var isShortRange = 
                true;

            var formattingCodes = 
                "~italic~";

            var zoneLocalizedName =
                World.GetZoneLocalizedName(Position);

            var nameOfHelipadLocation =
                $"{colorCode[2]}Helipad{colorCode[0]} - {colorCode[1] + formattingCodes + zoneLocalizedName}";

            for (var i = 0; i < 2; i++)
            {
                blips[i].Sprite =
                    blipSprite[i];

                blips[i].Scale =
                    blipScale[i];

                blips[i].Color =
                    blipColor[i];

                blips[i].DisplayType =
                    displayType[i];

                blips[i].CategoryType =
                    categoryType[i - i];

                blips[i].IsShortRange =
                    isShortRange;

                blips[i].Name =
                    nameOfHelipadLocation;
            }
            SetBlipColor(blips[0], colorId);
        }

        void SetBlipColor(Blip blip, int color)
        {
            Function.Call(Hash.SET_BLIP_COLOUR, blip, color);
        }
        internal void MakeTheBlipVisibleOnTheMinimap()
        {
            for (var i = 0; i < 2; i++)
            {
                blips[i].IsShortRange = false;
            }
        }
        internal void MakeTheBlipInvisibleOnTheMinimap()
        {
            for (var i = 0; i < 2; i++)
            {
                blips[i].IsShortRange = true;
            }
        }
        internal bool IsShortRange() => blips[0].IsShortRange;
        internal void Delete()
        {
            foreach (var blip in blips)
            {
                if (blip != null)
                {
                    blip.Delete();
                }
            }
        }
    }
}