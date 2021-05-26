using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using DesktopBookmaker.Data;
using InterfaceView.View;

namespace DesktopBokmeyker.View.View
{
    class TeamsView : IView
    {
        private List<Teams> Teams { get; set; }
        private List<Sports> Sports { get; set; }
        private List<Teams> TeamsCSGO { get; set; }
        private List<Teams> TeamsLOL { get; set; }


        private async void initData()
        {
            var db = new DBContext();

            await Task.Run(() =>
            {
                Teams = db.Teams.ToList();
                Sports = db.Sports.ToList();
            });
            await Task.Run(() =>
            {
                TeamsCSGO = Teams.Where(team => team.IdSport == 1).ToList();
                TeamsLOL = Teams.Where(team => team.IdSport == 2).ToList();
            });
        }

        public void LoadEditWindow(ListView listView)
        {
            throw new NotImplementedException();
        }

        public void ViewTable(DataGrid data)
        {
            throw new NotImplementedException();
        }

        public void UpdateEditWindow(List<IEditControl> edits, object ob)
        {
            throw new NotImplementedException();
        }

        public object GetUpdateInEditWindow(List<IEditControl> edits, object ob)
        {
            throw new NotImplementedException();
        }
    }
}
