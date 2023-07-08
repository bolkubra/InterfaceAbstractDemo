using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbuckCustomerManager : BaseCustomerManager    //, ICustomerCheckService diyerek implemente edilebilir ama;


    {
       private ICustomerCheckService _customerCheckService;

        public StarbuckCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        //    ICustomerService // customer içindeki save operasyonunu kullanmak için implement ettik
        //
        //    public void Save(Customer customer)
        //    {
        //        throw new NotImplementedException();
        //    }
        //

        public override void Save(Customer customer )
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer); // veritabanına kaydeden kod
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
            
        }

        //private void CheckIfRealPerson(Customer customer)
        //{
        //    throw new NotImplementedException();
        //} // sadece star istese kodumuzu buraya yazabilirdik ama sonra nreo da kontrol isterse interface oluşturudk oraya koplayadık
    }
}
