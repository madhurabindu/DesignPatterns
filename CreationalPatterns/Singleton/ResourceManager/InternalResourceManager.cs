using System;
using System.Collections.Generic;
using System.Drawing;
using Base.Interfaces;

namespace Imp.ResourceManagerImpl
{
    internal class InternalResourceManager : IResourceManager
    {
        Dictionary<string, Image> imageMap;
        /// <summary>
        /// Pre loading the resources. Can also be lazy loaded like in GetImageFromPath function
        /// </summary>
        public void LoadResources()
        {
            imageMap.Add("logox32", new Bitmap("./Resources/logo32.png"));
            imageMap.Add("logox64", new Bitmap("./Resources/logo64.png"));
        }

        public void CloseRsources()
        {
        }


        public Image GetImage(string imageId)
        {
            return imageMap.ContainsKey(imageId) ? imageMap[imageId] : null;
        }

        /// <summary>
        /// This can be improved to add error handling etc.
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        public Image GetImageFromFile(string imagePath)
        {
            Image image = null;
            if (imageMap.ContainsKey(imagePath))
            {
                image = imageMap[imagePath];
            }
            else
            {
                image = new Bitmap(imagePath);
                imageMap[imagePath] = image;
            }

            return image;
        }

        public string GetString(string id)
        {
            return string.Format("Returning Text for ID: {0}", id);
        }
    }
}
