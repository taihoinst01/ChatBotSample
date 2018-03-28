using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatBotSample.DB;

namespace ChatBotSample.Controllers
{
    public class UserController : ApiController
    {
        public static DbConnect db = new DbConnect();
        public static DButil dbutil = new DButil();
        
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            Debug.WriteLine("test1");
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            Debug.WriteLine("test2");
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            Debug.WriteLine("test3");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
            Debug.WriteLine("test4");
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            Debug.WriteLine("test5");
        }
    }
}