using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Test.Data.ModalEntity;

namespace Test.Data
{
    public static class BetsService
    {

        public static PossibleBet GetPossibleBet(int id)
        {
            using var context = new BookmakerContext();
            return context.PossibleBets.First(bet => bet.Id == id);
        }

        public static bool AddUserBet(User user, PossibleBet bet, bool side, float coef,
            decimal sum)
        {
            using var context = new BookmakerContext();
            var userbet = new UserBet()
            {
                IdUser = user.Id,
                IdPosBet = bet.Id,
                Side = side,
                Coef = coef,
                Sum = sum,
                ToArchive = false
            };
            context.UserBets.Add(userbet);
            user.Balance -= sum;
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
    }
}
