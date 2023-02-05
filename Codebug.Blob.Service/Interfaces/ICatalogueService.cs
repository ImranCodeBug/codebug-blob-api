namespace Codebug.Blob.Services.Interfaces
{
    public interface ICatalogueService
    {
        Task SaveFileAsync(string base64String, string fileName, 
            Dictionary<string, string> metaInformation);
    }
}
