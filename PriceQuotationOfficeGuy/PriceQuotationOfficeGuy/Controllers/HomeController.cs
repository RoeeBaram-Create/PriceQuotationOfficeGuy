using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PriceQuotationOfficeGuy.Models;
using PriceQuotationOfficeGuy.Services;

using System.Net.Http.Headers;
using System.IO;
using Rotativa;
using PriceQuotationOfficeGuy.Common;

namespace PriceQuotationOfficeGuy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPriceQuotationService _priceQuotationService;

        public HomeController(ILogger<HomeController> logger, IPriceQuotationService priceQuotationService)
        {
            _logger = logger;
            _priceQuotationService = priceQuotationService;
        }

       
        public IActionResult Index()
        {
            var model = new PriceQuotationCreationDto();
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> CreatePriceQuotation(PriceQuotationCreationDto priceQuotationCreationDto)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    PriceQuotationResponseDto priceQuotationResponseDto = await _priceQuotationService.CreatePriceQuotation(priceQuotationCreationDto);
                    return View("GetPriceQuotationResponse", priceQuotationResponseDto);
                }
                catch (Exception ex)
                {
                    string logMessage = $"HomeController.CreatePriceQuotation - Exception. visited at {DateTime.UtcNow.ToLongTimeString()}";
                    _logger.LogError(ex, logMessage);
                    PriceQuotationResponseDto priceQuotationResponseDto = PriceQuotationCommon.CreatePriceQuotationResponse(ex.Message);
                    return View("GetPriceQuotationResponse", priceQuotationResponseDto);
                }
            }

            return View(priceQuotationCreationDto);
        }

       
        public IActionResult GetPriceQuotationResponse(PriceQuotationResponseDto priceQuotationResponseDto)
        {
            return View(priceQuotationResponseDto);
        }

 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
