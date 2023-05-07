using Domain.DTOs;
using Domain.Enums;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Service.Implementation;

public class FirstCentralCreditBureauService : IFirstCentralCreditBureauService
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
            var url = $"{_config["FirstCentralCreditBureau:BaseUrl"]}/login";
            var request = new
            {
                username = _config["FirstCentralCreditBureau:username"],
                password = _config["FirstCentralCreditBureau:password"]
            };
            var result = await _baseService.SendAsync<List<LoginResponseDto>>(url, request, ApiType.Post);

            if (string.IsNullOrEmpty(result?[0].DataTicket) || result is null || result.Count == 0)
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
                Result = result[0]
            };
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task<ResponseDto> ConnectConsumerMatch(ConnectConsumerMatchRequest request)
    {
        try
        {
            var url = $"{_config["FirstCentralCreditBureau:BaseUrl"]}/ConnectConsumerMatch";
            var result = await _baseService.SendAsync<List<ConnectConsumerMatchRespose>>(url, request, ApiType.Post);

            if (result is null || result.Count == 0)
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
                Result = result[0]
            };

        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task<ResponseDto> ConnectCommercialMatch(ConnectCommercialMatchRequest request)
    {
        try
        {
            var url = $"{_config["FirstCentralCreditBureau:BaseUrl"]}/ConnectCommercialMatch";
            var result = await _baseService.SendAsync<List<ConnectCommercialMatchResponse>>(url, request, ApiType.Post);

            if (result is null || result.Count == 0)
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
                Result = result[0]
            };

        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task<ResponseDto> ConsumerBasicCredit(ConsumerReportRequest request)
    {
        try
        {
            var url = $"{_config["FirstCentralCreditBureau:BaseUrl"]}/ConsumerBasicCredit";
            var result = await _baseService.SendAsync<List<ConsumerBasicCreditResponse>>(url, request, ApiType.Post);

            if (result is null || result.Count == 0)
            {
                return new ResponseDto
                {
                    DisplayMessage = "There was an error, please try again later",
                    ErrorMessages = new List<string>(),
                    IsSuccess = false,
                    Result = null
                };
            }
            var response = new
            {
                subjectList = result[0].SubjectList,
                personalDetailsSummary = result[1].PersonalDetailsSummary,
                creditAccountSummary = result[2].CreditAccountSummary,
                accountRating = result[3].AccountRating,
                enquiryDetails = result[4].EnquiryDetails
            };
            return new ResponseDto
            {
                IsSuccess = true,
                ErrorMessages = new List<string>(),
                DisplayMessage = "Success",
                Result = response
            };

        }
        catch (System.Exception)
        {

            throw;
        }
    }
    public async Task<ResponseDto> ConsumerBasicTrace(ConsumerReportRequest request)
    {
        try
        {
            var url = $"{_config["FirstCentralCreditBureau:BaseUrl"]}/ConsumerBasicTrace";
            var result = await _baseService.SendAsync<List<ConsumerBasicTraceResponse>>(url, request, ApiType.Post);

            if (result is null || result.Count == 0)
            {
                return new ResponseDto
                {
                    DisplayMessage = "There was an error, please try again later",
                    ErrorMessages = new List<string>(),
                    IsSuccess = false,
                    Result = null
                };
            }
            var response = new
            {
                subjectList = result[0].SubjectList,
                personalDetailsSummary = result[1].PersonalDetailsSummary,
                creditAccountSummary = result[2].CreditAccountSummary,
                guarantorDetails = result[3].GuarantorDetails,
                identificationHistory = result[4].IdentificationHistory,
                addressHistory = result[5].AddressHistory,
                employmentHistory = result[6].EmploymentHistory,
                telephoneHistory = result[7].TelephoneHistory
            };
            return new ResponseDto
            {
                IsSuccess = true,
                ErrorMessages = new List<string>(),
                DisplayMessage = "Success",
                Result = response
            };

        }
        catch (System.Exception)
        {

            throw;
        }
    }
    public async Task<ResponseDto> ConsumerFullCredit(ConsumerReportRequest request)
    {
        try
        {
            var url = $"{_config["FirstCentralCreditBureau:BaseUrl"]}/ConsumerFullCredit";
            var result = await _baseService.SendAsync<List<ConsumerFullCreditResponse>>(url, request, ApiType.Post);

            if (result is null || result.Count == 0)
            {
                return new ResponseDto
                {
                    DisplayMessage = "There was an error, please try again later",
                    ErrorMessages = new List<string>(),
                    IsSuccess = false,
                    Result = null
                };
            }
            var response = new
            {
                subjectList = result[0].SubjectList,
                personalDetailsSummary = result[1].PersonalDetailsSummary,
                deliquencyInformation = result[2].DeliquencyInformation,
                creditAccountSummary = result[3].CreditAccountSummary,
                creditAccountRating = result[4].CreditAccountRating,
                creditAgreementSummary = result[5].CreditAgreementSummary,
                accountMonthlyPaymentHistoryHeader = result[6].AccountMonthlyPaymentHistoryHeader,
                accountMonthlyPaymentHistory = result[7].AccountMonthlyPaymentHistory,
                guarantorCount = result[8].GuarantorCount,
                guarantorDetails = result[9].GuarantorDetails,
                enquiryHistoryTop = result[10].EnquiryHistoryTop,
                identificationHistory = result[11].IdentificationHistory,
                addressHistory = result[12].AddressHistory,
                employmentHistory = result[13].EmploymentHistory,
                telephoneHistory = result[14].TelephoneHistory,
                enquiryDetails = result[15].EnquiryDetails
            };
            return new ResponseDto
            {
                IsSuccess = true,
                ErrorMessages = new List<string>(),
                DisplayMessage = "Success",
                Result = response
            };

        }
        catch (System.Exception)
        {

            throw;
        }
    }

}