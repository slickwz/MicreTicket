﻿using System;

namespace MicreTicket.Common.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Code { get; set; }
    }
}
