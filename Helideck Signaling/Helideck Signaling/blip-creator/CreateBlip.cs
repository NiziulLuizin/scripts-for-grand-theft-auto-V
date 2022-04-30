using GTA;
using GTA.Math;
using System.Collections.Generic;

namespace Helideck_Signaling.blip_creator
{
    class CreateBlip
    {
        private readonly string[] modelHelipad =
        {
            "prop_helipad_01",
            "prop_helipad_02"
        };


        private List<HelipadBlip> Helipads
        { get; set; }

        public CreateBlip()
        {
            Helipads = 
                new List<HelipadBlip>();
        }
        public CreateBlip(Vector3[] positions) : this()
        {
            foreach (var position in positions)
            {
                Helipads.Add(new HelipadBlip(position));
            }

            CheckIfThereAreNewHelipadsOnTheMapAndIfSoAddBlip();
        }

        private void CheckIfThereAreNewHelipadsOnTheMapAndIfSoAddBlip()
        {
            foreach (var prop in World.GetAllProps())
            {
                if (prop.Model == modelHelipad[0] ||
                    prop.Model == modelHelipad[1])
                {
                    Helipads.Add(new HelipadBlip(prop.Position));
                }
            }
            foreach (var build in World.GetAllBuildings())
            {
                if (build.Model == modelHelipad[0] ||
                    build.Model == modelHelipad[1])
                {
                    Helipads.Add(new HelipadBlip(build.Position));
                }
            }
        }

        internal void MakeTheHelipadBlipInvisible()
        {
            foreach (var helipad in Helipads)
            {
                if (!helipad.IsShortRange())
                {
                    helipad.MakeTheBlipInvisibleOnTheMinimap();
                }
            }
        }
        internal void MakeTheHelipadBlipVisibleOnTheMinimapAtLongDistances()
        {
            var waypointPosition = World.WaypointPosition;

            foreach (var helipad in Helipads)
            {
                if (helipad.Position.X == waypointPosition.X &&
                    helipad.Position.Y == waypointPosition.Y &&
                    helipad.IsShortRange())
                {
                    helipad.MakeTheBlipVisibleOnTheMinimap();
                    World.WaypointBlip.IsShortRange = true;
                }
            }
        }

        internal bool IsEmpty() => Helipads.Count == 0;
        internal void ClearsTheMapLeavingOnlyTheSelectedBlips()
        {
            foreach (var helipadBlip in Helipads)
            {
                if (helipadBlip.IsShortRange())
                {
                    helipadBlip.Delete();
                }
            }
        }
        internal void Delete()
        {
            foreach (var blip in Helipads)
            {
                blip.Delete();
            }
        }
    }
}