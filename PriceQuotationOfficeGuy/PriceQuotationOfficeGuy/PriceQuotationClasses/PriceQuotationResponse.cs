
public class PriceQuotationResponse
{
    public Data Data { get; set; }
    public int Status { get; set; }
    public object UserErrorMessage { get; set; }
    public object TechnicalErrorDetails { get; set; }
}

public class Data
{
    public int DocumentID { get; set; }
    public int DocumentNumber { get; set; }
    public int CustomerID { get; set; }
    public string DocumentDownloadURL { get; set; }
}
