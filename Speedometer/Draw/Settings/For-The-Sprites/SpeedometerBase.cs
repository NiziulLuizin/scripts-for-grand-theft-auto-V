using Speedometer.Managers.Directory_Manager.Content;
using System.Drawing;

namespace Speedometer.Draw.Settings.For_The_Sprites
{
    internal abstract class SpeedometerBase : BaseForSpeedometerFolder
    {
        protected SizeF CorrectSizeThe(string baseSpeedometer)
        {
            using (var _ = Image.FromFile(CorrectFilenameThe(baseSpeedometer)))
                return new SizeF(_.Size.Width / 4.5f, _.Size.Height / 4.5f);
        }
        protected string CorrectFilenameThe(string baseSpeedometer)
        {
            return GiveMeThis(baseSpeedometer);
        }
        protected PointF CorrectPositionThe()
        {
            return new PointF(840f, 650f);
        }
    }
}
