using Vgym.Server.Models.Entities;

namespace Vgym.Server.Services
{
    //Example boilerplate for a service , user service, workoutservice etc.
    //needs to change to work with async, await and tasks
    //needs to change to work with DTO's 
    public class DummyService : IDummyService
    {
        public void AddDummy(DummyModel dummy)
        {
            throw new NotImplementedException();
        }

        public void DeleteDummy(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DummyModel> GetAllDummyModels()
        {
            throw new NotImplementedException();
        }

        public DummyModel GetDummy(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDummy(DummyModel dummy)
        {
            throw new NotImplementedException();
        }
    }
}
