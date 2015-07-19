using System;
using System.Collections.Generic;

namespace Clifton.TouchScreen {
    public delegate object CacheableObjectFactory(string cacheInformation);

    public sealed class CacheSingleton<T> where T : class {
        private static CacheSingleton<T> instance = null;
        private Dictionary<string, T> hashMap = new Dictionary<string, T>();
        public event CacheableObjectFactory OnCallFactory = null;

        /// <summary>
        /// Dispose of the singleton instance.
        /// </summary>
        public static void DisposeInstance() {
            if (typeof(T) is IDisposable) {
                IDisposable garbage = instance as IDisposable;
                if (garbage != null) {
                    garbage.Dispose();
                    instance = null;
                }
            }
        }

        /// <summary>
        /// Get a reference to the singleton instance.
        /// </summary>
        public static CacheSingleton<T> GetInstance() {
            if (instance != null) {
                return instance;
            }

            instance = new CacheSingleton<T>();

            return instance;
        }

        private CacheSingleton() { }

        private T Factory(string cacheInformation) {
            if (OnCallFactory != null) {
                return OnCallFactory(cacheInformation) as T;
            }

            return null;
        }

        public T Load(string hashValue) {
            T tType;
            bool bSuccess;

            //try to get value from hashmap
            lock (hashMap) {
                bSuccess = hashMap.TryGetValue(hashValue, out tType);
            }

            //if is not found, load and cache
            if (!bSuccess) {
                tType = Factory(hashValue);
                lock (hashMap) {
                    hashMap[hashValue] = tType;
                }
            }

            return tType;
        }

        public void Refresh() {
            lock (hashMap) {
                //get each namespace
                List<string> CurrentNamespaces = new List<string>();

                foreach (string key in hashMap.Keys) {
                    CurrentNamespaces.Add(key);
                }

                //clear the cache
                hashMap.Clear();

                //reload each document using docfactory
                foreach (string key in CurrentNamespaces) {
                    hashMap[key] = Factory(key);
                }
            }
        }
    }
}
