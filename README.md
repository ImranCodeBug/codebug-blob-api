# Welcome to codebug-blob-api

an application that creates a blob with metadata in azure. The metadata is a `Dictionary<string, sting>` object that can store additional information for the blob

## Caution and Usage
The solution has some unit and integrations tests hosted in `Codebug.Blob.Service.Tests` project. Under Constant folder I have listed the secret of the blob store. I have not checked in the file as it contains secrets for storage accounts. The tests without the file will not work. 

below is the file as example

```
namespace Codebug.Blob.Services.Tests.Constants
{
    public static class BlobStorageConstants
    {
        public const string BlobConnectionString = "<EXAMPLE>";
        public const string ContainerName = "<EXAMPLE>";
    }
}

```
