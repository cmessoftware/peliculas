
using System.Net;

namespace Peliculas.Common.Extensiones
{
    public static class LoggerExtensions
    {
        public static void LogException(this ILogger log, Exception ex)
        {
            log.LogError(ex, message: GetMessage(ex));
        }

        public static string GetMessage(this ILogger log, Exception ex)
        {
            return GetMessage(ex);
        }

        private static string GetMessage(Exception ex)
        {
            string m = $"Error: {HttpStatusCode.InternalServerError} : ";
            return m + ex.InnerException != null ? 
                       ex.InnerException.Message : string.Empty;
        }
    }
}
