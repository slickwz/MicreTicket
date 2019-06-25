using MicreTicket.Common.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace MicreTicket.Repository
{
    public class EFCoreRepository : IRepository
    {
        private readonly DbContext context;
        public EFCoreRepository(DbContext context)
        {
            this.context = context;
        }
        public void Commit()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
