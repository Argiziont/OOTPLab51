public class InventoryReportData : IReportData
{
    public List<string> GetData()
    {
        return new List<string>() { "Potatoes left:5" };
    }
}