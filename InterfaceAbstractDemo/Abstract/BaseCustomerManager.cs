using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class   BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) // tamamlanmış kod // virtual ben bunu ezebilirim demek
        {
            Console.WriteLine("save to db " + customer.FirstName);
        }
    }
}
