using Movies.WebApi.Helpers;

namespace Movies.WebApi.Middleware;

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            response.StatusCode = error switch
            {
                AppException e => (int)HttpStatusCode.BadRequest,// custom application error
                KeyNotFoundException e => (int)HttpStatusCode.NotFound,// not found error
                _ => (int)HttpStatusCode.InternalServerError,// unhandled error
            };
            var result = JsonSerializer.Serialize(
                                new { 
                                        message = error?.Message + " | " + 
                                                  error?.InnerException?.Message
                                    }
                                );

            await response.WriteAsync(result);
        }
    }
}