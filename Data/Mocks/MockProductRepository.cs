using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public IEnumerable<Product> Find(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            return new Product { 
                Name = "Miere de salcâm",
                Description = "Miere de salcâm",
                Price = 20,
                ImageUrl = "~/images/miere_salcam.jpg",
                ImageThumbnailUrl = "/images/thumbnails/miere_salcam_thn.jpg",
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
                    Description = "Miere de salcâm",
                    Price = 20,
                    ImageUrl = "~/images/miere_salcam.jpg",
                    ImageThumbnailUrl = "/images/thumbnails/miere_salcam_thn.jpg",
                    InStock = false,
                    Category = _categoryRepository.GetCategories().ToList()[0],
                },
                new Product { 
                    Name = "Miere poliflora",
                    Description = "Miere poliflora",
                    Price = 15,
                    ImageUrl = "~/images/miere_poliflora.jpg",
                    ImageThumbnailUrl = "/images/thumbnails/miere_poliflora_thn.jpg",
                    InStock = true,
                    Category = _categoryRepository.GetCategories().ToList()[0],
                },
                new Product {
                    Name = "Miere de salcâm",
                    Description = "Miere de salcâm",
                    Price = 20,
                    ImageUrl = "~/images/miere_salcam.jpg",
                    ImageThumbnailUrl = "/images/thumbnails/miere_salcam_thn.jpg",
                    InStock = false,
                    Category = _categoryRepository.GetCategories().ToList()[0],
                },
                new Product {
                    Name = "Miere de salcâm",
                    Description = "Miere de salcâm",
                    Price = 20,
                    ImageUrl = "~/images/miere_salcam.jpg",
                    ImageThumbnailUrl = "/images/thumbnails/miere_salcam_thn.jpg",
                    InStock = false,
                    Category = _categoryRepository.GetCategories().ToList()[0],
                }
            };
        }
    }
}