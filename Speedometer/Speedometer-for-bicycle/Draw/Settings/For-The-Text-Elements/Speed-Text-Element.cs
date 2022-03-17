﻿using Speedometer_for_bicycle.Draw.Text_Element.Speed.In;
using System.Drawing;
using GTA;

namespace Speedometer_for_bicycle.Draw.Settings.For_The_Text_Elements
{
    internal class Speed_Text_Element
    {
        internal static float Scale
        {
            get { return 0.50f; }
        }
        internal static Color Color
        {
            get { return Color.White; }
        }
        internal static GTA.UI.Font Font
        {
            get { return GTA.UI.Font.Monospace; }
        }
        internal static PointF Position
        {
            get { return new PointF(644f, 662f); }
        }
        internal static GTA.UI.Alignment Alignment
        {
            get { return GTA.UI.Alignment.Center; }
        }

        internal static string CorrectSpeed
        {
            get
            {
                return (Game.MeasurementSystem == MeasurementSystem.Metric) ? SpeedIn.KilometersPerHour() : SpeedIn.MilesPerHour();
            }
        }
    }
}
