using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using KeyRemapperCore;
using KeyRemapperCore.Exceptions;
using KeyRemapperCore.Interfaces;

namespace KeyRemapper
{
    public class ProfilesLoader : ILoader
    {
        public string Folder { get; set; }
        public string FileName { get; set; }

        public void Save(ProfilesManager manager)
        {
            try
            {
                if (!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                }

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(Folder + FileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, manager);
                }
            }
            catch (Exception e)
            {
                throw new ProfileSaveException(e.Message);
            }
        }

        public ProfilesManager Load()
        {
            try
            {
                object obj;
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(Folder + FileName, FileMode.OpenOrCreate))
                {
                    obj = formatter.Deserialize(fs);
                }
                return obj as ProfilesManager;
            }
            catch (Exception)
            {
                throw new ProfileLoadException("Данные не найдены");
            }
            
        }
    }
}
