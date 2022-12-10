using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP_Final.Exceptions
{
    [Serializable]
    public class DownloadingCoverErrorException : Exception
    {
        public DownloadingCoverErrorException(string msg) : base(msg) { }
        protected DownloadingCoverErrorException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
