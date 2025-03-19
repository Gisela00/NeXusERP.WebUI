using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) => _context = context;

        public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products.ToListAsync();
       
        public Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
