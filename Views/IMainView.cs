using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models;

namespace TeaShop.Views
{
    public interface IMainView
    {
        void DisplayProducts(List<Product> products);
        void UpdateCart(List<Product> cart, decimal total);
        void UpdateCustomerInfo(decimal cashBalance, decimal cardBalance, decimal bonuses);
        void DisplayProductImage(Image image);  
        void DisplayProductPrice(decimal price);  
    }
}
