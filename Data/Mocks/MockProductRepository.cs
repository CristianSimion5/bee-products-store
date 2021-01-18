using System.Collections.Generic;
using System.Linq;
using Polifloris.Data.Interfaces;
using Polifloris.Models;

namespace Polifloris.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository;

        public MockProductRepository(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }
        public Product GetProductById(int productId)
        {
            return new Product { 
                Name = "Miere de salcâm",
                ShortDescription = "Miere de salcâm",
                LongDescription = "Miere de salcam provenita din Romania",
                Price = 20,
                ImageUrl = "~/images/miere_salcam.jpg",
                ImageThumbnailUrl = "~/thumbnails/miere_salcam_thn.jpg",
                InStock = false,
                Category = _categoryRepository.GetCategories().ToList()[0],
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { 
                    Name = "Miere de salcâm",
                    ShortDescription = "Miere de salcâm",
                    LongDescription = "Miere de salcam provenita din Romania",
                    Price = 20,
                    ImageUrl = "~/images/miere_salcam.jpg",
                    ImageThumbnailUrl = "~/thumbnails/miere_salcam_thn.jpg",
                    InStock = false,
                    Category = _categoryRepository.GetCategories().ToList()[0],
                },
                new Product { 
                    Name = "Miere poliflora",
                    ShortDescription = "Miere poliflora",
                    LongDescription = "Miere poliflora provenita din Romania",
                    Price = 15,
                    ImageUrl = "~/images/miere_poliflora.jpg",
                    ImageThumbnailUrl = "~/thumbnails/miere_poliflora_thn.jpg",
                    InStock = true,
                    Category = _categoryRepository.GetCategories().ToList()[0],
                },
            };
        }
    }
}