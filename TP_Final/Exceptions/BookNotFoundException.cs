using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP_Final.Exceptions
{
    [Serializable]
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string msg) : base(msg) {}
        protected BookNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {}
}
}
