public interface IReportHandler
{
    void SetNextHandler(IReportHandler handler);
    IReportHandler HandleReportRequest(IReport report);
}