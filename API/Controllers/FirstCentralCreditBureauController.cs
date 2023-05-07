using Domain.DTOs;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
/// <summary>
/// First Central Credit Controller
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class FirstCentralCreditBureauController : ControllerBase
{
    private readonly IFirstCentralCreditBureauService _service;
    private readonly ILogger<FirstCentralCreditBureauController> _logger;
    /// <summary>
    ///  Controller constructor
    /// </summary>
    /// <param name="service"></param>
    /// <param name="logger"></param>

    public FirstCentralCreditBureauController(IFirstCentralCreditBureauService service, ILogger<FirstCentralCreditBureauController> logger)
    {
        _service = service;
        _logger = logger;
    }
    /// <summary>
    /// GetDataTicket
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetDataTicket")]
    public async Task<IActionResult> GetDataTicket()
    {
        return Ok(await _service.Login());
    }
    /// <summary>
    /// ConnectConsumerMatch
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("ConsumerMatch")]
    public async Task<IActionResult> ConnectConsumerMatch(ConnectConsumerMatchRequest request)
    {
        return Ok(await _service.ConnectConsumerMatch(request));
    }
    /// <summary>
    /// CommercialMatch
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("CommercialMatch")]
    public async Task<IActionResult> ConnectCommercialMatch(ConnectCommercialMatchRequest request)
    {
        return Ok(await _service.ConnectCommercialMatch(request));
    }
    /**
        <summary>
            ConsumerBasicCredit
        </summary>
        <param name="request"></param>
        <returns></returns>
        <example>
        <code>
        {
            "DataTicket": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWJzY3JpYmVyaWQiOiIzNzQyNCIsInN1Ym5hbWUiOiJGQ01CIE1JQ1JPIExPQU5TIiwidXNlcm5hbWUiOiJGQ01CUXVpY2tsb2FuQVBJIiwic3lzdGVtdXNlcmlkIjoiMTc1NTAwIiwibmJmIjoxNjgzMjkwNzk5LCJleHAiOjE2ODMzMDE1OTksImlhdCI6MTY4MzI5MDc5OX0.K1NRCdizuJYV1VmPKT1sxTTLPl5srYyiDzMjMIvmp7Q",
            "consumerID": "13352613",
            "EnquiryID": "39059388",
            "consumerMergeList": "13352613,14713314",
            "SubscriberEnquiryEngineID": "178456248"
        }
        </code>
        </example>
    **/
    [HttpPost("ConsumerBasicCredit")]
    public async Task<IActionResult> ConsumerBasicCredit(ConsumerReportRequest request)
    {
        return Ok(await _service.ConsumerBasicCredit(request));
    }
    /**
            <summary>
                ConsumerBasicTrace
            </summary>
            <param name="request"></param>
            <returns></returns>
            <example>
            <code>
            {
                "DataTicket": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWJzY3JpYmVyaWQiOiIzNzQyNCIsInN1Ym5hbWUiOiJGQ01CIE1JQ1JPIExPQU5TIiwidXNlcm5hbWUiOiJGQ01CUXVpY2tsb2FuQVBJIiwic3lzdGVtdXNlcmlkIjoiMTc1NTAwIiwibmJmIjoxNjgzMjkwNzk5LCJleHAiOjE2ODMzMDE1OTksImlhdCI6MTY4MzI5MDc5OX0.K1NRCdizuJYV1VmPKT1sxTTLPl5srYyiDzMjMIvmp7Q",
                "consumerID": "13352613",
                "EnquiryID": "39059388",
                "consumerMergeList": "13352613,14713314",
                "SubscriberEnquiryEngineID": "178456248"
            }
            </code>
            </example>
            
        **/
    [HttpPost("ConsumerBasicTrace")]
    public async Task<IActionResult> ConsumerBasicTrace(ConsumerReportRequest request)
    {
        return Ok(await _service.ConsumerBasicTrace(request));
    }

    [HttpPost("ConsumerFullCredit")]
    public async Task<IActionResult> ConsumerFullCredit(ConsumerReportRequest request)
    {
        return Ok(await _service.ConsumerFullCredit(request));
    }
}