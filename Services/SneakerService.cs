using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Models;
using backend_herhaling_sneakers.Repositories;
using Microsoft.AspNetCore.Http;

namespace backend_herhaling_sneakers.Services
{


    public interface ISneakerService
    {
        Task<List<Brand>> GetBrands();
        Task<List<Occasion>> GetOccasions();
        Task<Sneaker> AddSneaker(Sneaker sneaker);
        Task AddSneakerImage(Guid sneakerId, IFormFile imageFile);
    }

    public class SneakerService : ISneakerService
    {
        private IBrandRepository _brandRepository;
        private IOccasionRepository _occasionRepository;
        private ISneakerRepository _sneakerRepository;
        private IBlobStrorageService _blobStorageService;

        public SneakerService(IBrandRepository brandRepository, IOccasionRepository occasionRepository, ISneakerRepository sneakerRepository, IBlobStrorageService blobStorageService)
        {
            _brandRepository = brandRepository;
            _occasionRepository = occasionRepository;
            _sneakerRepository = sneakerRepository;
            _blobStorageService = blobStorageService;
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _brandRepository.GetBrands();
        }

        public async Task<List<Occasion>> GetOccasions()
        {
            return await _occasionRepository.GetOccasions();
        }

        public async Task<Sneaker> AddSneaker(Sneaker sneaker)
        {
            return await _sneakerRepository.AddSneaker(sneaker);
        }

        public async Task AddSneakerImage(Guid sneakerId, IFormFile imageFile)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageFile.CopyTo(ms);
                var fileBytes = ms.ToArray();
                string fileName = $"{Guid.NewGuid()}.{imageFile.FileName.Split(".")[1]}";
                await _blobStorageService.UploadImage(fileBytes, fileName, "upload-image");
                await _sneakerRepository.AddSneakerImage(new Image() { SneakerId = sneakerId, Name = fileName });
            }
        }

    }
}
