using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Minify.Interfaces;
using Minify.Model;

namespace Minify.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MinifyController : ControllerBase
    {
        public static MongoRepository  _mongo = new MongoRepository();
        public static Repository  _Repository= new Repository();
        // Les fonction avec le _Repository sont commentée pour eviter les confusion. 
        public static TokenGenerator _tokenGenerator = new TokenGenerator();
        
        [HttpPost]
        public void Add([FromBody] MinifyData data)
        {
            data.Key = _tokenGenerator.Generate();
           _mongo.Add(data);
           // _Repository.Add(data);

        }

        [HttpGet]
        public IEnumerable<MinifyData> Get()
        {
           return _mongo.Get();
           //return _Repository.Get();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _mongo.Delete(id);
            //_Repository.Delete(id);
        }
    }
}