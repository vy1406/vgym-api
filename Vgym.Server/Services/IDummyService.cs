using Vgym.Server.Models.Entities;

namespace Vgym.Server.Services
{
    //Example of a service interface that implaments CRUD operations
    //needs to change later to work with async await and tasks
    //needs to change later to work with returning DTO's
    public interface IDummyService
    {
        DummyModel GetDummy(int id);
        IEnumerable<DummyModel> GetAllDummyModels();
        void AddDummy(DummyModel dummy);
        void UpdateDummy(DummyModel dummy);
        void DeleteDummy(int id);

    }
}
