using Speedometer.Managers.Directory_Manager.Settings;

namespace Speedometer.Managers.Directory_Manager
{
    abstract class DirectoryManager : DirectorySetup
    {
        protected string[] ReturnThePathOfTheItemsPresentInThe(string folder)
        {
            return System.IO.Directory.GetFiles(folder, "*.png");
        }
        protected virtual string GiveMeThis(string sprite)
        { throw new System.NotImplementedException(); }
    }
}