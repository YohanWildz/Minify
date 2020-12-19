using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Minify.Model;

namespace Minify.Controllers
{
    [Controller]
    [Route("/redirect")]
    public class RedirectController : ControllerBase
    {
        [HttpGet]
        [Route("/redirect/{id}")]
        public IActionResult Get(string id)
        {
            MinifyData data = MinifyController._mongo.Get(id);
            return Redirect(data.Url);
        }
    }
}