using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace MVC_WebAPI_RPC.Api.Controllers
{
  public class MyApiController : ApiController
  {
    public string Get()
    {
      return "Hello World";
    }
  }
}