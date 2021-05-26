using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InterfaceView.View
{
    public interface IView
    {
        /// <summary>
        /// Загрузка EditControl в ListView.Items, а также прокидывание данных в эти контроллеры.
        /// Метод должен быть async, т.к. возвращает Task
        /// </summary>
        /// <param name="listView">в коллекцию Items должны быть загружены Control</param>
        /// <returns></returns>
        void LoadEditWindow(ListView listView);

        /// <summary>
        /// Реализует отображение данных в заполненной таблице
        /// </summary>
        /// <param name="data">коллекция Columns должна быть правильно отформатирована</param>
        void ViewTable(DataGrid data);

        /// <summary>
        /// Заполнение контроллеров по объекту ob
        /// </summary>
        /// <param name="edits">Коллекция контроллеров</param>
        /// <param name="ob">Объект, из которого будут браться данные, для обновления контроллеров</param>
        void UpdateEditWindow(List<IEditControl> edits, Object ob);
        Object GetUpdateInEditWindow(List<IEditControl> edits, Object ob);
    }
}
