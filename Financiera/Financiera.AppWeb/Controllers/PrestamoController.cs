using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Financiera.Logic;

namespace Financiera.AppWeb.Controllers
{
    public class PrestamoController : Controller
    {
        // GET: Prestamo
        public ActionResult Index()
        {
            ListarCliente();
            return View();
        }

        public ActionResult ListarCliente()
        {
            var listaCliente = ClienteBL.Listar();
            ViewBag.lista = listaCliente;
            return View();
        }
    }
}