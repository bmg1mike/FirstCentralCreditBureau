using Domain.DTOs;

namespace Domain.Interfaces.Services;

public interface IFirstCentralCreditBureauService
{
    Task<ResponseDto> Login();
    Task<ResponseDto> ConnectConsumerMatch(ConnectConsumerMatchRequest request);
    Task<ResponseDto> ConnectCommercialMatch(ConnectCommercialMatchRequest request);
    Task<ResponseDto> ConsumerBasicCredit(ConsumerReportRequest request);
    Task<ResponseDto> ConsumerBasicTrace(ConsumerReportRequest request);
    Task<ResponseDto> ConsumerFullCredit(ConsumerReportRequest request);
}