namespace LearnDI.Services
{
    public interface IServiceA
    {
        string GetId();
    }

    public class ServiceA : IServiceA
    {
        private readonly Guid _id;
        public ServiceA()
        {
            _id = Guid.NewGuid();
        }
        public string GetId()
        {
            return _id.ToString();
        }
    }
}
