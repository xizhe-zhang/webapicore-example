using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace webapiapp.Controllers
{
    [Route("api/[controller]")]
    public class ScriptController : Controller
    {
        // GET api/values
        [HttpGet]
        public ContentResult Get(string setifunction, string omversion)
        {
            return new ContentResult
            {
                ContentType = "text/plain",
                Content = @"SETIResponse: version=5.796",
                StatusCode = 200
            };
        }

        // POST api/values
        [HttpPost]
        public ContentResult Post(IFormCollection data)
        {
            // var version = "";

            // foreach (string description in data.Keys)
            // {
            //     if (description.Equals("setifunction"))
            //     {
            //         version = data[description];
            //     }
            // }

            // return new ContentResult
            // {
            //     ContentType = "text/plain",
            //     Content = version,
            //     StatusCode = 200
            // };
            return new ContentResult
            {
                ContentType = "text/plain",
                Content = @"SETIResponse: version=5.796",
                StatusCode = 200
            };
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
