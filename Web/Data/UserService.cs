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

        public static bool AddMoneyToUser(User user, MoneyManagement operation)
        {
            try
            {
                using var context = new BookmakerContext();

                if (operation.TakeOrAdd)
                {
                    user.Balance -= operation.Sum;
                }
                else
                {
                    user.Balance += operation.Sum;
                }

                context.Entry(user).State = EntityState.Modified;
                context.Entry(operation).State = EntityState.Added;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
