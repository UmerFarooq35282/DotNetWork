using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using WebGrease.Css.Ast;

namespace BellaShopProject.DALRepo
{
    internal interface IDataAccessLayer
    {

        List<Product> GetProducts(string pro , int catId , int page);

        Product GetProductById(int id);

        List<Product> GetProductByCat(int catId);

        void CreateProduct(Product product);


    }
}
