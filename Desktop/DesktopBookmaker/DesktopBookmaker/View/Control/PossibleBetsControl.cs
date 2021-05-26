using DesktopBookmaker.Data;
using InterfaceView;
using InterfaceView.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBookmaker.View.Control
{
    class PossibleBetsControl
        : IControl
    {
        public Task AddAsync(object ob)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object ob)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(object ob)
        {
            throw new NotImplementedException();
        }

        public Task GetDataAsync(ICollection<object> list)
        {
            throw new NotImplementedException();
        }

        public Task SearchAsync(ICollection<object> list, Func<object, bool> func)
        {
            throw new NotImplementedException();
        }

        public Task SearchAsync(ICollection<object> list, List<Func<object, bool>> listFunc)
        {
            throw new NotImplementedException();
        }
    }
}
