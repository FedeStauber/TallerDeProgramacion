using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP_Final.Exceptions
{
    [Serializable]
    public class ErrorDownloadingCoverException : Exception
    {
        public ErrorDownloadingCoverException(string msg) : base(msg) { }
        public ErrorDownloadingCoverException() : base("Error al al intentar descargar la imagen") { }
        protected ErrorDownloadingCoverException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
