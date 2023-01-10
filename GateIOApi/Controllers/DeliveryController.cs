using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GateIOApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly ILogger<DeliveryController> _logger;
        private readonly IDeliveryApi _deliveryApi;
        private readonly ISpotApi _spotApi;

        public DeliveryController(ILogger<DeliveryController> logger, IDeliveryApi deliveryApi, ISpotApi spotApi)
        {
            _logger = logger;
            _deliveryApi = deliveryApi;
            _spotApi = spotApi;
        }


        [HttpGet]
        [Route("GetCurrencyPairs")]
        public IEnumerable<CurrencyPair> GetCurrencyPairs()
        {
            ApiResponse<List<CurrencyPair>> localVarResponse = _spotApi.ListCurrencyPairsWithHttpInfo();
            return localVarResponse.Data;
        }

        [HttpGet]
        [Route("GetInstrument/{currency}")]
        public CurrencyPair GetInstrument(string currency)
        {
            CurrencyPair currencyPair = _spotApi.GetCurrencyPair(currency);
            return currencyPair;
        }


        [HttpGet]
        [Route("GetTickers/{currency}")]
        public List<Ticker> GetTickers(string currency)
        {
            List<Ticker> tickers = _spotApi.ListTickers(currency);
            return tickers;
        }

        [HttpPost]
        [Route("CreateSingleOrder")]
        public Order CreateSingleOrder([FromBody]Order order)
        {
            Order result = _spotApi.CreateOrder(order);
            return result;
        }

        [HttpGet]
        [Route("Candlesticks/{currency}")]
        public List<List<string>> Candlesticks(string currency)
        {
            List<List<string>> result = _spotApi.ListCandlesticks(currency);
            return result;
        }
    }
}
