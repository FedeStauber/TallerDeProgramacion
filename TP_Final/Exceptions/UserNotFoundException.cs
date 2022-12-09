using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace TP_Final.Exceptions
{
    [Serializable]
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string msg) : base(msg) { }
        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
