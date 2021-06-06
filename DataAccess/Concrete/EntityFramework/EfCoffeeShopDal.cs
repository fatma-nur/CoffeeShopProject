using System.Collections.Generic;
using System.Linq;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCoffeeShopDal : EfEntityRepositoryBase<CoffeeShop, CoffeeShopContext>, ICoffeeShopDal
    {
        public bool CheckMernisByShop(string coffeeShopName)
        {
            using (var context = new CoffeeShopContext())
            {
                var result = (from c in context.CoffeeShop
                             where c.CoffeeShopName == coffeeShopName
                             select c.CheckMernis);
                if (result.Contains(true))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

