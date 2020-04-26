using Data.Data;
using Data.Models;
using LearningBlazorServer.Models;
using System.Collections.Generic;
using System.Threading;

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

        public IEnumerable<NewPageComponentModel> GetAll()
        {
            var allRecords = _dataService.GetAll();
            var records = new List<NewPageComponentModel>();

            foreach (var record in allRecords)
            {
                records.Add(new NewPageComponentModel { Id = record.ID, Value = record.Value });
            }

            return records;
        }
    }
}
