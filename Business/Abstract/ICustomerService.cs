﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void AddWithMernis(Customer customer);


    }
}
