using CNPM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPM.Controllers
{
    public class BaseController : Controller
    {
        protected DataContext context;
        public BaseController(DataContext context)
        {
            this.context = context;
        }
    }
}
