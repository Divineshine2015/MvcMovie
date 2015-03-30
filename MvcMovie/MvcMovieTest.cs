using MvcMovie.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xunit;

namespace MvcMovie
{
    public class MvcMovieTest
    {
        [Fact]

        public void SomeTest()
        {
            var controller = new HomeController();
            var someView = controller.Index();
            var theView = (ViewResult)someView;
            dynamic model = theView.Model;

            Assert.NotNull(theView);
        }
    }
}