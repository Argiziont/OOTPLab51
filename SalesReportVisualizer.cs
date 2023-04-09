public class SalesReportVisualizer : IReportVisualizer
{
    public List<string> VisualizeData(List<string> data)
    {
        return new List<string>() { "Some report visualization" };
    }
}