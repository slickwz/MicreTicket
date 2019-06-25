namespace MicreTicket.Domain
{
    public enum UnitTypeEnum
    {
        个 = 1,
        盒 = 2,
        包 = 3,
        瓶 = 4,
        斤 = 5,
        两 = 6,
        平米 = 7
    }

    public enum CardTypeEnum
    {
        普通会员 = 1,
        银卡会员 = 2,
        金卡会员 = 3
    }

    public enum LevelEnum
    {
        片区经理 = 1,
        省区经理 = 2,
        大区经理 = 3,
        董事 = 4
    }

    public enum IsDefaultEnum
    {
        默认 = 1,
        非默认 = 2
    }
}
