using System;
using System.Collections.Generic;
using System.Linq;
using Minify.Interfaces;
using Minify.Model;

namespace Minify
{
    public class Repository : IRepository
    {
        public List<MinifyData> MinifyDatas = new List<MinifyData>();
        
        
        public void Add(MinifyData minifyData)
        {
            MinifyDatas.Add(minifyData);
        }

        public IEnumerable<MinifyData> Get()
        {
            Console.Out.WriteLine(MinifyDatas);
            return MinifyDatas;
        }

        public MinifyData Get(string key)
        {
            return MinifyDatas.Find(data => data.Key == key);
        }

        public void Delete(string key)
        {
            MinifyDatas.Remove( MinifyDatas.Find(data => data.Key == key));
        }
    }
}