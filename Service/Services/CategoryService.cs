using Domain.Data;
using Domain.Models;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService()
        {
            _context = new AppDbContext();
        }

        public Category[] GetAll()
        {
            return _context.Categories();
        }
    }
}
