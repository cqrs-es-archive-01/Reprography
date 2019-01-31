using System;
using System.Runtime.Serialization;

namespace Reprography.Common.Utilities
{
    [Serializable]
    public class ReprographyException:Exception
    {
        public ReprographyException()
        {
        }

        public ReprographyException(string message)
            : base(message)
        {
        }

        public ReprographyException(string messageFormat, params object[] args)
            : base(string.Format(messageFormat, args))
        {
        }

        protected ReprographyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ReprographyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
