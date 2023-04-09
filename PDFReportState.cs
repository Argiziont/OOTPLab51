public class PDFReportState : IReportState
{
    private IReportState nextState;
    public PDFReportState(IReportState nextState)
    {
        this.nextState = nextState;
    }

    public void GenerateReport(IReport report)
    {
        // Apply PDF report settings
        // ...
        report.GenerateReport();
        nextState.GenerateReport(report);
    }
}