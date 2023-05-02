using Domain.DTOs;
using Domain.Enums;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Service.Implementation;

public class FirstCentralCreditBureauService
{
    private readonly IBaseService _baseService;
    private readonly ILogger<FirstCentralCreditBureauService> _logger;
    private readonly IConfiguration _config;
    public FirstCentralCreditBureauService(IBaseService baseService, ILogger<FirstCentralCreditBureauService> logger, IConfiguration config)
    {
        _baseService = baseService;
        _logger = logger;
        _config = config;
    }

    public async Task<ResponseDto> Login()
    {
        try
        {
            var url = $"{_config["FirstCentralCreditBureau"]}/login";
            var request = new
            {
                username = _config["FirstCentralCreditBureau"],
                password = _config["FirstCentralCreditBureau"]
            };
            var result = await _baseService.SendAsync<LoginResponseDto>(url, request, ApiType.Post);

            if (string.IsNullOrEmpty(result?.DataTicket) || result is null)
            {
                return new ResponseDto
                {
                    DisplayMessage = "There was an error, please try again later",
                    ErrorMessages = new List<string>(),
                    IsSuccess = false,
                    Result = null
                };
            }
            return new ResponseDto
            {
                IsSuccess = true,
                ErrorMessages = new List<string>(),
                DisplayMessage = "Success",
                Result = result
            };
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}