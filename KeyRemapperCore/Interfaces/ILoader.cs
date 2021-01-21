namespace KeyRemapperCore.Interfaces
{
    public interface ILoader
    {
        void Save(ProfilesManager manager);
        ProfilesManager Load();
    }
}
