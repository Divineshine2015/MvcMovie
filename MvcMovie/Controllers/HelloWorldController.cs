﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
            //return "This is my <b>default</b> action..."; 
        }

        // GET: /HelloWorld/Welcome/
       /* public string Welcome() 
        { 
            return "This is the Welcome action method..."; 
        } */
        //public string Welcome(string name,int numTimes=1)
        //{

        //    return HttpUtility.HtmlEncode("hello" + name + ", NumTimes is: " + numTimes);
        //}
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello"+name;
            ViewBag.NUmTimes = numTimes;

            return View();
           // return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }

    } 
    
}