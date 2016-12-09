using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Backend.WebApi
{
    public class VersionCheckFilter : IActionFilter
    {

        public bool AllowMultiple { get { return false; } }

        public async Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, 
            CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {

            var response = new HttpResponseMessage();
            response.StatusCode = (HttpStatusCode)418; // I'm a teapot
            IEnumerable<string> headerValues;
            if (actionContext.Request.Headers.TryGetValues("X-Version", out headerValues))
            {
                if (headerValues.First() == "42")
                {
                    response = await continuation();
                }
            }

            //var head = actionContext.Request.Headers.Where(p => p.Key == "X-Version");
            //foreach (var item in head)
            //{
            //    foreach (var s in item.Value)
            //    {
            //        if (s == "42")
            //        {
            //            response = await continuation();
            //        }
            //    }
            //}

            return response;

        }
    }
}