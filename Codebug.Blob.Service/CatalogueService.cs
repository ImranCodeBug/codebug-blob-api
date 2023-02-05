using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Codebug.Blob.Services.Interfaces;

namespace Codebug.Blob.Services
{
    public class CatalogueService : ICatalogueService
    {
        private readonly IConfigService _configService;

        public CatalogueService(IConfigService configService)
        {
            _configService = configService;
        }

        public async Task SaveFileAsync(string base64String, string fileName, Dictionary<string, string> metaInformation)
        {
            var client = ConstructBlobClient(fileName);
            var blobUploadOptions = new BlobUploadOptions();
            blobUploadOptions.Metadata = metaInformation;
            

            await client.UploadAsync(base64String, blobUploadOptions);            
        }

        private BlobClient ConstructBlobClient(string fileName)
        {
            var connectionString = _configService.GetValueFromConfigOrDefault<string>("BlobConnectionString");
            var containerName = _configService.GetValueFromConfigOrDefault<string>("BlobContainerName");
            return new BlobClient(connectionString, containerName, fileName);

        }
    }
}