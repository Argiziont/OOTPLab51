public class InventoryReportFilter : IReportFilter
{
    public List<string> FilterData(List<string> data)
    {
        return new List<string>() { "Show not invoiced items" };
    }
}