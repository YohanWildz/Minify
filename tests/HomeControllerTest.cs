using Microsoft.AspNetCore.Mvc;
using Minify.Controllers;
using Minify.Model;
using Xunit;

namespace Minify.Tests
{
    public class HomeControllerTest
    {
        
        // J'ai essayé de produire un test unitaire pour tester la redirection mais je n'ai pas trouvé le moyen de test cela 
        
        
        
        /*[Fact]
        public void TestControllerHome()
        {
            var controller = new RedirectController();

            var result = controller
        }
        */
        
        
        /*
        [Fact]
        public void RedirigerAvecKey()
        {
            const string returnUrl = "www.google.fr";
            MinifyController minifyController = new MinifyController();
            MinifyData minifyData = new MinifyData();
            minifyData.Key = "aaaaa";
            minifyData.Url = "www.google.fr";
            minifyController.Add(minifyData);
            RedirectController controller = new RedirectController();
            var result = controller.Get("aaaa");
            Assert.Equal();
        }
        */
    }
}