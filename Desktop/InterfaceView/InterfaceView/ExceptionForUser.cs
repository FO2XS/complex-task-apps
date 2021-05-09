using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceView
{
    public class ExceptionForUser
        : Exception
    {
        public String Title { get; }

        public ExceptionForUser(string message)
            : base(message) { }

        public ExceptionForUser(string message, String title) 
            : base(message) { Title = title; }
        public ExceptionForUser(string message, String title, Exception innerException) 
            : base(message, innerException) { Title = title; }
        protected ExceptionForUser(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    }
}
