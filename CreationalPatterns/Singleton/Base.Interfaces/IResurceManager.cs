using System;
using System.Drawing;

namespace Base.Interfaces
{
    public interface IResourceManager
    {
        void LoadResources();

        Image GetImage(string imageId);

        Image GetImageFromFile(string imagePath);

        string GetString(string id);

        void CloseRsources();
    }
}
