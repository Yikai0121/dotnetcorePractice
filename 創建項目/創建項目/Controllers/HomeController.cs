using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using 創建項目.Services;

namespace 創建項目.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IClock clock)
        {

        }
    }
}
