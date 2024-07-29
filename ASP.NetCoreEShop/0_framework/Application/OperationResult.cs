namespace ASP.NetCoreEShop._0_framework.Application
{
    public class OperationResult
    {
        public string Message { get; set; }
        public bool IsSuccedded { get; set; }

        public OperationResult()
        { 
            IsSuccedded = false;
        }

        public OperationResult Succedded(string message = "عملیات با موفقیت انجام شد ")
        {
            IsSuccedded = true;
            Message=message;
            return this;
        }
        public OperationResult Failed(string message)
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }
    }
}
