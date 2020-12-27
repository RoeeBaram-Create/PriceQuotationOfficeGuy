using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PriceQuotationOfficeGuy.Common;
using PriceQuotationOfficeGuy.Models;
using PriceQuotationOfficeGuy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Services
{
    public class PriceQuotationService: IPriceQuotationService
    {
        private readonly IConfiguration _configuration;
        private readonly IPriceQuotationRepository _priceQuotationRepository;
        private readonly ILogger<PriceQuotationService> _logger;

        public PriceQuotationService(IConfiguration configuration, IPriceQuotationRepository priceQuotationRepository, ILogger<PriceQuotationService> logger)
        {
            _priceQuotationRepository = priceQuotationRepository;
            _configuration = configuration;
            _logger = logger;

        }

        public async Task<PriceQuotationResponseDto> CreatePriceQuotation(PriceQuotationCreationDto priceQuotationCreationDto)
        {
            try
            {
                string url = _configuration.GetValue<string>("AccountingDocumentsCreate");
                PriceQuotationRequest priceQuotationRequest = PriceQuotationCommon.CreatePriceQuotationRequest(priceQuotationCreationDto);
                PriceQuotationResponse priceQuotationResponse = await _priceQuotationRepository.GetPostCallsResponseFromSupplier(priceQuotationRequest, url);
                PriceQuotationResponseDto priceQuotationResponseDto = PriceQuotationCommon.CreatePriceQuotationResponse(priceQuotationResponse);

                return priceQuotationResponseDto;
            }
            catch (Exception ex)
            {
                string logMessage = $"PriceQuotationService.CreatePriceQuotation - Exception. visited at {DateTime.UtcNow.ToLongTimeString()}";
                _logger.LogError(ex, logMessage);
                 PriceQuotationResponseDto priceQuotationResponseDto = PriceQuotationCommon.CreatePriceQuotationResponse(ex.Message);

                return priceQuotationResponseDto;
            }

        }




    }
}
