public class Client
{
    public void Main()
    {
        // Create report data, filter, and visualizer
        IReportData salesReportData = new SalesReportData();
        IReportFilter salesReportFilter = new SalesReportFilter();
        IReportVisualizer salesReportVisualizer = new SalesReportVisualizer();
        // Create Excel report and set its data, filter, and visualizer
        ExcelReport excelReport = new ExcelReport(salesReportData, salesReportFilter, salesReportVisualizer);

        // Create PDF report and set its data, filter, and visualizer
        IReportData inventoryReportData = new InventoryReportData();
        IReportFilter inventoryReportFilter = new InventoryReportFilter();
        IReportVisualizer inventoryReportVisualizer = new InventoryReportVisualizer();
        PDFReport pdfReport = new PDFReport(inventoryReportData, inventoryReportFilter, inventoryReportVisualizer);

        // Create initial report state and set its next state to Excel report state
        IReportState initialState = new InitialReportState(new ExcelReportState(new PDFReportState(null)));

        // Generate Excel report Iterate, assign filters
        initialState.GenerateReport(excelReport);
        initialState.GenerateReport(pdfReport);



    }
}