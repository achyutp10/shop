using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetPoductsAsync();
        Task<Product?> GetProductByIdAsync(int id);  
        
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        bool ProductExists(int id);

        Task<bool> SaveChangesAsync();
    }
}
