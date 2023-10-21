using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IProductService
    {
        int GetCount();
        Product[] Search(string searchText);
        Product[] GetAll();
        decimal GetAveragePrice();

        Product[] OrderByDate();
        Product[] GetAllByCategoryName(string categoryName);

        Product[] GetAllByCategoryId(int id);


    }
}
