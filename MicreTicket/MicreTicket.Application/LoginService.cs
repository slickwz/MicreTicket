using MicreTicket.Common;
using MicreTicket.Common.Repository;
using MicreTicket.DTO;

namespace MicreTicket.Application
{
    public class LoginService : BaseService
    {
        private IRepository baseRepository;
        private ILoginEFCoreRepository loginEFCoreRepository;
        public LoginService(IRepository baseRepository, ILoginEFCoreRepository loginEFCoreRepository)
        {

        }
        public CallResult UserLogin(LoginDTO dto)
        {

        }
    }
}
