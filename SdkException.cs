using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CarModelSdk_NetCore
{
    public class CarModelSdkException : ApplicationException
    {
        public CarModelSdkException() { }

        public CarModelSdkException(string message) : base(message) { }

        public CarModelSdkException(string message, Exception inner) : base(message, inner) { }

        protected CarModelSdkException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
