public class InitialReportState : IReportState
{
    private IReportState nextState;
    public InitialReportState(IReportState nextState)
    {
        this.nextState = nextState;
    }

    public void GenerateReport(IReport report)
    {
        // Apply initial report settings
        // ...
        nextState.GenerateReport(report);
    }
}