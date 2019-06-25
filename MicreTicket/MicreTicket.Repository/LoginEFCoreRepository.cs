using MicreTicket.Domain.Entities;
using MicreTicket.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MicreTicket.Repository
{
    public class LoginEFCoreRepository : DomainRepository<Login>, ILoginRepository
    {
        public LoginEFCoreRepository(DbContext context) : base(context)
        {

        }

        public Guid UserLogin(string tel, string password)
        {
            return context.Set<Login>().Where(x => x.Tel == tel && x.Password == password).First().Id;
        }
    }
}
