using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.Data.ModalEntity;

namespace Test.Data
{
    public static class UserService
    {

        public static async Task<User> GetUserAsync(int id)
        {
            await using var context = new BookmakerContext();

            return await context.Users.FirstAsync(user => user.Id == id);
        }
        public static User GetUser(int id)
        {
            using var context = new BookmakerContext();

            return context.Users.First(user => user.Id == id);
        }
    }
}
