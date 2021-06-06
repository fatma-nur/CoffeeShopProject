using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CoffeeShopManager : ICoffeeShopService
    {
        ICoffeeShopDal _coffeeShopDal;
        public CoffeeShopManager(ICoffeeShopDal coffeeShopDal)
        {
            _coffeeShopDal = coffeeShopDal;
        }
        public bool CheckMernisByShop(string coffeeShopName)
        {
            return _coffeeShopDal.CheckMernisByShop(coffeeShopName);
        }

        public List<CoffeeShop> GetCoffeeShops()
        {
            return new List<CoffeeShop>(_coffeeShopDal.GetList().ToList());
        }
    }
}
