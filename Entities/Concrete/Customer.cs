using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerTC { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CoffeeShopId { get; set; }
        public virtual CoffeeShop CoffeeShop { get; set; }
        public int CustomerScore { get; set; }
        public DateTime CustomerBirthdate { get; set; }
    }
}
