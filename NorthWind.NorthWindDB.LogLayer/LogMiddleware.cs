using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.IO;
using Newtonsoft.Json;
using NorthWind.NorthWindDB.BLL.LogManager.Abstract;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.LogLayer
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly RecyclableMemoryStreamManager _recyclableMemoryStreamManager;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
            _recyclableMemoryStreamManager = new RecyclableMemoryStreamManager();
        }

        public async Task Invoke(HttpContext httpContext, IRequestLogBLL requestLogBLL,IResponseLogBLL responseLogBLL)
        {
            HttpRequest httpRequest = httpContext.Request;
            
            httpContext.Request.EnableBuffering();
            var requestStream = _recyclableMemoryStreamManager.GetStream();
            await httpContext.Request.Body.CopyToAsync(requestStream);
            httpContext.Request.Body.Position = 0;
            string body = ReadStreamInChunks(requestStream);
            requestLogBLL.Add(httpRequest,body);
            
            
            await _next.Invoke(httpContext);

            HttpResponse httpResponse= httpContext.Response;
            responseLogBLL.Add(httpResponse);
        }

        private string ReadStreamInChunks(Stream stream)
        {
            const int readChunkBufferLength = 4096;
            stream.Seek(0, SeekOrigin.Begin);
            using var textWriter = new StringWriter();
            using var reader = new StreamReader(stream);
            var readChunk = new char[readChunkBufferLength];
            int readChunkLength;
            do
            {
                readChunkLength = reader.ReadBlock(readChunk, 0, readChunkBufferLength);
                textWriter.Write(readChunk, 0, readChunkLength);
            } while (readChunkLength > 0);
            return textWriter.ToString();
        }
    }

    public static class LogMiddlewareExtensions
    {
        public static IApplicationBuilder UseLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
