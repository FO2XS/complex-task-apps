using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Npgsql;
using Test.Data;
using Test.Data.ModalEntity;

namespace Test.Pages
{
    public partial class TeamsPage
    {
        //Здесь будет блок с использованием ADO NET через провайдера NPGSQL

        private NpgsqlConnectionStringBuilder builder;
        private List<Team> Teams { get; set; } = new List<Team>();
        private List<Team> VisibleTeams { get; set; }
        private List<Sport> Sports { get; set; } = new List<Sport>()
        {
            new Sport() { Id = 0, Title = "Все" }
        };
        private Sport _selectSport = new Sport();
        private bool directionName;
        private bool directionRaiting;


        public TeamsPage()
        {
            builder = new NpgsqlConnectionStringBuilder(StorageKeys.DefaultConnectionString);
        }


        protected override Task OnInitializedAsync()
        {
            var connect = new NpgsqlConnection(builder.ConnectionString);

            var commandTeams = new NpgsqlCommand("SELECT te.\"Title\", te.\"Logo\", sp.\"Id\", te.\"Raiting\", te.\"PercentWin\" " +
                                            "FROM \"Teams\" as te " +
                                            "JOIN \"Sports\" as sp ON te.\"IdSport\" = sp.\"Id\"", connect);
            var commandSport = new NpgsqlCommand("SELECT \"Id\", \"Title\" FROM \"Sports\"", connect);


            connect.Open();

            var reader = commandSport.ExecuteReader();

            while (reader.Read())
            {
                Sports.Add(new Sport()
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1)
                });
            }
            reader.Close();

            reader = commandTeams.ExecuteReader();

            while (reader.Read())
            {
                Teams.Add(new Team()
                {
                    Title = reader.GetString(0),
                    Logo = reader.IsDBNull(1) ? null: reader.GetString(1),
                    IdSportNavigation = Sports.Find(sport => sport.Id == reader.GetInt32(2)),
                    Raiting = reader.IsDBNull(3) ? null: reader.GetInt32(3),
                    PercentWin = reader.IsDBNull(4) ? null : reader.GetFloat(4)
                });
            }
            connect.Close();
            VisibleTeams = Teams.ToList();
            StateHasChanged();
            return base.OnInitializedAsync();
        }

        private void ChangeSport(ChangeEventArgs obj)
        {
            _selectSport = Sports.FirstOrDefault(e => e.Id == Convert.ToInt32(obj.Value));

            if (_selectSport is {Id: 0})
            {
                VisibleTeams = Teams.ToList();
            }
            else
            {
                VisibleTeams = Teams.Where(team=> team.IdSportNavigation.Id == _selectSport.Id).ToList();
            }
        }

        private void SortName()
        {
            directionRaiting = false;
            if (!directionName)
            {
                directionName = true;
                VisibleTeams = VisibleTeams.OrderBy(temp => temp.Title).ToList();
            }
            else
            {
                directionName = false;
                VisibleTeams = VisibleTeams.OrderByDescending(temp => temp.Title).ToList();
            }
            
        }
        private void SortRaiting()
        {
            directionName= false;
            if (!directionRaiting)
            {
                directionRaiting = true;
                VisibleTeams = VisibleTeams.OrderBy(temp => temp.Raiting).ToList();
            }
            else
            {
                directionRaiting = false;
                VisibleTeams = VisibleTeams.OrderByDescending(temp => temp.Raiting).ToList();
            }
            
        }
    }
}
