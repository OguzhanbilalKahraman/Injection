using InjectionAndIOC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionAndIOC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            MsSqlOperation mssql = new MsSqlOperation();
            mssql.Connection();


            ISqlOperation sql = new MsSqlOperation();
            sql.Connection();

            ISqlOperation mysql = new MsSqlOperation();
            mysql.Connection();


            return View();
        }
    }
}
