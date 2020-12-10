using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTorneos.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IHttpActionResult Get()
        public IEnumerable<string> Get()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            return new string[] { "value1", "value2" , userId };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value " + id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
