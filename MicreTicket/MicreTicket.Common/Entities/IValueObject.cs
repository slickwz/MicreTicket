using System;
using System.Collections.Generic;
using System.Text;

namespace MicreTicket.Common.Entities
{
    public interface IValueObject
    {
        Guid Id { get; set; }
    }
}
