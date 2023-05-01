namespace netCore.FluentValidation.Responses
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; } = true;
        public string Error { get; set; }
        public T Data { get; set; }

        public BaseResponse(T data)
        {
            Data = data;
        }
        public BaseResponse(string error)
        {
            this.Error = error;
            this.Success = false;
        }
    }
}
