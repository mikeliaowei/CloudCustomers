using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new()
                {
                    Id = 1,
                    Name = "Test User 1",
                    Address = new Address()
                    {
                        Street = "123 Main St",
                        City = "Madison",
                        ZipCode = "21345"
                    },
                    Email = "test.user.1@example.com"
                },

                new()
                {
                    Id = 2,
                    Name = "Test User 2",
                    Address = new Address()
                    {
                        Street = "456 Main St",
                        City = "Madison",
                        ZipCode = "12345"
                    },
                    Email = "test.user.2@example.com"
                },

                new()
                {
                    Id = 3,
                    Name = "Test User 3",
                    Address = new Address()
                    {
                        Street = "789 Main St",
                        City = "Madison",
                        ZipCode = "12345"
                    },
                    Email = "test.user.3@example.com"
                }

            };
    }
}
