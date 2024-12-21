using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FirstProjectCozaStore.Models;


namespace FirstProjectCozaStore.DAL
{
    internal interface IDataAccesLayer
    {
        List<Category> GetCategories();
        List<Product> GetProducts(); 
    }
}
