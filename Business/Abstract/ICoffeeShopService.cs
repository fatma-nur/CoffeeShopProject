using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICoffeeShopService
    {
        bool CheckMernisByShop(string coffeeShopName);
        List<CoffeeShop> GetCoffeeShops();
    }
}
