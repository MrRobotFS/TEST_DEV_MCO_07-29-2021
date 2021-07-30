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

        public ActionResult Nuevo()
        {
            return View();
        }

        // An overload is applied to write with the POST method.
        [HttpPost]
        public ActionResult Nuevo(Tb_PersonasFisicasViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (masterEntities db = new masterEntities())
                    {
                        var oTabla = new Tb_PersonasFisicas();
                        oTabla.IdPersonaFisica = model.IdPersonaFisica;
                        oTabla.FechaRegistro = model.FechaNacimiento;
                        oTabla.Nombre = model.Nombre;
                        oTabla.ApellidoPaterno = model.ApellidoPaterno;
                        oTabla.ApellidoMaterno = model.ApellidoMaterno;
                        oTabla.RFC = model.RFC;
                        oTabla.FechaNacimiento = model.FechaNacimiento;
                        oTabla.UsuarioAgrega = model.UsuarioAgrega;
                        oTabla.Activo = model.Activo;

                        //Then add the data into the DB
                        db.Tb_PersonasFisicas.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("/");
                }

                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}