using GTA;
using GTA.Math;

namespace Waypoint_marked_with_laser.adjustments_for_the_laser_beam
{
    class LaserStructure
    {
        private Vector3 _position =
            new Vector3();

        private Prop[] _laserStructures =
            new Prop[2];

        private readonly string[] _modelNameLaser =
        {
            "xs_prop_arena_barrel_01a_sf",
            "xs_prop_arena_bollard_side_01a_sf"
        };



        public LaserStructure() { }

        internal void CreateTheLaserStructure()
        {
            _position =
                World.WaypointPosition;

            var hasPhysics =
                true;

            var IsToStayOnTheGround =
                false;

            var laserHeight =
                new Vector3(_position.X,
                            _position.Y,
                            _position.Z + 2000f);


            _laserStructures[0] =
                World
                    .CreateProp(_modelNameLaser[1],
                                laserHeight,
                                hasPhysics,
                                IsToStayOnTheGround);

            _laserStructures[1] =
                World
                    .CreateProp(_modelNameLaser[0],
                                laserHeight,
                                hasPhysics,
                                IsToStayOnTheGround);


            BasicLaserStructureSettings();
        }
        private void BasicLaserStructureSettings()
        {
            var rotation =
                new Vector3(x: 0.20512519f,
                            y: 179.459076f,
                            z: 101.254494f);

            var relativeRotation =
                new Vector3(x: 0f,
                            y: 2.49999976f,
                            z: -0.399999976f);


            _laserStructures[1].Rotation =
                rotation;

            _laserStructures[0]
                .AttachTo(_laserStructures[1],
                          relativeRotation);
        }
        internal void DestroyTheLaserStructure()
        {
            foreach (var laserStructure in _laserStructures)
            {
                if (laserStructure != null)
                {
                    laserStructure.Delete();
                }
            }
        }
    }
}
