using System;

namespace iocContainer.Services
{
    public interface ITransientService : IService { }

    public class TransientService : ITransientService
    {
        private string _guid;

        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string getGuid()
        {
            return _guid;
        }
    }
}
