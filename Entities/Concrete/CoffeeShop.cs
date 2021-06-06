using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CoffeeShop:IEntity
    {
        public int CoffeeShopId { get; set; }
        public string CoffeeShopName { get; set; }
        public virtual List<Customer> Customer { get; set; }
        public bool CheckMernis { get; set; }
    }
}
