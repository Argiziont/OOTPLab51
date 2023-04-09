public class SalesReportFilter : IReportFilter
{
    public List<string> FilterData(List<string> data)
    {
        return new List<string>() { "Show only Sales greater than 1000" };
    }
}