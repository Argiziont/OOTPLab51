public class PDFReportHandler : IReportHandler
{
    private IReportHandler nextHandler;
    public void SetNextHandler(IReportHandler handler)
    {
        this.nextHandler = handler;
    }

    public IReportHandler HandleReportRequest(IReport report)
    {
        if (report is PDFReport)
        {
            // Apply PDF report handling logic
            // ...
            return this;
        }
        else
        {
            return nextHandler.HandleReportRequest(report);
        }
    }
}