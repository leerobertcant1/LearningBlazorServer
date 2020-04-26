namespace LearningBlazorServer.Data
{
    public class DummyService : IDummyDataService
    {
        public string GetDummyData()
        {
            return "Dummy Data returned from the Service";
        }
    }
}
