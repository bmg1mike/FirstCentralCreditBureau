using Microsoft.Extensions.Logging;
using Domain.Enums;
using Newtonsoft.Json;
using Domain.DTOs;
using Domain.Interfaces.Services;

namespace Service.Implementation
{

    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<BaseService> _logger;

        public BaseService(IHttpClientFactory httpClientFactory, ILogger<BaseService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<T?> SendAsync<T>(string url, object request, ApiType apiType, object? headers = null)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Clear();
                var requestMessage = new HttpRequestMessage();
                requestMessage.RequestUri = new Uri(url);
                requestMessage.Headers.Add("Accept", "application/json");
                HttpResponseMessage? apiResponse = null;
                switch (apiType)
                {
                    case ApiType.Post:
                        requestMessage.Method = HttpMethod.Post;
                        break;
                    case ApiType.Put:
                        requestMessage.Method = HttpMethod.Put;
                        break;
                    case ApiType.Delete:
                        requestMessage.Method = HttpMethod.Delete;
                        break;
                    default:
                        requestMessage.Method = HttpMethod.Get;
                        break;
                }
                apiResponse = await client.SendAsync(requestMessage);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                _logger.LogInformation($"Response from {url} {apiContent}");
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;
            }
            catch (Exception e)
            {
                var dto = new ResponseDto
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                _logger.LogError(e, e.Message);
                return apiResponseDto;
            }

        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}