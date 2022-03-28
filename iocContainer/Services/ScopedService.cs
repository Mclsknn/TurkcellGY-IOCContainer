using System;

namespace iocContainer.Services
{
    public interface IScopedService : IService { }

    public class ScopedService : IScopedService
    {
        private string _guid;

        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string getGuid()
        {
            return _guid;
        }
    }
}
