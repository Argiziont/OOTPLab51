public class ExcelReportHandler : IReportHandler
{
    private IReportHandler nextHandler;
    public void SetNextHandler(IReportHandler handler)
    {
        this.nextHandler = handler;
    }

    public IReportHandler HandleReportRequest(IReport report)
    {
        if (report is ExcelReport)
        {
            // Apply Excel report handling logic
            // ...
            return this;
        }
        else
        {
            return nextHandler.HandleReportRequest(report);
        }
    }
}