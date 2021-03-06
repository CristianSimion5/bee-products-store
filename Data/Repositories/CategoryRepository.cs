﻿using Polifloris.Data.Interfaces;
using Polifloris.Models;
using System.Collections.Generic;
using System.Linq;

namespace Polifloris.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
