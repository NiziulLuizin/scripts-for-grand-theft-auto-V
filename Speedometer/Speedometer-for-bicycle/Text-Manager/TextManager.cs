using GTA;
using GTA.UI;
using System;
using System.Windows.Forms;
using System.IO;

namespace Speedometer_for_bicycle.Text_Manager
{
    internal class TextManager : Script
    {
        internal static float ptfX = 0f;
        internal static float ptfY = 0f;

        internal static float szX = 0f;
        internal static float szY = 0f;

        static float velocity;

        private bool isEditorModeEnabled = false;
        public TextManager()
        {
            Tick += (o, e) =>
            {
                if (isEditorModeEnabled)
                    drawInfos();
            };

            KeyDown += (o, e) =>
            {
                if(isEditorModeEnabled)
                {
                    if (e.KeyCode == Keys.Up)
                        ptfY -= 1 + velocity;
                    else if (e.KeyCode == Keys.Down)
                        ptfY += 1 + velocity;

                    if (e.KeyCode == Keys.Left)
                        ptfX -= 1 + velocity;
                    else if (e.KeyCode == Keys.Right)
                        ptfX += 1 + velocity;
                }

                if (e.KeyCode == Keys.OemQuotes)
                {
                    var Input = Game.GetUserInput();

                    if (Input == "SavePosition")
                        SaveConfigOfPosition();
                    else if (Input == "SaveSize")
                        SaveConfigOfSize();
                    else if (Input == "EditModeOn")
                        isEditorModeEnabled = true;
                    else if (Input == "EditModeOff")
                        isEditorModeEnabled = false;
                }

                if (e.KeyCode == Keys.Oemplus)
                    velocity += 1;
                else if (e.KeyCode == Keys.OemMinus)
                    velocity -= 1;
            };
        }

        void SaveConfigOfPosition()
        {
            using (var ConfigPosition = new StreamWriter(GetRelativeFilePath("Image\\ConfigPosition.txt")))
                ConfigPosition.WriteLine($"Position X: {ptfX} Position Y: {ptfY}");
        }

        void SaveConfigOfSize()
        {
            using (var ConfigPosition = new StreamWriter(GetRelativeFilePath("Image\\ConfigSize.txt")))
                ConfigPosition.WriteLine($"Size X: {szX} Size Y: {szY}");
        }

        static string ReturnWhatYouReadInTheLegacy(string path)
        {
            using (var FileContent = new StreamReader(path))
                return FileContent.ReadToEnd();
        }

        void drawInfos()
        {
            var InformationGroup = new TextElement($"Position X: ~r~{ptfX}~w~ Position Y: ~r~{ptfY}~w~ Velocity: ~r~{velocity}~w~", new System.Drawing.PointF(200f, 200f), 0.40f);
            InformationGroup.Draw();
        }
    }
}
