using Speedometer.Directory_Manager.Settings;

namespace Speedometer.Directory_Manager
{
    abstract class DirectoryManager : DirectorySetup, System.IDisposable
    {
        protected static string[] ReturnThePathOfTheItemsPresentInThe(string folder)
        {
            return System.IO.Directory.GetFiles(folder, "*.png");
        }

        protected virtual string GiveMeThePathOfThis(ushort item)
        { throw new System.NotImplementedException(); }
        protected virtual string GiveMeThePathOfThis(ushort item, string type)
        { throw new System.NotImplementedException(); }
        protected virtual string GiveMeTheNameOfThis(ushort item)
        { throw new System.NotImplementedException(); }
        protected virtual string GiveMeTheNameOfThis(ushort item, string type)
        { throw new System.NotImplementedException(); }

        public virtual void Dispose()
        { throw new System.NotImplementedException(); }
    }
}