using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Clifton.TouchScreen {
    internal class ImageWrapper {
        public Image image;
        public DateTime loadedTime;
        public int sizeInBytes;
    };

    public static class ImageCache {
        private static CacheSingleton<Image> imageCache;
        private static int maxSizeInMegabytes = 100;
        private static int currentSizeInBytes = 0;

        public static float CurrentSizeInBytes {
            get { return (float)currentSizeInBytes; }
        }
        public static float CurrentSizeInKilobytes {
            get { return currentSizeInBytes / 1024.0f; }
        }
        public static float CurrentSizeInMegabytes {
            get { return currentSizeInBytes / 1024000.0f; }
        }
        public static int MaxSizeInMegabytes {
            get { return maxSizeInMegabytes; }
        }

        static ImageCache() {
            imageCache = CacheSingleton<Image>.GetInstance();
            imageCache.OnCallFactory += new CacheableObjectFactory(ImageCache_OnCallFactory);
        }

        private static object ImageCache_OnCallFactory(string cacheInformation) {
            Image i = Image.FromFile(cacheInformation);
            currentSizeInBytes += (i.Size.Height * i.Size.Width * 3);
            return i;
        }

        public static Image Load(string path) {
            if (string.IsNullOrWhiteSpace(path)) { 
                return null;
            }

            return imageCache.Load(path);
        }
    }
}