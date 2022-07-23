using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    public class Product
    {
        Dictionary<string,double> _products;
        public Product()
        {
            _products = new Dictionary<string, double>();
            _products.Add("Cola",1.00);
            _products.Add("Chips",0.50);
            _products.Add("Candy",0.65);
        }
        public Dictionary<string,double> GetProducts()
        {
            return _products;
        }

    }
}
