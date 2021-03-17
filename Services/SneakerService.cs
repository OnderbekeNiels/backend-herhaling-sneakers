using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Models;
using backend_herhaling_sneakers.Repositories;

namespace backend_herhaling_sneakers.Services
{
    public interface ISneakerService
    {
        Task<List<Brand>> GetBrands();
    }

    public class SneakerService : ISneakerService
    {
        private IBrandRepository _brandRepository;

        public SneakerService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _brandRepository.GetBrands();
        }

    }
}
