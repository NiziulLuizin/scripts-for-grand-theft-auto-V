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

            var isInVehicle =
                    character
                        .IsSittingInVehicle();


            switch (isInVehicle)
            {
                case true:
                    {
                        var minimapVisibility =
                            Hud
                                .IsRadarVisible;

                        if (minimapVisibility)
                            return;
                        else
                            Hud
                                .IsRadarVisible = true;
                    }
                    break;
                case false:
                    {
                        var minimapVisibility =
                            Hud
                                .IsRadarVisible;

                        if (minimapVisibility)
                            return;
                        else
                            Hud
                                .IsRadarVisible = false;
                    }
                    break;
            }
        }
    }
}
