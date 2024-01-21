namespace OCLP.Base
{
    public class BaseResponseWithData<T>
    {
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public List<string> Errors { get; set; } = new();
    }
}