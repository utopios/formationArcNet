using System;
using System.Collections.Generic;
using MediatorImplementationCRM.Models;

namespace MediatorImplementationCRM.Repositories
{
    public class CustomerRespository : IRepository<Customer>
    {
        public Customer Create(Customer element)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> FindAllBy(Func<Customer, bool> Search)
        {
            throw new NotImplementedException();
        }
    }
}