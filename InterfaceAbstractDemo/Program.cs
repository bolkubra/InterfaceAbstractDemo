using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adepters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbuckCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer {DateOfBirth = new System.DateTime (1997,8,20), FirstName="kübra", LastName="bol", NationalityId="51220571306"});
            Console.ReadLine();
        }
    }
}
