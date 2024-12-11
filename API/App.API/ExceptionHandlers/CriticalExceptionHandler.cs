﻿using App.Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;

namespace App.API.ExceptionHandlers;

public class CriticalExceptionHandler : IExceptionHandler
{
    public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception,
        CancellationToken cancellationToken)
    {
        // business logic

        if (exception is CriticalException)
        {
            Console.WriteLine("hata ile ilgili sms gönderildi");
        }

        return ValueTask.FromResult(false);
    }
}