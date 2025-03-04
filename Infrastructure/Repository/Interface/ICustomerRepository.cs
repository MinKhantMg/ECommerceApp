using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Domain.Contracts;
using Infrastructure.GenericRepository;

namespace Infrastructure.Repository.Interface
{
    public interface ICustomerRepository : IGenericRepository<Customer,string>
    {
        //Task<IEnumerable<Customer>> GetAll(string orderby);

        //Task<IEnumerable<Customer>> GetPagedList(int pageSize, int pageNumber);

    }
}
