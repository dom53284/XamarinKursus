using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using System.Net;

namespace Backend.WebApi
{
    public class NotFoundHandler : IExceptionHandler
    {
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            if (context.Exception is NotFoundException)
            {
                context.Result = new StatusCodeResult(HttpStatusCode.NotFound, context.Request);
            }

            return Task.FromResult(1);
        }
    }
}