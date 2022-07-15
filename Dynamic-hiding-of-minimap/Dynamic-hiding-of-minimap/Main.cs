using GTA;
using GTA.UI;


namespace Dynamic_hiding_of_minimap
{
    internal sealed class Main : Script
    {
        public Main()
        {
            Interval =
                3500;

            Tick += (o, e) =>
            { Start(); };
        }

        private void Start()
        {
            var character =
                Game
                    .Player
                        .Character;

            var isSittingInVehicle =
                character
                    .IsSittingInVehicle();


            switch (isSittingInVehicle)
            {
                case true:
                    {
                        ShowMinimap();
                    }
                    break;
                case false:
                    {
                        HideMinimap();
                    }
                    break;
            }
        }

        private void HideMinimap()
        {
            MinimapaVisibility(status: false);
        }
        private void ShowMinimap()
        {
            MinimapaVisibility(status: true);
        }
        private void MinimapaVisibility(bool status)
        {
            var minimapVisibility =
                Hud
                    .IsRadarVisible;

            if (minimapVisibility == status)
                return;
            else
                Hud
                    .IsRadarVisible = status;
        }
    }
}
