using Domain.Contracts;
using Domain.Database;
using Infrastructure.Repository.Interface;
using Infrastructure.GenericRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CustomerRepository : GenericRepository<Customer, string> , ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        //public async Task<IEnumerable<Customer>> GetPagedList(int pageSize, int pageNumber)
        //{
        //    string parameter = "%Aung Aung%";
        //    IEnumerable<Customer> result;
        //    try
        //    {
        //        string query = $"SELECT {ALL_COLUMNS_PROPERTY} FROM {TABLE_NAME} WHERE Name LIKE @Name";

        //        result = await GetPagedList(query, new { Name = parameter }, pageSize, pageNumber);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error fetching records from db: ${ex.Message}");
        //        throw new Exception("Unable to fetch data. Please contact the administrator.");
        //    }
        //    finally
        //    {
        //        _connection.Close();
        //    }
        //    return result;

        //}
    }
}
