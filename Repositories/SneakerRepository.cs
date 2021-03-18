using System;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Data;
using backend_herhaling_sneakers.Models;

namespace backend_herhaling_sneakers.Repositories
{
    public interface ISneakerRepository
    {
        Task<Sneaker> AddSneaker(Sneaker sneaker);
        Task<Image> AddSneakerImage(Image image);
    }

    public class SneakerRepository : ISneakerRepository
    {
        private ISneakerContext _context;
        public SneakerRepository(ISneakerContext context)
        {
            _context = context;
        }

        public async Task<Sneaker> AddSneaker(Sneaker sneaker)
        {
            try
            {
                sneaker.SneakerId = Guid.NewGuid();
                await _context.Sneakers.AddAsync(sneaker);
                await _context.SaveChangesAsync();
                return sneaker;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<Image> AddSneakerImage(Image image)
        {
            try
            {
                image.ImageId = Guid.NewGuid();
                await _context.Images.AddAsync(image);
                await _context.SaveChangesAsync();
                return image;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
