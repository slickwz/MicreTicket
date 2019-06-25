namespace MicreTicket.Common
{
    public class CallResult<T>
    {
        public CallResult()
        {
            Code = 200;
        }
        public CallResult(int code)
        {
            Code = code;
        }
        public CallResult(int code, string msg) : this(code)
        {
            Msg = msg;
        }
        public CallResult(int code, string msg, T t) : this(code, msg)
        {
            Data = t;
        }

        public int Code { get; set; }
        public string Msg { get; set; }
        public T Data { get; set; }

        public virtual bool IsSuccess()
        {
            return Code == 200;
        }
    }

    public class CallResult : CallResult<string>
    {
        public CallResult() : base()
        {

        }
        public CallResult(int code) : base(code)
        {

        }

        public CallResult(int code, string msg) : base(code, msg)
        {

        }

        public CallResult(int code, string msg, string data) : base(code, msg, data)
        {

        }
    }
}
