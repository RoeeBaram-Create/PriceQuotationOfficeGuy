using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Repositories
{
    public interface IPriceQuotationRepository
    {
        Task<PriceQuotationResponse> GetPostCallsResponseFromSupplier(PriceQuotationRequest priceQuotationRequest, string url);
    }
}
