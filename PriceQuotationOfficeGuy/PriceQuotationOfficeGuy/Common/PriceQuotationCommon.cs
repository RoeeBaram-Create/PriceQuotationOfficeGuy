using PriceQuotationOfficeGuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Common
{
    public static class PriceQuotationCommon
    {
        public static PriceQuotationRequest CreatePriceQuotationRequest(PriceQuotationCreationDto priceQuotationCreationDto)
        {
            PriceQuotationRequest priceQuotationRequest = new PriceQuotationRequest();
            priceQuotationRequest.Credentials = new Credentials { APIKey = "AWrQx04WMUEpc3VKmhOmHJ4p9Fy0npMTfem2SmqtvjekdKLQqk", CompanyID = 112355 };

            priceQuotationRequest.Details = new Details
            {
                Customer = new Customer { Name = priceQuotationCreationDto.CustomerName },
                Type = "PriceQuotation"
            };

            priceQuotationRequest.Items = new List<PriceQuotationItem>
            {
                new PriceQuotationItem
                {
                    Quantity = 1,
                    UnitPrice = priceQuotationCreationDto.Amount,
                    TotalPrice = priceQuotationCreationDto.Amount,
                    Item = new InnerItem {Name = priceQuotationCreationDto.ProductName}
                }
            };


            return priceQuotationRequest;
        }


        public static PriceQuotationResponseDto CreatePriceQuotationResponse(PriceQuotationResponse priceQuotationResponse)
        {

            PriceQuotationResponseDto priceQuotationResponseDto = new PriceQuotationResponseDto();
            priceQuotationResponseDto.DownLoadPdfPriceQuotation = priceQuotationResponse.Data.DocumentDownloadURL;
            priceQuotationResponseDto.IsValidResponse = true;
            return priceQuotationResponseDto;

        }

        public static PriceQuotationResponseDto CreatePriceQuotationResponse(string errorMessage)
        {

            PriceQuotationResponseDto priceQuotationResponseDto = new PriceQuotationResponseDto();
            priceQuotationResponseDto.ErrorMessage = errorMessage;
            priceQuotationResponseDto.IsValidResponse = false;
            return priceQuotationResponseDto;

        }


    }
}
