// Report interface


// Concrete report class 1: Excel report
public class ExcelReport : IReport
{
    private IReportData data;
    private IReportFilter filter;
    private IReportVisualizer visualizer;

    public ExcelReport(IReportData data, IReportFilter filter, IReportVisualizer visualizer)
    {
        this.data = data;
        this.filter = filter;
        this.visualizer = visualizer;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating Excel report...");
        var filteredData = filter.FilterData(data.GetData());
        var visualizedData = visualizer.VisualizeData(filteredData);
        // Generate Excel report using the visualized data
        // ...
    }
}
