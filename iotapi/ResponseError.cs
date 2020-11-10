namespace iotapi
{
    public class ResponseError
    {
        public string Error {get; set;}
        public ResponseError(string message = "")
        {
            Error = message;
        }
    }
}
