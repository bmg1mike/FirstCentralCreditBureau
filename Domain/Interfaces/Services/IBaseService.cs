using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Enums;

namespace Domain.Interfaces.Services
{
    public interface IBaseService : IDisposable
    {
        Task<T?> SendAsync<T>(string url, object request, ApiType apiType, object? headers = null);
    }
}