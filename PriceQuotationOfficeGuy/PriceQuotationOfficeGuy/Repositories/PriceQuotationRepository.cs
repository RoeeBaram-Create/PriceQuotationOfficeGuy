using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Repositories
{
    public class PriceQuotationRepository: IPriceQuotationRepository
    {

       
        private readonly ILogger<PriceQuotationRepository> _logger;

        public PriceQuotationRepository(ILogger<PriceQuotationRepository> logger)
        {
            _logger = logger;
        }

        public async Task<PriceQuotationResponse> GetPostCallsResponseFromSupplier(PriceQuotationRequest priceQuotationRequest, string url)
        {
            PriceQuotationResponse priceQuotationResponse = null;

            try
            {

                using (var client = new HttpClient())
                using (var request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    var json = JsonConvert.SerializeObject(priceQuotationRequest);
                    using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                    {
                        request.Content = stringContent;

                        using (var response = await client
                            .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                            .ConfigureAwait(false))
                        {
                            response.EnsureSuccessStatusCode();
                            string dataResponse = await response.Content.ReadAsStringAsync();
                            priceQuotationResponse = JsonConvert.DeserializeObject<PriceQuotationResponse>(dataResponse);
                            return priceQuotationResponse;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string logMessage = $"PriceQuotationRepository.GetPostCallsResponseFromSupplier - Exception. visited at {DateTime.UtcNow.ToLongTimeString()}";
                _logger.LogError(ex, logMessage);

                throw; 

            }
        }
            
    }
}
