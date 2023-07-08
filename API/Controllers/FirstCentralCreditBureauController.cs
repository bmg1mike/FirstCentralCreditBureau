using System.Net;
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
        var result = await _service.Login();
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return StatusCode(500, result);
    }

    [HttpPost("ConsumerMatch")]
    public async Task<IActionResult> ConnectConsumerMatch(ConnectConsumerMatchRequest request)
    {
        var result = await _service.ConnectConsumerMatch(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("CommercialMatch")]
    public async Task<IActionResult> ConnectCommercialMatch(ConnectCommercialMatchRequest request)
    {
        var result = await _service.ConnectCommercialMatch(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("ConsumerBasicCredit")]
    public async Task<IActionResult> ConsumerBasicCredit(ConsumerReportRequest request)
    {
        var result = await _service.ConsumerBasicCredit(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("ConsumerBasicTrace")]
    public async Task<IActionResult> ConsumerBasicTrace(ConsumerReportRequest request)
    {
        var result = await _service.ConsumerBasicTrace(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("ConsumerFullCredit")]
    public async Task<IActionResult> ConsumerFullCredit(ConsumerReportRequest request)
    {
        var result = await _service.ConsumerFullCredit(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("ConsumerPrime")]
    public async Task<IActionResult> ConsumerPrime(ConsumerReportRequest request)
    {
        var result = await _service.ConsumerPrime(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("XScoreConsumerFullCredit")]
    public async Task<IActionResult> XScoreConsumerFullCredit(ConsumerReportRequest request)
    {
        var result = await _service.XScoreConsumerFullCredit(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("XScoreConsumerPrimeReport")]
    public async Task<IActionResult> XScoreConsumerPrimeReport(ConsumerReportRequest request)
    {
        var result = await _service.XScoreConsumerPrimeReport(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    [HttpPost("ConsumerEnquiry")]
    public async Task<IActionResult> ConsumerEnquiry(ConsumerEnquiryRequest request)
    {
        var result = await _service.ConsumerEnquiry(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    [HttpPost("CommercialEnquiry")]
    public async Task<IActionResult> CommercialEnquiry(CommercialEnquiryRequest request)
    {
        var result = await _service.CommercialEnquiry(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("CommercialFullCredit")]
    public async Task<IActionResult> CommercialFullCredit(CommercialReportRequest request)
    {
        var result = await _service.CommercialFullCredit(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("CommercialBasicCredit")]
    public async Task<IActionResult> CommercialBasicCredit(CommercialReportRequest request)
    {
        var result = await _service.CommercialBasicCredit(request);
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
}