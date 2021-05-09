using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceView
{
    class EventArgsMessageUser
        : EventArgs
    {
        public String Message { get; }

        public EventArgsMessageUser() : base() {}

        public EventArgsMessageUser(String msg) { Message = msg; }
    }
}
