using LearningBlazorServer.Models;

namespace LearningBlazorServer.Data
{
    public interface IDummyDataService
    {
        public void CreateRecord(NewPageComponentModel newPageComponentModel);
        string GetDummyData();
    }
}
