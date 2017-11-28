using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.NorthWindDataSetTableAdapters;
using System.Data;

namespace ClassLibrary1
{
    public class ClsNorthWind
    {
        //global::ClassLibrary1.NWDataSetTableAdapters.ProductsTableAdapter 參考全名
        static ProductsTableAdapter adapter = new ProductsTableAdapter();
        
        static CategoriesTableAdapter categories = new CategoriesTableAdapter();
        static NorthWindDataSet nwd = new NorthWindDataSet();



        public ClsNorthWind()
        {
            adapter.Fill(nwd.Products);
            categories.Fill(nwd.Categories);
            
        }

        public  DataTable GetProducts()
        {
            return nwd.Products;
        }

        public DataTable GetName(string Name)
        {
            adapter.FillByProductName(nwd.Products, Name);
            return nwd.Products;
        }

        public DataTable GetProductUnitPrice(int PriceA, int PriceB)
        {
            adapter.FillByUnitPrice(nwd.Products, PriceA, PriceB);
            return nwd.Products;
             
        }

        public DataTable Categories()
        {
            return nwd.Categories;
        }
    }
}
