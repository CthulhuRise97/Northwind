using Northwind.Models;
using System.Collections.Generic;

namespace Northwind.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        IEnumerable<Customer> CustomersPagedList(int page, int rows);
    }
}
