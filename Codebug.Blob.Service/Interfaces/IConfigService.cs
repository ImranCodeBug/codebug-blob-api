namespace Codebug.Blob.Services.Interfaces
{
    public interface IConfigService
    {
        T GetValueFromConfigOrDefault<T>(string key);
    }
}
