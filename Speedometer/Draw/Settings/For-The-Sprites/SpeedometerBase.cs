using System.Drawing;
using Speedometer.Directory_Manager.Content;

namespace Speedometer.Draw.Settings.For_The_Sprites
{
    internal abstract class SpeedometerBase : BaseForSpeedometerFolder
    {    
        protected SizeF GiveMeTheCorrectSizeThe(ushort baseSpeedometer)
        {
            using (var _ = Image.FromFile(GiveMeTheCorrectFilenameThe(baseSpeedometer)))
                return new SizeF(_.Size.Width / 5, _.Size.Height / 5);
        }
        protected PointF GiveMeTheCorrectPositionThe(ushort baseSpeedometer)
        {
            return new PointF(840f, 650f);
        }
        protected string GiveMeTheCorrectFilenameThe(ushort baseSpeedometer)
        {
            return GiveMeThePathOfThis(baseSpeedometer);
        }
    }
}
