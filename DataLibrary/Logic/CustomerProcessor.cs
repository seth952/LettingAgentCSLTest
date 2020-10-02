using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class CustomerProcessor
    {
        public static int CreateCustomer(string firstName, string lastName, string emailAddress)
        {
            Customer data = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Customer (FirstName, LastName, EmailAddress)
                            values (@FirstName, @LastName, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<Customer> LoadCustomers()
        {
            string sql = @"select Id, FirstName, LastName, EmailAddress
                        from dbo.Customer;";

            return SqlDataAccess.LoadData<Customer>(sql);
        }

    }
}
