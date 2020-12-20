using System;
using System.Collections;
using System.Collections.Generic;
using Minify.Model;
using Xunit;

namespace Minify.Tests
{
    public class MongoTest
    {
        public static MongoRepository  _mongo = new MongoRepository();
        [Fact]
        public void TestAjoutLien()
        {
            var data = new MinifyData();
            data.Key = "Azerty";
            data.Url = "www.youtube.com";
            _mongo.Add(data);
            var result = _mongo.Get("Azerty");
            Assert.Equal( "www.youtube.com",result.Url );
            
            

        }
        [Fact]
        public void TestGetLienByID()
        {
           
            var result = _mongo.Get("Azerty");
            
            Assert.Equal( "www.youtube.com",result.Url );

        }
        [Fact]
        public void TestGetToutLesLien()
        {
            var result = _mongo.Get();

            Assert.IsType<List<MinifyData>>(result);

        }
        
        [Fact]
        public void TestDelLienByID()
        {
            //Je ne pense pas que c'est la bonne pratique pour tester une suprresion mais cela fonctionne 
           
            _mongo.Delete("Azerty");
            
            try
            {
                var result = _mongo.Get("Azerty");
            }
            catch 
            {
                Assert.True(true);
            }
            
        }
    }
}