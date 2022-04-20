using GTA;
using GTA.Math;
using System.Collections.Generic;

namespace Helideck_Signaling.blip_creator
{
    class CreateBlip
    {
        protected List<HelipadBlip> Helipads
        { get; private set; }

        public CreateBlip()
        {
            Helipads = new List<HelipadBlip>();
        }
        public CreateBlip(Vector3[] positions)
            : this()
        {
            foreach (var position in positions)
                Helipads.Add(new HelipadBlip(position));
        }

        internal void MakeTheHelipadBlipVisibleOnTheMinimapAtLongDistances()
        {
            foreach (var helipad in Helipads)
            {
                if (helipad.Position.X == World.WaypointPosition.X &&
                    helipad.Position.Y == World.WaypointPosition.Y &&
                    helipad.IsTheBlipShortRange())
                {
                    helipad.MakeTheBlipVisibleOnTheMinimap();
                    World.WaypointBlip.IsShortRange = true;
                }
            }
        }
        internal void MakeTheHelipadBlipInvisible()
        {
            foreach (var helipad in Helipads)
            {
                if (!helipad.IsTheBlipShortRange())
                {
                    helipad.MakeTheBlipInvisibleOnTheMinimap();
                }
            }
        }
        internal bool IsEmpty() => Helipads.Count == 0;
        internal void Delete()
        {
            foreach (var blip in Helipads)
                blip.Delete();
        }
    }
}