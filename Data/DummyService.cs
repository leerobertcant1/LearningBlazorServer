using Data.Data;
using Data.Models;
using LearningBlazorServer.Models;

namespace LearningBlazorServer.Data
{
    public class DummyService : IDummyDataService
    {
        private readonly IDataService _dataService;

        public DummyService(IDataService dataService)
        {
            _dataService = dataService;
        }
        public string GetDummyData()
        {
            return "Dummy Data returned from the Service";
        }

        public void CreateRecord(NewPageComponentModel newPageComponentModel)
        {
            _dataService.Create(new DummyDataModel { ID = newPageComponentModel.Id, Value = newPageComponentModel.Value });
        }
    }
}
