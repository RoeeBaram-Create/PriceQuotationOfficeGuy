using PriceQuotationOfficeGuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Services
{
    public interface IPriceQuotationService
    {
        Task<PriceQuotationResponseDto> CreatePriceQuotation(PriceQuotationCreationDto priceQuotationCreationDto);
    }
}
