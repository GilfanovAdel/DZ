using Application.Exceptions;

namespace PokemonApi.Middlewares
{
    public class DomainExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public DomainExceptionMiddleware(RequestDelegate next, ILogger<DomainExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }

            catch (ValidateException exception)
            {
                context.Response.Clear();
                context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                context.Response.ContentType = "text/plane";
                await context.Response.WriteAsync(exception.Message);
            }
            catch (ConflictException exception)
            {
                context.Response.Clear();
                context.Response.StatusCode = StatusCodes.Status409Conflict;
                context.Response.ContentType = "text/plane";
                await context.Response.WriteAsync(exception.Message);
            }
            catch (Exception exception)
            {
                const string message = "An unhandled exception has occurred while executing the request.";
                _logger.LogError(exception, message);

                context.Response.Clear();

            }
        }


    }
}
