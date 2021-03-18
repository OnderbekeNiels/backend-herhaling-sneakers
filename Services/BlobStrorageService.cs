using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage;
using Azure.Core;
using Azure.Storage.Blobs;
using backend_herhaling_sneakers.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace backend_herhaling_sneakers.Services
{
    public interface IBlobStrorageService
    {
        Task UploadImage(byte[] imageFile, string imageName, string containerName);
    }

    public class BlobStrorageService : IBlobStrorageService
    {
        private readonly BlobServiceClient _blobServiceClient;
        public BlobStrorageService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task UploadImage(byte[] imageFile, string imageName, string containerName)
        {
            // try{
            //     BlobStrorage.CloudStorageAccount = Blob
            // }catch{

            // }

        }

    }
}
