namespace Demo.Domain.Exceptions;

public abstract class BaseException : Exception
{
    protected BaseException(string title, string message)
        : base(message) =>
        Title = title;

    public string Title { get; }
    public int StatusCode { get; set; }
}
