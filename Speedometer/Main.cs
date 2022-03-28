using GTA;
using Speedometer.Draw.Sprites.CurrentSpeedometer;
using System.Drawing;

namespace Speedometer
{
    public class Main : Script
    {
        public Main()
        {
            ///
            ///string pathOfIcon;
            ///
            ///SizeF currentSizeOfIcons;

            string[] type =
            {
                "Simple",
                "Metric",
                "Imperial"
            };

            ///using (var _ = new SpeedometerIconsFolder())
            ///pathOfIcon = _.GiveMeThePathOfThis(icon: 3, type[1]);

            ///using (var _ = Bitmap.FromFile(pathOfIcon))
            ///currentSizeOfIcons = _.Size;

            ///var correntPointF = 
            ///new PointF(840f, 650f);

            ///var iconsSprites =
            ///new CustomSprite(pathOfIcon, new SizeF(currentSizeOfIcons.Width / 6, currentSizeOfIcons.Height / 6), correntPointF) { Centered = true };

            var _offset =
                new SizeF(1f, 1f);

            var SpeedometerBase =
                    new CurrentSpeedometer().GettingThe(baseSpeedometer: 3);

            Tick += (o, e) =>
            {
                if (!Game.IsLoading)
                    SpeedometerBase.ScaledDraw(_offset);
            };
        }
    }
}
