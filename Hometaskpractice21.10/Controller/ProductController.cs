using Domain.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometaskpractice21._10.Controller
{
     class ProductController
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }
        public void GetCount()
        {
            int count = _productService.GetCount();
            Console.WriteLine(count);
        }

        public void SearchByName()
        {
            Console.WriteLine("Add product search text :");
            string searchText = Console.ReadLine();

            string resSearchText = searchText.Substring(0, 4);
            var result = _productService.Search(searchText);

            foreach ( var item in result )
            {
                string data = $" Name : {item.Name}, Price : {item.Price}, Category : {item.Category.Name}";
                Console.WriteLine(data);
            }
        }

        public void GetAll()
        {
            var result = _productService.GetAll();

            foreach (var item in result)
            {
                string data = $" Name : {item.Name}, Price : {item.Price}, Category : {item.Category.Name}";
                Console.WriteLine(data);
            }
        }
        public void GetAveragePrice()
        {
            var avgPrice = _productService.GetAveragePrice();
            Console.WriteLine(avgPrice);
        }

        public void OrderByDate()
        {
            var result = _productService.OrderByDate();

            foreach (var item in result)
            {
                string data = $" Name : {item.Name}, Price : {item.Price}, Date :{item.CreateDate.ToString("dd-MM-yyyy")}, Category : {item.Category.Name}";
                Console.WriteLine(data);
            }
        }
        public void GetAllByCategoryName()
        {
            Console.WriteLine("Add product category name  :");
            string category = Console.ReadLine();

            var result = _productService.GetAllByCategoryName(category);

            foreach (var item in result)
            {
                string data = $" Name : {item.Name}, Price : {item.Price}, Date :{item.CreateDate.ToString("dd-MM-yyyy")}, Category : {item.Category.Name}";
                Console.WriteLine(data);
            }
        }
        
        public void GetAllByCategoryId()
        {
            Console.WriteLine("Please add product category name  :");
            int categoryId = int.Parse(Console.ReadLine());

            var result = _productService.GetAllByCategoryId(categoryId);
            

            foreach (var item in result)
            {
                string date = $"Name : {item.Name}, Price {item.Price}, Date : {item.CreateDate: dd-MM-yyyy}";
                Console.WriteLine(date);
            }

           
         

        }
    }
}
