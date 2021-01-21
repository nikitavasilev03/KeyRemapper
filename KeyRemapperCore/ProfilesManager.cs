using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRemapperCore
{
    [Serializable]
    public class ProfilesManager
    {
        private string currentProfile = "";

        public List<Profile> Profiles { get; } = new List<Profile>();
        public Profile CurrentProfile
        {
            get
            {
                return Profiles.FirstOrDefault(p => p.Name == currentProfile);
            }
            set
            {
                if (Profiles.Contains(value))
                    currentProfile = value.Name;
            }
        }

        public bool AddProfile(Profile profile)
        {
            if (Profiles.Count(p => p.Name == profile.Name) > 0)
                return false;
            Profiles.Add(profile);
            return true;
        }

        public Profile AddProfile(string name)
        {
            Profile profile = new Profile(name);
            if (AddProfile(profile))
                return profile;
            return null;
        }

        public bool RemoveProfile(Profile profile)
        {
            if (Profiles.Count(p => p.Name == profile.Name) == 0)
                return false;
            Profiles.Remove(profile);
            return true;
        }

        public bool RemoveProfile(string name)
        {
            Profile profile = Profiles.FirstOrDefault(p => p.Name == name);
            if (profile == null)
                return false;
            return RemoveProfile(profile);
        }
    }
}
