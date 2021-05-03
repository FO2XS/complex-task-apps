using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;

namespace Test.Data
{
    public class FormattingUserBets
    {
        private static readonly WebService Service = new WebService();
        private static HashSet<Team> _teams = Service.GetTeams();
        private static HashSet<TypeOfBet> _typeOfBets = Service.GetTypeOfBets();
        private HashSet<PossibleBet> _possibleBets;
        private HashSet<Event> _events;


        public FormatUserBets Format (IEnumerable<UserBet> userBets)
        {
            var possibleId = new HashSet<int>();
            foreach (var bet in userBets)
            {
                possibleId.Add(bet.IdPosBet);
            }

            _possibleBets = Service.GetPossibleBets(possibleId);

            var eventsId = new HashSet<int>();
            foreach (var possibleBet in _possibleBets)
            {
                eventsId.Add(possibleBet.IdEvent);
            }

            _events = Service.GetEvents(eventsId);

            HashSet<FormatUserBets> formattingUserBets = new HashSet<FormatUserBets>();


            foreach (var userBet in userBets)
            {
                var posbet = _possibleBets.First(e => e.Id == userBet.IdPosBet);
                var eEvent = _events.First(e => e.Id == posbet.IdEvent);
                var tob = _typeOfBets.First(e => e.Id == posbet.IdTob);
                var teams1 = _teams.First(e => e.Id == eEvent.IdTeam1);
                var teams2 = _teams.First(e => e.Id == eEvent.IdTeam2);



                formattingUserBets.Add(new FormatUserBets(userBet));

                formattingUserBets.Last().View = $"{teams1.Title}vs{teams2.Title} Вид ставки:{tob.Title} "
            }
        }

        public class FormatUserBets : UserBet
        {
            public string View { get; set; }

            public FormatUserBets(UserBet userBet)
            {
                this.Id = userBet.Id;
                this.IdPosBet = userBet.IdPosBet;
                this.Coef = userBet.Coef;
                this.IdPosBetNavigation = userBet.IdPosBetNavigation;
                this.IdUser = userBet.IdUser;
                this.IdUserNavigation = userBet.IdUserNavigation;
                this.Prize = userBet.Prize;
                this.ToArchive = userBet.ToArchive;
                this.Sum = userBet.Sum;
                this.Victory = userBet.Victory;
            }
        }
    }
}
