using System.Collections.Generic;
using System.Web.Http;
using System.Xml;
using XmlJsonRequestSample.Models;

namespace XmlJsonRequestSample.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string ObjEmp(Emp value)
        {
            return "omer" + value;
        }

        [HttpPost]
        public Response StrEmp([FromBody]string value)
        {
            var omer = value;
            return new Response { Result = 5 };
        }

        [HttpPost]
        public string ReturnXmlDocument()
        {
            var doc = new XmlDocument();
            doc.Load(Request.Content.ReadAsStreamAsync().Result);
            return doc.DocumentElement.OuterXml;
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