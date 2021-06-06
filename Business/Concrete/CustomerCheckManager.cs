using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
               (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.CustomerTC), customer.CustomerName,
               customer.CustomerSurname, customer.CustomerBirthdate.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
