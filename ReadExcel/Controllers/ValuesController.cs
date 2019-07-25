using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadExcel.Controllers
{
    
    public class ValuesController : ApiController
    {
        IReadExcel readExcel;

        public ValuesController(IReadExcel readExcel)
        {
            this.readExcel = readExcel;
        }
        // GET api/values
        public HttpResponseMessage Get()
        {
            var json = readExcel.ReadFile();
            object jsonObject = JsonConvert.DeserializeObject(json);
            return Request.CreateResponse(HttpStatusCode.OK, jsonObject);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
