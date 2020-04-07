using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    public class HomeController : ControllerBase
    {
        public String Index()
        {
            return "Hello World";
        }
    }
}
