using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Bring the class for map the data with the Entity element
using Web_Api_CRUD.Models;
using Web_Api_CRUD.Models.ViewModels;

namespace Web_Api_CRUD.Controllers
{
    public class Tb_PersonasFisicasController : Controller
    {
        // GET: Tb_PersonasFisicas
        public ActionResult Index()
        {
            List<ListTb_PersonasFisicasViewModel> lst;
            using (masterEntities db = new masterEntities())
            {
                 lst = (from d in db.Tb_PersonasFisicas

                           select new ListTb_PersonasFisicasViewModel
                           {
                               IdPersonaFisica = d.IdPersonaFisica,
                               FechaRegistro = (DateTime)d.FechaRegistro,
                               FechaActualizacion = (DateTime)d.FechaActualizacion,
                               Nombre = d.Nombre,
                               ApellidoPaterno = d.ApellidoPaterno,
                               ApellidoMaterno = d.ApellidoMaterno,
                               RFC = d.RFC,
                               FechaNacimiento = (DateTime)d.FechaNacimiento,
                               UsuarioAgrega = (int)d.UsuarioAgrega,
                               Activo = (bool)d.Activo,
                           }).ToList();
            }

            return View(lst);
        }
    }
}