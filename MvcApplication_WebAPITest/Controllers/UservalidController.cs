using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcApplication_WebAPITest.Controllers
{
    public class UservalidController : ApiController
    {

        public uservaliddetails Get(int id)
        {
            var result = new uservaliddetails();
            result.Id = id;
            result.Status = false;

            if (id < 6)
            {                
                result.Status = true;
            }

            return result;
        }

        public class uservaliddetails
        {
            public int Id { get; set; }
            public Boolean Status { get; set; }
        }

    }
}
