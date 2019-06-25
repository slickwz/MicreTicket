using MicreTicket.Common.Entities;
using MicreTicket.Common.Repository;
using MicreTicket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicreTicket.Domain.Repository
{
    public interface ILoginRepository:IDomainRepository<Login>
    {
        Guid UserLogin(string tel, string password);
    }
}
