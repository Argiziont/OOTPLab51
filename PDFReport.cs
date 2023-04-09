public class PDFReport : IReport
{
    private IReportData data;
    private IReportFilter filter;
    private IReportVisualizer visualizer;

    public PDFReport(IReportData data, IReportFilter filter, IReportVisualizer visualizer)
    {
        this.data = data;
        this.filter = filter;
        this.visualizer = visualizer;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating PDF report...");
        var filteredData = filter.FilterData(data.GetData());
        var visualizedData = visualizer.VisualizeData(filteredData);
        // Generate PDF report using the visualized data
        // ...
    }
}