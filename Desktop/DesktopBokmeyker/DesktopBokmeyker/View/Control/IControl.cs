using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfaceView
{
    interface IControl<T>
        where T : class
    {
        void Add(T ob);
        void AddAsync(T ob);
        Boolean Delete(T ob);
        void DeleteAsync(T ob);
        Boolean Delete(Int32 id);
        void DeleteAsync(Int32 id);
        ICollection<T> GetData();
    }
}
