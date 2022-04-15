using GTA;
using Speedometer.Draw.Sprites.CurrentSpeedometer;
using Speedometer.Draw.Text_Element.Speed;
using System.Drawing;

namespace Speedometer
{
    public class Main : Script
    {
        public Main()
        {
            var offset =
                new SizeF(1f, 1f);
            var sizeRpm =
                new SizeF(0f, 4f);
            var scaleToCurrentGear =
                0.50f;

            var positionToRmp =
                new PointF(755f, 674.5f);
            var positionToCurrentGear =
                new PointF(923f, 611f);
            var positionToSpeedometerBase =
                new PointF(845f, 650f);

            string[] spriteImage =
            {
                "Base-Rpm-Default.png",
                "Base-Speedometer-type-1.png"
            };


            var Rpm = new CurrentSpeedometer();
            var RpmSprite = Rpm.GettingThe(spriteImage[0]);
            RpmSprite.Color = Color.FromArgb(255, 0, 255, 71);
            RpmSprite.Centered = false;
            RpmSprite.Position = positionToRmp;

            var fullRpm =
                Rpm.GettingSizeF().Width;

            var SpeedometerBase = new CurrentSpeedometer().GettingThe(spriteImage[1]);
            SpeedometerBase.Position =
                            positionToSpeedometerBase;

            var CurrentGear =
                new GTA.UI.TextElement(string.Empty, positionToCurrentGear, scaleToCurrentGear)
                { Color = Color.White, Outline = true, Centered = true };

            GTA.Prop.
            
            Tick += (o, e) =>
            {
                if (!Game.IsLoading)
                {
                    if (Game.Player.Character.IsInVehicle())
                    {
                        CurrentGear.Caption = Game.Player.Character.CurrentVehicle.CurrentGear.ToString();

                        var CurrentRpm = Game.Player.Character.CurrentVehicle.CurrentRPM;

                        if (CurrentRpm < 0.68f)
                        {
                            RpmSprite.Color = Color.FromArgb(255, 0, 255, 71);
                        }
                        else if (CurrentRpm > 0.68f && CurrentRpm < 0.91f)
                        {
                            RpmSprite.Color = Color.FromArgb(255, 250, 255, 0);
                        }
                        else if (CurrentRpm > 0.91)
                        {
                            RpmSprite.Color = Color.FromArgb(255, 255, 0, 0);
                        }


                        RpmSprite.Size = new SizeF(CurrentRpm * fullRpm, RpmSprite.Size.Height);


                        if (!Game.Player.Character.CurrentVehicle.IsEngineRunning)
                        {
                            RpmSprite.Size = new SizeF(0f, RpmSprite.Size.Height);
                        }

                        Speed
                        .CurrentSpeed(offset);
                        CurrentGear
                        .ScaledDraw(offset);
                        SpeedometerBase
                        .ScaledDraw(offset);
                        RpmSprite
                        .ScaledDraw(offset);
                    }
                }
            };
        }
    }
}
