using GTA;
using SheriffHelicopterPilot.Helipad.Location;
using SheriffHelicopterPilot.Vehicles.Helicopters;

namespace SheriffHelicopterPilot.Creating.Helicopters
{
    sealed class Ecureuil
    {
        Vehicle helicopter;

        internal void Generate()
        {
            helicopter = World.CreateVehicle(SheriffHelicopter.Ecureuil,
                                             SheriffHelipad.HelipadPosition,
                                             SheriffHelipad.HelipadOrientation);

            helicopter.PlaceOnGround();

            helicopter.Mods.Livery = 2;
            helicopter.IsPersistent = true;

            helicopter.LodDistance = helicopter.LodDistance;
            helicopter.LockStatus = VehicleLockStatus.PlayerCannotEnter;
        }

        internal void Delete()
        {
            if (helicopter.Exists())
            {
                helicopter.Delete();
            }
        }
    }
}
