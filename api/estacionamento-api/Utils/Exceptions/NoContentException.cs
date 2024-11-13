namespace estacionamento_api.Utils.Exceptions;

public class NoContentException : Exception
{
    public int StatusCode { get; }

    public NoContentException(String message) : base(message)
    {
        this.StatusCode = 204;
    }
}