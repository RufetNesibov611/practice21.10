using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AppDbContext
    {
        public Category[] Categories()
        {
            return new Category[]
            {
                new Category{ Id = 1, Name = "Phone"},
                new Category{ Id = 2, Name = "Tv"},
                new Category{ Id = 3, Name = "Console"},
                new Category{ Id = 4, Name = "Computer"},
            };
        }
        public  Product[] Products()
        {
            return new Product[]
            {
              new Product { Id = 1,Name = "Iphone 15", Price = 3500, CreateDate= new DateTime(2023,05,15), Category = Categories().FirstOrDefault(m =>m.Id == 1) },
              new Product { Id = 2,Name = "Iphone 14", Price = 3000, CreateDate= new DateTime(2023,03,15), Category =  Categories().FirstOrDefault(m =>m.Id == 1) },
              new Product { Id = 3,Name = "Samsung 7V", Price = 2500, CreateDate= new DateTime(2022,05,15), Category =  Categories().FirstOrDefault(m =>m.Id == 2)},
              new Product { Id = 4,Name = "Sony PC", Price = 500, CreateDate= new DateTime(2020,05,15), Category = Categories().FirstOrDefault(m =>m.Id == 3)},

            };
        }
    }
}
