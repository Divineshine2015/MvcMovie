using MvcMovie.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xunit;
using MvcMovie.Models;


namespace MVCMoveTest
{
    public class MvcMovieTest
    {
        private MvcMovieContext db = new MvcMovieContext();
        [Fact]

        public void SomeTest()
        {
            var controller = new HomeController();
            var someView = controller.Index();
            var theView = (ViewResult)someView;
            dynamic model = theView.Model;

            Assert.NotNull(theView);
        }

        //[Fact]
        //public void DontCreateDups([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Movie movie)
        //{

        //    db.Movies.Add(movie);
        //    db.SaveChanges();



        //    Assert.DoesNotContain(db.Movies);
        //}
    }
}