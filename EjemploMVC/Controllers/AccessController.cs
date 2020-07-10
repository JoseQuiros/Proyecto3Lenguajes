using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EjemploMVC.Controllers
{
    public class AccessController : Controller
    {

        public IConfiguration Configuration { get; }

        public AccessController(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enter(string user, string password)
        {
            try
            {
                TempData["msg"] = "<script>alert('Change succesfully');</script>";
                return Content("Usuario invalido :(");

            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :( " + ex.Message);
            }

        }
        [HttpPost]
        public IActionResult Login(string user, string password)
        {
   

            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec sp_login_gym @nombreCliente='xs', @contrasena='xs'";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                   SqlDataReader reader= command.ExecuteReader();


                    if (reader.Read())
                    {

                        return Content("correct :( ");
                    }
                    else {
                        return Content("Ocurrio un error :( ");
                    }
                    connection.Close();
          
                }

            } // ModelState.IsValid
            return Content("Ocurrio un error :( ");
        } // Registrar

    }
}