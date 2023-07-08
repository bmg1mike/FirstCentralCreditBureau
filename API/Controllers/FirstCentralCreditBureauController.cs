using Domain.DTOs;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class FirstCentralCreditBureauController : ControllerBase
{
    private readonly IFirstCentralCreditBureauService _service;
    private readonly ILogger<FirstCentralCreditBureauController> _logger;

    public FirstCentralCreditBureauController(IFirstCentralCreditBureauService service, ILogger<FirstCentralCreditBureauController> logger)
    {
        _service = service;
        _logger = logger;
    }
    
    [HttpGet("GetDataTicket")]
    public async Task<IActionResult> GetDataTicket()
    {
        return Ok(await _service.Login());
    }
    
    [HttpPost("ConsumerMatch")]
    public async Task<IActionResult> ConnectConsumerMatch(ConnectConsumerMatchRequest request)
    {
        return Ok(await _service.ConnectConsumerMatch(request));
    }
    
    [HttpPost("CommercialMatch")]
    public async Task<IActionResult> ConnectCommercialMatch(ConnectCommercialMatchRequest request)
    {
        HttpContext.Response.Headers.Add("Correlation-Id", Guid.NewGuid().ToString());
        return Ok(await _service.ConnectCommercialMatch(request));
    }
   
    [HttpPost("ConsumerBasicCredit")]
    public async Task<IActionResult> ConsumerBasicCredit(ConsumerReportRequest request)
    {
        return Ok(await _service.ConsumerBasicCredit(request));
    }
    
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

    [HttpPost("ConsumerPrime")]
    public async Task<IActionResult> ConsumerPrime(ConsumerReportRequest request)
    {
        return Ok(await _service.ConsumerPrime(request));
    }

    [HttpPost("XScoreConsumerFullCredit")]
    public async Task<IActionResult> XScoreConsumerFullCredit(ConsumerReportRequest request)
    {
        return Ok(await _service.XScoreConsumerFullCredit(request));
    }

    [HttpPost("XScoreConsumerPrimeReport")]
    public async Task<IActionResult> XScoreConsumerPrimeReport(ConsumerReportRequest request)
    {
        return Ok(await _service.XScoreConsumerPrimeReport(request));
    }
    [HttpPost("ConsumerEnquiry")]
    public async Task<IActionResult> ConsumerEnquiry(ConsumerEnquiryRequest request)
    {
        return Ok(await _service.ConsumerEnquiry(request));
    }
    [HttpPost("CommercialEnquiry")]
    public async Task<IActionResult> CommercialEnquiry(CommercialEnquiryRequest request)
    {
        return Ok(await _service.CommercialEnquiry(request));
    }

    [HttpPost("CommercialFullCredit")]
    public async Task<IActionResult> CommercialFullCredit(CommercialReportRequest request)
    {
        return Ok(await _service.CommercialFullCredit(request));
    }

    [HttpPost("CommercialBasicCredit")]
    public async Task<IActionResult> CommercialBasicCredit(CommercialReportRequest request)
    {
        return Ok(await _service.CommercialBasicCredit(request));
    }
}