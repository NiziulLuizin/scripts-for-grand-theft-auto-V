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
                Create(position);
        }

        private void Create(Vector3 position)
        {
            Helipads.Add(new HelipadBlip(position));
        }

        internal bool IsEmpty()
        {
            return Helipads.Count == 0;
        }
        internal void Delete()
        {
            foreach (var blip in Helipads)
                blip.Delete();
        }
    }
}