using LearningBlazorServer.Models;
using System.Collections.Generic;

namespace LearningBlazorServer.Data
{
    public interface IDummyDataService
    {
        public void CreateRecord(NewPageComponentModel newPageComponentModel);
        public IEnumerable<NewPageComponentModel> GetAll();
        string GetDummyData();
    }
}
