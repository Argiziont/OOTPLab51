public class ExcelReportState : IReportState
{
    private IReportState nextState;
    public ExcelReportState(IReportState nextState)
    {
        this.nextState = nextState;
    }

    public void GenerateReport(IReport report)
    {
        // Apply Excel report settings
        // ...
        report.GenerateReport();
        nextState.GenerateReport(report);
    }
}