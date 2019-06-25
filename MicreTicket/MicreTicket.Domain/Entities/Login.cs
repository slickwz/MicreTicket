using MicreTicket.Common.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace MicreTicket.Domain.Entities
{
    public class Login : IAggergationRoot
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public Guid DealerId { get; set; }

        public Login CreateLogin(string code, Guid dealerid)
        {
            this.Id = Guid.NewGuid();
            //手机号
            this.Code = code;
            //默认初始密码
            this.Password = "111111";
            this.DealerId = dealerid;
            return this;
        }
    }
}
