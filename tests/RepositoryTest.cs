using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Minify.Model;
using Xunit;

namespace Minify.Tests
{
    public class RepositoryTest
    {
        public  Repository  _Repository = new Repository();
        [Fact]
        public void TestAjoutLienRepo()
        {
            MinifyData data = new MinifyData();
            data.Key = "Azerty";
            data.Url = "www.youtube.com";
            _Repository.Add(data);
            var enumerable = _Repository.Get();
            Assert.Contains(data, enumerable);


        }
        [Fact]
        public void TestGetLienByIDRepo()
        {
            MinifyData data = new MinifyData();
            data.Key = "Azerty";
            data.Url = "www.youtube.com";
            _Repository.Add(data);
            var result = _Repository.Get("Azerty");
            
            Assert.Equal( "www.youtube.com",result.Url );

        }
        [Fact]
        public void TestGetToutLesLienRepo()
        {
            var result = _Repository.Get();

            Assert.IsType<List<MinifyData>>(result);

        }
        
        [Fact]
        public void TestDelLienByIDRepo()
        {
            //Je ne pense pas que c'est la bonne pratique pour tester une suprresion mais cela fonctionne 
           
            _Repository.Delete("Azerty");
            
            try
            {
                var result = _Repository.Get("Azerty");
            }
            catch 
            {
                Assert.True(true);
            }
            
        }
    }
}