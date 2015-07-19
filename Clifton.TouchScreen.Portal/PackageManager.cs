using System;
using System.Collections.Generic;
using System.Text;

namespace Clifton.TouchScreen.Portal {
    internal sealed class PackageAuthor {
        private int id;
        private string name;
        private string country;
        private DateTime registrationDate;
    }

    internal sealed class Package {
        private Guid guid;
        private Version version;
        private PackageAuthor author;
        private DateTime expirationDate;
        //maybe have a package purchase obj...
        private DateTime purchaseDate;
    }

    internal sealed class PackageManager {
        private string username;
        private string password;

        public void CheckForUpdates(string accountName) {

        }

        public List<Package> GetRegisteredPackages() {
            return null;
        }
    }
}