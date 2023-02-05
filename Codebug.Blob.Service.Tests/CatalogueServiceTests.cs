using Codebug.Blob.Services.Interfaces;
using Codebug.Blob.Services.Tests.Constants;
using NSubstitute;
using NUnit.Framework;

namespace Codebug.Blob.Services.Tests
{
    public class CatalogueServiceTests
    {
        private IConfigService _configService;
        private CatalogueService _catalogueService;
        [SetUp]
        public void Init()
        { 
            _configService = Substitute.For<IConfigService>(); 
        }

        [Explicit]
        [Test]
        public async Task SaveFileAsync_SucessFul_WithMetaInformation()
        {
            _configService.GetValueFromConfigOrDefault<string>("BlobConnectionString").Returns(BlobStorageConstants.BlobConnectionString);
            _configService.GetValueFromConfigOrDefault<string>("BlobContainerName").Returns(BlobStorageConstants.ContainerName);


            _catalogueService = new CatalogueService(_configService);

            await _catalogueService.SaveFileAsync(BlobConstructor.FileContent,
                BlobConstructor.FileName, BlobConstructor.MetaInformation);
        }
    }
}
