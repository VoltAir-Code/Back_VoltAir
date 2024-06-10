using Azure.Storage.Blobs;

namespace VoltAir.Utils.BlobStorage
{
    public static class AzureBlobStorage
    {
        public static async Task<string> UploadImageBlobAsync(IFormFile file, string connectionString, string containerName)
        {
            try
            {
                if (file != null)
                {
                    var blobName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);

                    var blobServiceClient = new BlobServiceClient(connectionString);

                    var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);


                    var blobClient = blobContainerClient.GetBlobClient(blobName);

                    using (var stream = file.OpenReadStream())
                    {
                        await blobClient.UploadAsync(stream, true);

                    }
                    return blobClient.Uri.ToString();
                }
                else
                {
                    return "https://voltairestorage.blob.core.windows.net/blobvoltaire/default.png";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
