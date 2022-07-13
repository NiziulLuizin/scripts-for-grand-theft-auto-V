using GTA;
using GTA.UI;


namespace Autorotation_maneuver
{
    internal sealed class Main : Script
    {
        private string _caption;

        public Main()
        {
            var containerElement =
                new ContainerElement(new System.Drawing
                                                    .PointF(20f, 671.5f), 
                                     new System.Drawing
                                                    .SizeF(400f / 3f, 27f),
                                     System.Drawing
                                                    .Color
                                                        .FromArgb(155, 0, 0, 0));
            _caption =
                "0";


            var textElement =
                new TextElement(_caption, new System.Drawing.PointF((400f / 3f) / 2f, 5f), 0.35f, System.Drawing.Color.White, Font.HouseScript, Alignment.Center, true, false);

            containerElement
                    .Items
                        .Insert(0, textElement);

            var customSprite =
                new CustomSprite($"{GetRelativeFilePath("AutorotationManeuver\\UserInterfaceResources\\CustomSprite\\DefaultLayout.png")}", new System.Drawing.SizeF(400f / 3f, 152f / 3f), new System.Drawing.PointF(20f, 650f), System.Drawing.Color.FromArgb(255, 255, 0, 0));

            Tick += (o, e) =>
            {
                Start();

                textElement
                    .Caption = _caption;

                containerElement
                    .ScaledDraw();

                customSprite
                    .ScaledDraw();
            };

            Aborted += (o, e) =>
            {
                Finish();
            };
        }

        private void Start()
        {
            var player =
                Game
                    .Player
                        .Character;

            var playerIsInVehicleWithRotatingWings =
                player
                    .IsInHeli;

            switch (playerIsInVehicleWithRotatingWings)
            {
                case true:
                    {
                        var vehiclePlayer =
                            player
                                .CurrentVehicle;

                        var isEngineRunning =
                            vehiclePlayer
                                .IsEngineRunning;

                        _caption =
                            (vehiclePlayer
                                .HeliBladesSpeed * 100f)
                                                    .ToString("N0");

                        if (isEngineRunning)
                        {
                            return;
                        }
                        else
                        {
                            var heliBladesSpeed =
                                vehiclePlayer
                                    .HeliBladesSpeed;

                            var isTheHelicopterInFlight =
                                vehiclePlayer
                                    .IsInAir;


                            if (isTheHelicopterInFlight
                                    &&
                                heliBladesSpeed < 1.35f)
                            {
                                var controlVehicleFlyThrottleUpIsPressed =
                                    Game
                                        .IsControlPressed(Control
                                                            .VehicleFlyThrottleUp);

                                var controlVehicleFlyThrottleDownIsPressed =
                                    Game
                                        .IsControlPressed(Control
                                                            .VehicleFlyThrottleDown);


                                if (!controlVehicleFlyThrottleUpIsPressed 
                                        &&
                                    !controlVehicleFlyThrottleDownIsPressed)
                                {
                                    var vehicleSpeed =
                                            vehiclePlayer
                                                    .Speed;

                                    vehiclePlayer
                                        .HeliBladesSpeed += 0.00050f * (vehicleSpeed / 10.0f);

                                    return;
                                }


                                switch (controlVehicleFlyThrottleUpIsPressed)
                                {
                                    case true:
                                        {
                                            var vehicleSpeed =
                                                vehiclePlayer
                                                        .Speed;

                                            vehiclePlayer
                                                .HeliBladesSpeed += 0.00150f * (vehicleSpeed / 50.0f);
                                        }
                                        return;
                                }
                                
                                switch (controlVehicleFlyThrottleDownIsPressed)
                                {
                                    case true:
                                        {
                                            var vehicleSpeed =
                                                vehiclePlayer
                                                        .Speed;

                                            vehiclePlayer
                                                .HeliBladesSpeed += 0.00100f * (vehicleSpeed / 10.0f);
                                        }
                                        return;
                                }
                            }
                        }
                    }
                    return;
            }
        }
        private void Finish()
        {

        }
    }
}