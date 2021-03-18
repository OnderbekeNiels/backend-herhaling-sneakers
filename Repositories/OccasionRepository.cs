using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Data;
using backend_herhaling_sneakers.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_herhaling_sneakers.Repositories
{
    public interface IOccasionRepository
    {
        Task<List<Occasion>> GetOccasions();
    }

    public class OccasionRepository : IOccasionRepository
    {
        private ISneakerContext _context;

        public OccasionRepository(ISneakerContext context)
        {
            _context = context;
        }

        public async Task<List<Occasion>> GetOccasions()
        {
            return await _context.Occasions.ToListAsync();
        }
    }
}
