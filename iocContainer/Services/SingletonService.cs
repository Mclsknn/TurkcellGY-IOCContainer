using System;

namespace iocContainer.Services
{
    public interface ISingletonService : IService { }

    public class SingletonService : ISingletonService
    {
        private string _guid;

        public SingletonService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string getGuid()
        {
            return _guid;
        }
    }

}
