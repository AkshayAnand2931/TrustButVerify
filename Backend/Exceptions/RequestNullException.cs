namespace TrustButVerify.Exceptions
{
    public class RequestNullException : Exception
    {
        public RequestNullException()
        {
        }

        public RequestNullException(string? message) : base(message)
        {
        }

        public RequestNullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
