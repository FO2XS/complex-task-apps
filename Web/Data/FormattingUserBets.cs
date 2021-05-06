using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;

namespace Test.Data
{
    public class FormattingUserBets
    {
        private static readonly WebService Service = new();
        private static HashSet<Team> _teams = Service.GetTeams();
        private static HashSet<TypeOfBet> _typeOfBets = Service.GetTypeOfBets();
        private HashSet<PossibleBet> _possibleBets;
        private HashSet<Event> _events;


        public HashSet<FormatUserBets> Format (IEnumerable<UserBet> userBets)
        {
            var formattingUserBets = new HashSet<FormatUserBets>();
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

            foreach (var userBet in userBets)
            {
                var posbet = _possibleBets.FirstOrDefault(e => e.Id == userBet.IdPosBet);
                var eEvent = _events.FirstOrDefault(e => e.Id == posbet.IdEvent);
                var tob = _typeOfBets.FirstOrDefault(e => e.Id == posbet.IdTob);
                var teams1 = _teams.FirstOrDefault(e => e.Id == eEvent.IdTeam1);
                var teams2 = _teams.FirstOrDefault(e => e.Id == eEvent.IdTeam2);



                formattingUserBets.Add(new FormatUserBets(userBet));

                formattingUserBets.Last().ViewEvent = $"{teams1.Title} vs {teams2.Title}";
                formattingUserBets.Last().ViewBet = tob.Title;
            }

            return formattingUserBets;
        }

        
    }
    public class FormatUserBets : UserBet
    {
        public string ViewEvent { get; set; }
        public string ViewBet { get; set; }
        public string ViewMoney { get; set; }

        public FormatUserBets(UserBet userBet)
        {
            this.Id = userBet.Id;
            this.IdPosBet = userBet.IdPosBet;
            this.Side = userBet.Side;
            this.Coef = userBet.Coef;
            this.IdUser = userBet.IdUser;
            this.Prize = userBet.Prize;
            this.ToArchive = userBet.ToArchive;
            this.Sum = userBet.Sum;
            this.Victory = userBet.Victory;
            this.ViewMoney = $"{Sum} * {Coef}";
        }
    }
}
