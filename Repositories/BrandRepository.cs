using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Data;
using backend_herhaling_sneakers.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_herhaling_sneakers.Repositories
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetBrands();
    }

    public class BrandRepository : IBrandRepository
    {
        private ISneakerContext _context;

        public BrandRepository(ISneakerContext context)
        {
            _context = context;
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _context.Brands.ToListAsync();
        }

    }
}
