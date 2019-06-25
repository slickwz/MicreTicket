using MicreTicket.Common.Entities;
using System;

namespace MicreTicket.Domain.Entities
{
    /// <summary>
    /// 联系人
    /// </summary>
    public class Contact : IValueObject
    {
        public Guid Id { get; set; }

        public string ContactName { get; set; }
        public string ContactTel { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Zero { get; set; }
        public string Street { get; set; }
        public IsDefaultEnum IsDefault { get; set; }
        public Guid DealerId { get; set; }
        public Contact CreateContact(Guid dealerid, string name, string tel, string province, string city,
        string zero, string street, int isdefault)
        {
            Id = Guid.NewGuid();
            DealerId = dealerid;
            ContactName = name;
            ContactTel = tel;
            Province = province;
            City = city;
            Zero = zero;
            Street = street;
            switch (isdefault)
            {
                case 1:
                    IsDefault = IsDefaultEnum.默认;
                    break;
                case 2:
                    IsDefault = IsDefaultEnum.非默认;
                    break;
            }
            return this;

        }
    }
}
