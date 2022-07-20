using GTA;
using GTA.UI;
using GTA.Math;
using GTA.Native;

using Control 
      = GTA.Control;

using System.Windows.Forms;



namespace Invite_for_a_ride
{
    internal sealed class Main : Script
    {
        private readonly Ped _player;

        public Main()
        {
            _player
                = Game
                    .Player
                        .Character;

            var cheatCode
                = new[]
                {
                    "Let's go for a ride!",
                    "Bye guys!"
                };

            Tick += (o, e) =>
            {
                if (!Game
                        .IsLoading)
                {
                    if (Game.WasCheatStringJustEntered(cheatCode[0]))
                    {
                        Notification
                            .Show(message: $"~b~InviteTheNearbyPedestrian~w~();",
                                  blinking: true);

                        InviteTheNearbyPedestrian();
                    }

                    if (Game.WasCheatStringJustEntered(cheatCode[1]))
                    {
                        Notification
                            .Show(message: $"~b~DismissThePedestrian~w~();",
                                  blinking: true);

                        DismissThePedestrian();
                    }
                }
            };

            KeyUp += (o, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.I:
                        {
                        }
                        break;
                    case Keys.P:
                        {
                        }
                        break;
                }
            };
        }

        private void DismissThePedestrian()
        {
            var pedGroup
                = _player
                    .PedGroup;

            var members
                = pedGroup
                    .ToArray(false);

            foreach (var member in members)
            {
                member
                    .LeaveGroup();

                member
                    .Task
                        .WanderAround();

                member
                    .MarkAsNoLongerNeeded();
            }
        }

        private void InviteTheNearbyPedestrian()
        {
            var closestPeds
                = ReturnThePedestriansNearThePlayer();

            var isTherePedestrianNearby
                = closestPeds != null;
            
            if (isTherePedestrianNearby)
            {
                foreach (var ped in closestPeds)
                {
                    AddToTheGroupOfThePlayerThis(ped);
                }
            }
        }

        private Ped[] ReturnThePedestriansNearThePlayer()
        {
            var position
                = _player
                    .FrontPosition;

            var radius
                = 3f;

            return _ 
                   = World
                        .GetNearbyPeds(position,
                                       radius);
        }
        private void AddToTheGroupOfThePlayerThis(Ped pedestrian)
        {
            if (pedestrian == _player)
                return;

            pedestrian
                .Task
                    .ClearAll();

            _player
                .PedGroup
                    .Add(ped   : pedestrian,
                         leader: false);

            AddBlipToThis(pedestrian);
        }
        private void AddBlipToThis(Ped pedestrian)
        {
            pedestrian
                .AddBlip();

            var attachedBlip
                = pedestrian
                    .AttachedBlip;

            attachedBlip
                .Scale
                    = 0.65f;

            attachedBlip
                .Color
                     = BlipColor
                            .Blue;
        }
    }
}
