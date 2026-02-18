namespace progrm2
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next) 
        {
            _next = next;

        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("----Incoming Request------");
            Console.WriteLine($"time: {DateTime.Now}");
            Console.WriteLine($"Method: {context.Request.Method}");
            Console.WriteLine($"path: {context.Request.Path}");
            Console.WriteLine("---------------------------");

            await _next(context);
        }

    }
}
