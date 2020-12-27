
using System.Collections.Generic;

public class PriceQuotationRequest
{
    public Details Details { get; set; }
    public List<PriceQuotationItem> Items { get; set; }
    public bool VATIncluded { get; set; }
    public object VATRate { get; set; }
    public object OriginalDocumentID { get; set; }
    public Credentials Credentials { get; set; }
    public object ResponseLanguage { get; set; }
}

public class Details
{
    public object IsDraft { get; set; }
    public object Date { get; set; }
    public Customer Customer { get; set; }
    public Sendbyemail SendByEmail { get; set; }
    public object Language { get; set; }
    public object Currency { get; set; }
    public string Type { get; set; }
    public object Description { get; set; }
    public object OpeningTextHTML { get; set; }
    public object OpeningText { get; set; }
    public object ClosingTextHTML { get; set; }
    public object ClosingText { get; set; }
}

public class Customer
{
    public object ExternalIdentifier { get; set; }
    public object NoVAT { get; set; }
    public int SearchMode { get; set; }
    public string Name { get; set; }
    public object Phone { get; set; }
    public string EmailAddress { get; set; }
    public object City { get; set; }
    public object Address { get; set; }
    public object ZipCode { get; set; }
    public object CompanyNumber { get; set; }
    public object ID { get; set; }
    public object Folder { get; set; }
}

public class Sendbyemail
{
    public string EmailAddress { get; set; }
    public bool Original { get; set; }
    public bool SendAsPaymentRequest { get; set; }
}

public class Credentials
{
    public int CompanyID { get; set; }
    public string APIKey { get; set; }
}

public class PriceQuotationItem
{
    public int Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? TotalPrice { get; set; }
    public object DocumentCurrency_UnitPrice { get; set; }
    public object DocumentCurrency_TotalPrice { get; set; }
    public InnerItem Item { get; set; }
    public object Description { get; set; }
}

public class InnerItem
{
    public object ID { get; set; }
    public string Name { get; set; }
    public object Price { get; set; }
    public object Currency { get; set; }
    public object Cost { get; set; }
    public object ExternalIdentifier { get; set; }
    public int SearchMode { get; set; }
}
