using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CustomErrorPages.Controllers.Api
{
    public class DefaultController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        public string Get(int id)
        {
            // API shouldn't return HTML
            throw new Exception("Exception from Web API");
        }
    }
}
