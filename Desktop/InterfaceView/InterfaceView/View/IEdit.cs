using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceView.View
{
    public interface IEditControl
    {
        String Hint { get; set; }
        Object Title { get; set; }
        String NameItem { get; set; }

        Boolean IsNullable { get; set; }
    }
}
