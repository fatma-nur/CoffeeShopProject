using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        private ICustomerDal _customerDal;
        public bool checkSave;

        public CustomerManager(ICustomerCheckService customerCheckService, ICustomerDal customerDal)
        {
            _customerCheckService = customerCheckService;
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);

        }

        public void AddWithMernis(Customer customer)
        {
           
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                _customerDal.Add(customer);
                checkSave = true;
            }
            else
            {
                checkSave = false;
            }
        }
    }
}
