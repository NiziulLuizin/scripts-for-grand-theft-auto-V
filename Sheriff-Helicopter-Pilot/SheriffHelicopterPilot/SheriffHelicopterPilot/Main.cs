using GTA;
using SheriffHelicopterPilot.Creating.Helicopters;

namespace SheriffHelicopterPilot
{
    public class Main : Script
    {
        public Main()
        {
            var target = "https://www.gta5-mods.com/vehicles/as-350-ecureuil";
            var ecureuil = new Ecureuil();

            ecureuil.Generate();

            Tick += (o, e) =>
            {
            };

            Aborted += (o, e) =>
            {
                ecureuil.Delete();
            };

            KeyUp += (o, e) =>
            {
                if (e.KeyCode is System.Windows.Forms.Keys.Y)
                    System.Diagnostics.Process.Start(target);
            };
        }
    }
}
