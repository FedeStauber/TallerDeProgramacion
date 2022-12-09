using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP_Final.Exceptions
{
    [Serializable]
    public class NoAvailableCopyException : Exception
    {
        public NoAvailableCopyException(string msg) : base(msg) {}
        protected NoAvailableCopyException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
