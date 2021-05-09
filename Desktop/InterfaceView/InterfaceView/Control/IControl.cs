using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterfaceView.Control
{
    public interface IControl<T>
        where T : class
    {
        void Add(T ob);
        void AddAsync(T ob);
        void Edit(T ob);
        void EditAsync(T ob);
        void Delete(T ob);
        void DeleteAsync(T ob);
        void Delete(Int32 id);
        void DeleteAsync(Int32 id);
        ICollection<T> GetData();
        void GetDataAsync(ICollection<Object> list);
        ICollection<T> Search(Func<T, Boolean> func);
        void SearchAsync(ICollection<T> list, Func<T, Boolean> func);
    }

    public interface IControl
    {
        void Add(Object ob);
        Task AddAsync(Object ob);
        void Edit(Object ob);
        Task EditAsync(Object ob);
        void Delete(Object ob);
        Task DeleteAsync(Object ob);
        void Delete(Int32 id);
        Task DeleteAsync(Int32 id);
        ICollection<Object> GetData();
        Task GetDataAsync(ICollection<Object> list);
        ICollection<Object> Search(Func<Object, Boolean> func);
        Task SearchAsync(ICollection<Object> list, Func<Object, Boolean> func);
    }
}
