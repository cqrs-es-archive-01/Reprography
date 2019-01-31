using System;
using System.Collections.Generic;
using System.Text;

namespace Reprography.Domain
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] Timestamp { get; set; }

    }
}
